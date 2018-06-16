using System;
using System.Windows.Forms;

namespace Examples {
  class MainForm : Form {
    public static void Main() {
      Application.EnableVisualStyles();
      Application.Run(new MainForm());
    }

    public MainForm() {
      this.lineSeparator.BorderStyle = BorderStyle.Fixed3D;
      this.lineSeparator.Bounds = new System.Drawing.Rectangle(10, 10, 280, 2);

      this.lineRed.BackColor = System.Drawing.Color.Red;
      this.lineRed.Bounds = new System.Drawing.Rectangle(10, 20, 2, 250);

      this.lineGreen.BackColor = System.Drawing.Color.Green;
      this.lineGreen.Bounds = new System.Drawing.Rectangle(149, 20, 2, 250);

      this.lineBlue.BackColor = System.Drawing.Color.Blue;
      this.lineBlue.Bounds = new System.Drawing.Rectangle(288, 20, 2, 250);

      this.lineSeparator2.BorderStyle = BorderStyle.FixedSingle;
      this.lineSeparator2.Bounds = new System.Drawing.Rectangle(10, 278, 280, 2);

      this.ClientSize = new System.Drawing.Size(300, 300);
      this.Text = "Lines example";
      this.Controls.AddRange(new Control [] { this.lineSeparator, this.lineRed, this.lineGreen, this.lineBlue, lineSeparator2});
    }

    private Label lineSeparator = new Label();
    private Label lineRed = new Label();
    private Label lineGreen = new Label();
    private Label lineBlue = new Label();
    private Label lineSeparator2 = new Label();
  }
}
