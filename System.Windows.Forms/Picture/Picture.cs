using System;
using System.Drawing;
using System.Windows.Forms;

namespace Examples {
  class MainForm : Form {
    [STAThread]
    public static void Main() {
      Application.EnableVisualStyles();
      Application.Run(new MainForm());
    }

    public MainForm() {
      this.Menu = new MainMenu();
      this.Menu.MenuItems.Add("File");
      this.Menu.MenuItems[0].MenuItems.Add(new MenuItem("Open...", this.OnMenuItemOpenClick, Shortcut.CtrlO));
      this.Menu.MenuItems[0].MenuItems.Add("-");
      this.Menu.MenuItems[0].MenuItems.Add(new MenuItem("Quit", this.OnMenuItemQuitClick, Shortcut.CtrlQ));
      this.pictureBox.Parent = this;
      //this.pictureBox1.Dock = DockStyle.Fill;
      this.pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
      this.pictureBox.ContextMenu = new ContextMenu();
      this.pictureBox.ContextMenu.MenuItems.AddRange(new MenuItem[] {
        new MenuItem("&Bmp", this.OnMenuItemExportBmpClick),
        new MenuItem("&Emf", this.OnMenuItemExportEmfClick),
        new MenuItem("&Exif", this.OnMenuItemExportExifClick),
        new MenuItem("&Gif", this.OnMenuItemExportGifClick),
        new MenuItem("&Icon", this.OnMenuItemExportIconClick),
        new MenuItem("&Jpeg", this.OnMenuItemExportJpegClick),
        new MenuItem("&Png", this.OnMenuItemExportPngClick),
        new MenuItem("&Tiff", this.OnMenuItemExportTiffClick),
        new MenuItem("&Wmf", this.OnMenuItemExportWmfClick),
      });

      this.AutoScroll = true;
      this.Text = "Picture";
    }

    void OnMenuItemOpenClick(object sender, EventArgs e) {
      OpenFileDialog openFileDialog = new OpenFileDialog();
      openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
      openFileDialog.Filter = "Image Files|*.bmp;*.emf;*.exif;*.gif;*.ico;*.jpg;*.jpeg;*.png;*.tif;*.tiff;*.wmf|All|*.*";

      if (openFileDialog.ShowDialog() == DialogResult.OK) {
        this.pictureName = openFileDialog.FileName;
        this.Text =string.Format( "Picture - [{0}]", this.pictureName);
        this.pictureBox.Image = Bitmap.FromFile(openFileDialog.FileName);
        for (int y = 0; y < this.pictureBox.Image.Height; y++) {
          for (int x = 0; x < this.pictureBox.Image.Width; x++)
            System.Diagnostics.Debug.Write(string.Format("{0, -35} ", (this.pictureBox.Image as Bitmap).GetPixel(x, y)));
          System.Diagnostics.Debug.WriteLine("");
        }
      }
    }

    void OnMenuItemExportBmpClick(object sender, EventArgs e) {
      this.pictureBox.Image.Save(this.pictureName + ".bmp", System.Drawing.Imaging.ImageFormat.Bmp);
    }

    void OnMenuItemExportEmfClick(object sender, EventArgs e) {
      this.pictureBox.Image.Save(this.pictureName + ".emf", System.Drawing.Imaging.ImageFormat.Emf);
    }

    void OnMenuItemExportExifClick(object sender, EventArgs e) {
      this.pictureBox.Image.Save(this.pictureName + ".exif", System.Drawing.Imaging.ImageFormat.Exif);
    }

    void OnMenuItemExportGifClick(object sender, EventArgs e) {
      this.pictureBox.Image.Save(this.pictureName + ".gif", System.Drawing.Imaging.ImageFormat.Gif);
    }

    void OnMenuItemExportIconClick(object sender, EventArgs e) {
      this.pictureBox.Image.Save(this.pictureName + ".ico", System.Drawing.Imaging.ImageFormat.Icon);
    }

    void OnMenuItemExportJpegClick(object sender, EventArgs e) {
      this.pictureBox.Image.Save(this.pictureName + ".jpeg", System.Drawing.Imaging.ImageFormat.Jpeg);
    }

    void OnMenuItemExportPngClick(object sender, EventArgs e) {
      this.pictureBox.Image.Save(this.pictureName + ".png", System.Drawing.Imaging.ImageFormat.Png);
    }

    void OnMenuItemExportTiffClick(object sender, EventArgs e) {
      this.pictureBox.Image.Save(this.pictureName + ".tiff", System.Drawing.Imaging.ImageFormat.Tiff);
    }

    void OnMenuItemExportWmfClick(object sender, EventArgs e) {
      this.pictureBox.Image.Save(this.pictureName + ".wmf", System.Drawing.Imaging.ImageFormat.Wmf);
    }

    void OnMenuItemQuitClick(object sender, EventArgs e) {
      this.Close();
    }

    private PictureBox pictureBox = new PictureBox();
    private string pictureName;
  }
}
