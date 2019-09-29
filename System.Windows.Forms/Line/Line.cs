using System;
using System.Windows.Forms;

namespace Examples {
  public class Line : UserControl {
    public System.Drawing.Color Color {
      get { return this.BackColor; }
      set { this.BackColor = value; }
    }
  }

  class MainForm : Form {
    public static void Main() {
      Application.EnableVisualStyles();
      Application.Run(new MainForm());
    }

    public MainForm() {
      this.lineSeparator.Color = System.Drawing.SystemColors.Window;
      this.lineSeparator.Bounds = new System.Drawing.Rectangle(10, 10, 280, 2);

      this.lineRed.Color = System.Drawing.Color.Red;
      this.lineRed.Bounds = new System.Drawing.Rectangle(10, 20, 2, 250);

      this.lineGreen.Color = System.Drawing.Color.Green;
      this.lineGreen.Bounds = new System.Drawing.Rectangle(149, 20, 2, 250);

      this.lineBlue.Color = System.Drawing.Color.Blue;
      this.lineBlue.Bounds = new System.Drawing.Rectangle(288, 20, 2, 250);

      this.lineSeparator2.Color = System.Drawing.SystemColors.ControlText;
      this.lineSeparator2.Bounds = new System.Drawing.Rectangle(10, 278, 280, 2);

      this.ClientSize = new System.Drawing.Size(300, 300);
      this.Text = "Lines example";
      this.Controls.AddRange(new Control [] { this.lineSeparator, this.lineRed, this.lineGreen, this.lineBlue, lineSeparator2});
    }

    private Line lineSeparator = new Line();
    private Line lineRed = new Line();
    private Line lineGreen = new Line();
    private Line lineBlue = new Line();
    private Line lineSeparator2 = new Line();
  }
}
