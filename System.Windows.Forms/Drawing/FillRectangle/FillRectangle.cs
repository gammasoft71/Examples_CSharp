using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Examples {
  class MainForm : Form {
    [STAThread]
    public static void Main() {
      Application.EnableVisualStyles();
      Application.Run(new MainForm());
    }

    public MainForm() {
      Text = "Fill rectangle example";
      ClientSize = new Size(340, 230);
    }

    override protected void OnPaint(PaintEventArgs e) {
      e.Graphics.FillRectangle(new SolidBrush(Color.Transparent), 10, 10, 100, 100);
      e.Graphics.FillRectangle(new SolidBrush(Color.Red), 120, 10, 100, 100);
      e.Graphics.FillRectangle(new LinearGradientBrush(new Rectangle(230, 10, 100, 100), Color.Green, Color.White, LinearGradientMode.Horizontal), 230, 10, 100, 100);
      e.Graphics.FillRectangle(new HatchBrush(HatchStyle.SolidDiamond, Color.Blue, Color.White), 10, 120, 100, 100);
      e.Graphics.FillRectangle(new TextureBrush(CreateImageFromColor(Color.Yellow)), 120, 120, 100, 100);
      base.OnPaint(e);
    }

    private Image CreateImageFromColor(Color color) {
      var texture = new Bitmap(16, 16);
      var g = Graphics.FromImage(texture);
      g.FillEllipse(new SolidBrush(color), 0, 0, texture.Width, texture.Height);
      g.DrawEllipse(new Pen(Color.Black), 0, 0, texture.Width - 1, texture.Height - 1);
      return texture;
    }
  }
}
