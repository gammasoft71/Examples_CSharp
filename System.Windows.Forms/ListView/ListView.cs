using System;
using System.Windows.Forms;

namespace Examples {
  class MainForm : Form {
    public static void Main() {
      Application.EnableVisualStyles();
      Application.Run(new MainForm());
    }

    public MainForm() {
      this.Text = "ListView example";
      this.ClientSize = new System.Drawing.Size(350, 260);

      this.listView1.Parent = this;
      this.listView1.Location = new System.Drawing.Point(10, 10);
      this.listView1.Size = new System.Drawing.Size(330, 200);
      this.listView1.View = View.Details;

      this.listView1.LargeImageList = new ImageList();
      this.listView1.LargeImageList.ImageSize = new System.Drawing.Size(48, 48);
      this.listView1.LargeImageList.Images.AddRange(new System.Drawing.Image[] {Properties.Resources.Ai, Properties.Resources.Avi, Properties.Resources.Bmp});

      this.listView1.SmallImageList = new ImageList();
      this.listView1.SmallImageList.ImageSize = new System.Drawing.Size(16, 16);
      this.listView1.SmallImageList.Images.AddRange(new System.Drawing.Image[] {Properties.Resources.Ai, Properties.Resources.Avi, Properties.Resources.Bmp});

      this.listView1.Columns.Add("Name", 80);
      this.listView1.Columns.Add("Type", 50);
      this.listView1.Columns.Add("Size", 50);
      this.listView1.Columns.Add("Comment", 140);

      this.listView1.Items.Add("First", 1).SubItems.AddRange(new string[] {"Movie", "5389", "This is the first item"});
      this.listView1.Items.Add("Second", 0).SubItems.AddRange(new string[] {"Picture", "1256", "This is the second item"});
      this.listView1.Items.Add("Third", 2).SubItems.AddRange(new string[] {"Picture", "4284", "This is the third item"});

      this.comboBox1.Location = new System.Drawing.Point(10, 220);
      this.comboBox1.Parent = this;
      this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
      this.comboBox1.Items.AddRange(Enum.GetNames(typeof(View)));
      this.comboBox1.SelectedIndex = (int)this.listView1.View;
      this.comboBox1.SelectedIndexChanged += delegate(object sender, EventArgs e) {
        this.listView1.View = (View)this.comboBox1.SelectedIndex;
      };
    }
    private ListView listView1 = new ListView();
    private ComboBox comboBox1 = new ComboBox();
  }
}
