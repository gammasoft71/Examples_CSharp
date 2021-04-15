using System.Drawing;
using System.Windows.Forms;

namespace Examples {
  class Form1 : Form {
    public static void Main() {
      Application.EnableVisualStyles();
      Application.Run(new Form1());
    }

    public Form1() {
      ClientSize = new System.Drawing.Size(390, 270);
      Text = "Colored TabPages example";
      Controls.Add(tabControl1);

      imageList.ImageSize = new Size(16, 16);
      for (int index = 0; index < colors.Length; index++ ) {
        var bitmap = new Bitmap(16, 16);
        var g = Graphics.FromImage(bitmap);
        g.FillEllipse(new SolidBrush(colors[index]), 0, 0, bitmap.Width, bitmap.Height);
        g.DrawEllipse(new Pen(Color.Black), 0, 0, bitmap.Width - 1, bitmap.Height - 1);
        imageList.Images.Add(bitmap);

        var tabPage = new TabPage();
        tabPage.BackColor = colors[index];
        tabPage.ImageIndex = index;
        tabPage.Text = colors[index].Name;
        tabControl1.TabPages.Add(tabPage);
      }

      tabControl1.Alignment = TabAlignment.Bottom;
      tabControl1.Dock = DockStyle.Fill;
      tabControl1.ImageList = imageList;
    }

    private ImageList imageList = new ImageList();
    private Color[] colors = new Color[] {Color.LightPink, Color.LightGreen, Color.LightBlue, Color.LightYellow };
    private TabControl tabControl1 = new TabControl();
  }
}
