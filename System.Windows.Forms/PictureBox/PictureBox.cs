using System.IO;
using System.Windows.Forms;

namespace Examples {
  class MainForm : Form {
    public static void Main() {
      Application.EnableVisualStyles();
      Application.Run(new MainForm());
    }

    public MainForm() {
      Text = "PictureBox example";
      ClientSize = new System.Drawing.Size(300, 300);

      pictureBox1.Parent = this;
      pictureBox1.BorderStyle = BorderStyle.FixedSingle;
      pictureBox1.Location = new System.Drawing.Point(20, 20);
      pictureBox1.Size = new System.Drawing.Size(260, 260);
      pictureBox1.ImageLocation = "c:\\logo.bmp";
      pictureBox1.Image = Examples.Properties.Resources.Logo;
      pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
      pictureBox1.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom;
    }

    private PictureBox pictureBox1 = new PictureBox();
  }
}
