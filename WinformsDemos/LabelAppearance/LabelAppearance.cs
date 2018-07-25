using System;
using System.Drawing;
using System.Windows.Forms;

namespace Examples {
  class Form1 : Form {
    // The main entry point for the application.
    public static void Main() {
      Application.EnableVisualStyles();
      Application.Run(new Form1());
    }

    public Form1() {
      this.label1.Text = "Label";
      this.label1.Location = new System.Drawing.Point(10, 10);

      this.label2.Text = "Label";
      this.label2.Location = new System.Drawing.Point(160, 10);
      this.label2.Enabled = false;

      this.Text = "Label appearance";
      this.Controls.AddRange(new Control[] { this.label1, this.label2 });
      this.ClientSize = new Size(300, 110);
    }

    private Label label1 = new Label();
    private Label label2 = new Label();
  }
}
