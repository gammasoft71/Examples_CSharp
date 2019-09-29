using System;
using System.Windows.Forms;

namespace Examples {
  class MainForm : Form {
    public static void Main() {
      Application.EnableVisualStyles();
      Application.Run(new MainForm());
    }

    public MainForm() {
      Text = "ListView example";
      ClientSize = new System.Drawing.Size(350, 260);

      listView1.Parent = this;
      listView1.Location = new System.Drawing.Point(10, 10);
      listView1.Size = new System.Drawing.Size(330, 200);
      listView1.View = View.Details;

      listView1.LargeImageList = new ImageList();
      listView1.LargeImageList.ImageSize = new System.Drawing.Size(48, 48);
      listView1.LargeImageList.Images.AddRange(new System.Drawing.Image[] {Properties.Resources.Ai, Properties.Resources.Avi, Properties.Resources.Bmp});

      listView1.SmallImageList = new ImageList();
      listView1.SmallImageList.ImageSize = new System.Drawing.Size(16, 16);
      listView1.SmallImageList.Images.AddRange(new System.Drawing.Image[] {Properties.Resources.Ai, Properties.Resources.Avi, Properties.Resources.Bmp});

      listView1.Columns.Add("Name", 80);
      listView1.Columns.Add("Type", 50);
      listView1.Columns.Add("Size", 50);
      listView1.Columns.Add("Comment", 140);

      listView1.Items.Add("First", 1).SubItems.AddRange(new string[] {"Movie", "5389", "This is the first item"});
      listView1.Items.Add("Second", 0).SubItems.AddRange(new string[] {"Picture", "1256", "This is the second item"});
      listView1.Items.Add("Third", 2).SubItems.AddRange(new string[] {"Picture", "4284", "This is the third item"});

      comboBox1.Location = new System.Drawing.Point(10, 220);
      comboBox1.Parent = this;
      comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
      comboBox1.Items.AddRange(Enum.GetNames(typeof(View)));
      comboBox1.SelectedIndex = (int)listView1.View;
      comboBox1.SelectedIndexChanged += delegate(object sender, EventArgs e) {
        listView1.View = (View)comboBox1.SelectedIndex;
      };
    }
    private ListView listView1 = new ListView();
    private ComboBox comboBox1 = new ComboBox();
  }
}
