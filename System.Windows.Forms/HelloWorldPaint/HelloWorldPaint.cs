using System;
using System.Drawing;
using System.Windows.Forms;

namespace Examples {
  class Form1 : Form {
    public static void Main() {
      Application.Run(new Form1());
    }

    public Form1() {
      this.panel.BackColor = SystemColors.ControlLight;
      this.panel.Bounds = new Rectangle(20, 20, 290, 60);
      this.panel.Font = new Font(this.panel.Font.FontFamily.Name, 18.0f);
      this.panel.Paint += new PaintEventHandler(this.OnPanelPaint);
      this.panel.SizeChanged += new EventHandler(this.OnPanelSizeChanged);
 
      this.textBox.Location = new Point(20, 90);
      this.textBox.Text = "Hello, World !";
      this.textBox.Width = 290;

      this.timer.Interval = 60;
      this.timer.Tick += new EventHandler(this.OnTimer);
      this.timer.Enabled = true;

      this.ClientSize = new Size(330, 130);
      this.Controls.AddRange(new Control[] {this.panel, this.textBox});
      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.Text = "Wiggly";
    }

    protected void OnPanelPaint(object sender, PaintEventArgs e) {
      Point pos = new Point((e.ClipRectangle.Size.Width - (int)e.Graphics.MeasureString(this.textBox.Text, this.panel.Font).Width) / 2 - 40, (e.ClipRectangle.Size.Height - (int)e.Graphics.MeasureString(this.textBox.Text, this.panel.Font).Height) / 2);
      for (int i = 0; i < this.textBox.Text.Length; i++) {
        int index = (this.step + i) % sin.Length;
        e.Graphics.DrawString(this.textBox.Text[i].ToString(), this.panel.Font, new SolidBrush(HsbToRgb((float)(15 - index) * 16 / 255 * 360, 1.0f, 0.75f)), new Point(pos.X, pos.Y + sin[index] * (e.ClipRectangle.Height - this.panel.Font.Height) / 400));
        pos.X += (int)e.Graphics.MeasureString(this.textBox.Text[i].ToString(), this.panel.Font).Width;
      }
    }

    protected void OnPanelSizeChanged(object sener, EventArgs e) {
      this.panel.Refresh();
    }

    protected void OnTimer(object sender, EventArgs e) {
      this.step++;
      this.panel.Refresh();
    }

    private static readonly int[] sin = { 0, 38, 71, 92, 100, 92, 71, 38, 0, -38, -71, -92, -100, -92, -71, -38 };
    private Panel panel = new Panel();
    private TextBox textBox = new TextBox();
    private Timer timer = new Timer();
    private int step = 0;

    private static Color HsbToRgb(float hue, float saturation, float brightness) {
      if (saturation == 0)
        return Color.FromArgb(255, (byte)(brightness * 255.0), (byte)(brightness * 255.0), (byte)(brightness * 255.0));

      hue = hue == 360 ? 0 : hue / 60;

      float f = hue - (float)Math.Truncate(hue);
      float p = brightness * (1.0f - saturation);
      float q = brightness * (1.0f - (saturation * f));
      float t = brightness * (1.0f - (saturation * (1.0f - f)));

      switch ((int)Math.Truncate(hue)) {
        case 0: return Color.FromArgb(255, (byte)(brightness * 255.0), (byte)(t * 255.0), (byte)(p * 255.0));
        case 1: return Color.FromArgb(255, (byte)(q * 255.0), (byte)(brightness * 255.0), (byte)(p * 255.0));
        case 2: return Color.FromArgb(255, (byte)(p * 255.0), (byte)(brightness * 255.0), (byte)(t * 255.0));
        case 3: return Color.FromArgb(255, (byte)(p * 255.0), (byte)(q * 255.0), (byte)(brightness * 255.0));
        case 4: return Color.FromArgb(255, (byte)(t * 255.0), (byte)(p * 255.0), (byte)(brightness * 255.0));
        default: return Color.FromArgb(255, (byte)(brightness * 255.0), (byte)(p * 255.0), (byte)(q * 255.0));
      }
    }
  }
}
