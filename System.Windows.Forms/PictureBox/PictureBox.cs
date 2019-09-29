using System.IO;
using System.Windows.Forms;

namespace Examples {
  class MainForm : Form {
    public static void Main() {
      Application.EnableVisualStyles();
      Application.Run(new MainForm());
    }

    public MainForm() {
      pictureBox1.Parent = this;
      pictureBox1.Size = new System.Drawing.Size(280, 280);
      pictureBox1.Location = new System.Drawing.Point(10, 10);
      pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
      pictureBox1.Image = Examples.Properties.Resources.Logo;
      pictureBox1.BorderStyle = BorderStyle.FixedSingle;

      Text = "PictureBox example";
      ClientSize = new System.Drawing.Size(300, 300);
    }

    private PictureBox pictureBox1 = new PictureBox();
  }
}
