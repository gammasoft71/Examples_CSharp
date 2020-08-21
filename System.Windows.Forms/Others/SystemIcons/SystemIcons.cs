using System;
using System.Drawing;
using System.Windows.Forms;

namespace Examples {
  class Form1 : Form {
    [STAThread]
    public static void Main() {
      Application.EnableVisualStyles();
      Application.Run(new Form1());
    }

    public Form1() {
      Text = "SystemIcons Example";
      ClientSize = new System.Drawing.Size(300, 250);
      Controls.AddRange(new Control[] { picture, buttonPrevious, buttonNext});

      pictures.ImageSize = new System.Drawing.Size(32, 32);
      pictures.ColorDepth = ColorDepth.Depth32Bit;
      pictures.Images.AddRange(new Image[] {SystemIcons.Application.ToBitmap(), SystemIcons.Asterisk.ToBitmap(), SystemIcons.Error.ToBitmap(), SystemIcons.Exclamation.ToBitmap(), SystemIcons.Hand.ToBitmap(), SystemIcons.Information.ToBitmap(), SystemIcons.Question.ToBitmap(), SystemIcons.Shield.ToBitmap(), SystemIcons.Warning.ToBitmap(), SystemIcons.WinLogo.ToBitmap()});

      picture.BackColor = SystemColors.Window;
      picture.BackColor = Color.Magenta;
      picture.BorderStyle = BorderStyle.Fixed3D;
      picture.Bounds = new Rectangle(75, 25, 150, 150);
      picture.SizeMode = PictureBoxSizeMode.CenterImage;
      picture.Image = pictures.Images[currentImageIndex];

      buttonPrevious.Text = "&<";
      buttonPrevious.Location = new Point(75, 200);
      buttonPrevious.Enabled = false;
      buttonPrevious.Click += delegate {
        if (currentImageIndex > 0) picture.Image = pictures.Images[--currentImageIndex];
        buttonPrevious.Enabled = currentImageIndex > 0;
        buttonNext.Enabled = true;
      };

      buttonNext.Text = "&>";
      buttonNext.Location = new Point(150, 200);
      buttonNext.Enabled = true;
      buttonNext.Click += delegate {
        if (currentImageIndex < pictures.Images.Count) picture.Image = pictures.Images[++currentImageIndex];
        buttonPrevious.Enabled = currentImageIndex > 0;
        buttonNext.Enabled = currentImageIndex < pictures.Images.Count - 1;
      };
    }

    private int currentImageIndex = 0;
    private ImageList pictures = new ImageList();
    private PictureBox picture = new PictureBox();
    private Button buttonPrevious = new Button();
    private Button buttonNext = new Button();
  }
}
