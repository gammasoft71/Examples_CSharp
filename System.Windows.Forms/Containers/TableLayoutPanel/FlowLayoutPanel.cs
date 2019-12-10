using System;
using System.Drawing;
using System.Windows.Forms;

namespace Examples {
  class MainForm : Form {
    public static void Main() {
      Application.EnableVisualStyles();
      Application.Run(new MainForm());
    }

    public MainForm() {
      Text = "TableLayoutPanel example";

      tableLayoutPanel1.Parent = this;
      tableLayoutPanel1.Dock = DockStyle.Fill;
      tableLayoutPanel1.ColumnCount = columnCount;
      tableLayoutPanel1.RowCount = rowCount;
      for (int index = 0; index < tableLayoutPanel1.ColumnCount; index++)
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, tableLayoutPanel1.ColumnCount));
      for (int index = 0; index < tableLayoutPanel1.RowCount; index++)
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, tableLayoutPanel1.RowCount));

      for (int y = 0; y < buttons.GetLength(1); y++) {
        for (int x = 0; x < buttons.GetLength(0); x++) {
          buttons[x, y] = new CheckBox();
          buttons[x, y].AutoCheck = false;
          buttons[x, y].Appearance = Appearance.Button;
          buttons[x, y].BackColor = Color.LightGray;
          buttons[x, y].Parent = tableLayoutPanel1;
          buttons[x, y].Margin = new Padding(0);
          buttons[x, y].Size = new Size(1000, 1000);
          buttons[x, y].FlatStyle = FlatStyle.Flat;
          buttons[x, y].Tag = Tuple.Create(x, y);
          buttons[x, y].TextAlign = ContentAlignment.MiddleCenter;
          buttons[x, y].MouseDown += delegate (object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Right) {
              CheckBox checkBox = sender as CheckBox;
              int currentX = (checkBox.Tag as Tuple<int, int>).Item1;
              int currentY = (checkBox.Tag as Tuple<int, int>).Item2;
              if (!buttons[currentX, currentY].Checked) {
                if (buttons[currentX, currentY].Text == "") buttons[currentX, currentY].Text = "F";
                else if (buttons[currentX, currentY].Text == "F") buttons[currentX, currentY].Text = "?";
                else if (buttons[currentX, currentY].Text == "?") buttons[currentX, currentY].Text = "";
              }
            }
          };

          buttons[x, y].Click += delegate(object sender, EventArgs e) {
            CheckBox checkBox = sender as CheckBox;
            int currentX = (checkBox.Tag as Tuple<int, int>).Item1;
            int currentY = (checkBox.Tag as Tuple<int, int>).Item2;
            if (!checkBox.Checked && checkBox.Text == "") {

              if (mines[currentX, currentY]) {
                buttons[currentX, currentY].BackColor = Color.Red;
                for (int index1 = 0; index1 < buttons.GetLength(1); index1++) {
                  for (int index2 = 0; index2 < buttons.GetLength(0); index2++) {
                    if (mines[index2, index1]) {
                      buttons[index2, index1].Checked = true;
                      buttons[index2, index1].Text = "M";
                    }
                  }
                }
                MessageBox.Show("Booom", "Mine");
                InitGames();
              } else {
                checknNeighbors(currentX, currentY);
              }
            }
          };
        }
      }
      InitGames();
    }

    void checknNeighbors(int currentX, int currentY) {
      int mineCount = CheckedCell(currentX, currentY);
      if (mineCount == 0) {
        for (int index1 = currentY - 1; index1 <= currentY + 1; index1++) {
          for (int index2 = currentX - 1; index2 <= currentX + 1; index2++) {
            if (index1 >= 0 && index1 < columnCount && index2 >= 0 && index2 < rowCount && buttons[index2, index1].Checked == false && CheckedCell(index2, index1) == 0) {
              checknNeighbors(index2, index1);
            }
          }
        }
      }
    }

    int CheckedCell(int currentX, int currentY) {
      buttons[currentX, currentY].Checked = true;
      buttons[currentX, currentY].BackColor = Color.White;

      int mineCount = 0;
      for (int index1 = currentY - 1; index1 <= currentY + 1; index1++) {
        for (int index2 = currentX - 1; index2 <= currentX + 1; index2++) {
          if (index1 >= 0 && index1 < columnCount && index2 >= 0 && index2 < rowCount && mines[index2, index1]) {
            mineCount++;
          }
        }
      }

      if (mineCount == 6) buttons[currentX, currentY].ForeColor = Color.Black;
      if (mineCount == 5) buttons[currentX, currentY].ForeColor = Color.DarkRed;
      if (mineCount == 4) buttons[currentX, currentY].ForeColor = Color.DarkBlue;
      if (mineCount == 3) buttons[currentX, currentY].ForeColor = Color.Red;
      if (mineCount == 2) buttons[currentX, currentY].ForeColor = Color.Green;
      if (mineCount == 1) buttons[currentX, currentY].ForeColor = Color.Blue;
      if (mineCount == 0) buttons[currentX, currentY].ForeColor = Color.Black;
      if (mineCount != 0) buttons[currentX, currentY].Text = mineCount.ToString();
      return mineCount;
    }

    void InitGames() {
      for (int y = 0; y < buttons.GetLength(1); y++) {
        for (int x = 0; x < buttons.GetLength(0); x++) {
          mines[x, y] = false;
          buttons[x, y].BackColor = Color.LightGray;
          buttons[x, y].ForeColor = Color.Black;
          buttons[x, y].Checked = false;
          buttons[x, y].Text = "";
        }
      }
      
      Random rand = new Random();
      for (int count = 0; count < mineCount; count++) {
        int x = rand.Next(0, columnCount);
        int y = rand.Next(0, rowCount);

        if (mines[x, y] == true) {
          count--;
          continue;
        }
        mines[x, y] = true;
      }
    }

    readonly static int mineCount = 10;
    readonly static int columnCount = 9;
    readonly static int rowCount = 9;
    private TableLayoutPanel tableLayoutPanel1 = new TableLayoutPanel();
    CheckBox[,] buttons = new CheckBox[rowCount, columnCount];
    bool[,] mines = new bool[columnCount, rowCount];
  }
}
