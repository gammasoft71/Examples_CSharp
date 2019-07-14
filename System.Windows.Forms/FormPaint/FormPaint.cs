using System;
using System.Windows.Forms;

namespace Examples {
  class Form1 : Form {
    public static void Main() {
      Application.EnableVisualStyles();
      Application.Run(new Form1());
    }

    public Form1() {
      this.Text = "Paint example";
      this.StartPosition = FormStartPosition.Manual;
      this.Location = new System.Drawing.Point(100, 100);
      this.ClientSize = new System.Drawing.Size(640, 480);

      this.Paint += delegate  (object sender, PaintEventArgs e) {
        System.Drawing.StringFormat stringFormat = new System.Drawing.StringFormat();
        e.Graphics.FillRectangle(new System.Drawing.SolidBrush(System.Drawing.Color.Blue), 0, 0, 640, 480);
        e.Graphics.Clear(System.Drawing.Color.LightYellow);
        e.Graphics.DrawRectangle(new System.Drawing.Pen(System.Drawing.Color.LightPink, 10), e.ClipRectangle);
        e.Graphics.DrawLine(new System.Drawing.Pen(System.Drawing.Color.LightSteelBlue, 5), 20, 60, 260, 60);
        e.Graphics.FillRectangle(new System.Drawing.SolidBrush(System.Drawing.Color.LightBlue), 50, 300, 400, 50);
        e.Graphics.DrawLine(new System.Drawing.Pen(System.Drawing.Color.Red, 1), 0, 0, 1, 1);
        e.Graphics.DrawString("Draw string", new System.Drawing.Font("Arial", 34, System.Drawing.FontStyle.Regular), new System.Drawing.SolidBrush(System.Drawing.Color.LightGreen), 20, 0, stringFormat);
        e.Graphics.FillRectangle(new System.Drawing.SolidBrush(System.Drawing.Color.LightSeaGreen), 400, 70, 100, 200);
        e.Graphics.DrawArc(new System.Drawing.Pen(System.Drawing.Color.Black, 10), 400, 70, 100, 200, 45.0f, 270.0f);
        e.Graphics.DrawEllipse(new System.Drawing.Pen(System.Drawing.Color.Red, 10), 100, 80, 200, 200);
        e.Graphics.FillPie(new System.Drawing.SolidBrush(System.Drawing.Color.Green), 120, 100, 160, 160, 45.0f, 270.0f);
        e.Graphics.FillPie(new System.Drawing.SolidBrush(System.Drawing.Color.LightGreen), 120, 100, 160, 160, 270.0f, 180.0f);
        e.Graphics.DrawBezier(new System.Drawing.Pen(System.Drawing.Color.Black), 100, 100, 150, 150, 200, 100, 250, 50);
      };
    }

    private Label label1 = new Label();
  }
}
