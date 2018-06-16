using System.Drawing;
using System.Windows.Forms;

namespace Examples {
  class Form1 : Form {
    // The main entry point for the application.
    public static void Main() {
      Application.Run(new Form1());
    }

    public Form1() {
      this.Controls.Add(this.panel1);
      this.ClientSize = new Size(300, 300);

      this.panel1.Location = new Point(10, 10);
      this.panel1.BorderStyle = BorderStyle.Fixed3D;
      this.panel1.Size = new Size(280, 280);
      this.panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;

      this.panel1.Paint += delegate(object sender, PaintEventArgs e) {

        e.Graphics.FillRectangle(brush1, e.ClipRectangle);

        pen1.DashPattern = new float[] {1.0f, 1.0f, 2.0f, 1.0f, 4.0f, 1.0f, 2.0f, 1.0f};
        pen1.DashCap = System.Drawing.Drawing2D.DashCap.Flat;
        pen1.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        e.Graphics.DrawRectangle(pen1, 40, 40, 200, 200);

      };
    }

    private Panel panel1 = new Panel();
    private static TextureBrush brush1 = new TextureBrush(Image.FromFile("../../texture.jpg"));
    private static Pen pen1 = new Pen(new System.Drawing.Drawing2D.LinearGradientBrush(new Point(0, 0), new Point(100, 0), Color.Red, Color.LightPink), 10.0f);
  }
}
