using System.IO;
using System.Windows.Forms;

namespace Examples {
  class MainForm : Form {
    public static void Main() {
      Application.EnableVisualStyles();
      Application.Run(new MainForm());
    }

    public MainForm() {
      this.pictureBox1.Parent = this;
      this.pictureBox1.Size = new System.Drawing.Size(280, 280);
      this.pictureBox1.Location = new System.Drawing.Point(10, 10);
      this.pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
      this.pictureBox1.Load(Path.Combine("Resources", "Logo.png"));

      this.Text = "PictureBox example";
      this.ClientSize = new System.Drawing.Size(300, 300);
    }

    private PictureBox pictureBox1 = new PictureBox();
  }
}
