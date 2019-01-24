using System;
using System.Windows.Forms;

namespace Examples {
  class MainForm : Form {
    public static void Main() {
      Application.EnableVisualStyles();
      Application.Run(new MainForm());
    }

    public MainForm() {
      this.Text = "Control example";

      this.control1.Parent = this;
      this.control1.BackColor = System.Drawing.Color.SpringGreen;
      this.control1.Cursor = Cursors.Hand;
      this.control1.Location = new System.Drawing.Point(50, 50);
      this.control1.Size = new System.Drawing.Size(100, 50);
    }

    private Control control1 = new Control();
  }
}
