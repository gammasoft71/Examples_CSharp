using System;
using System.Windows.Forms;

namespace Examples {
  class MainForm : Form {
    public static void Main() {
      Application.EnableVisualStyles();
      Application.Run(new MainForm());
    }

    public MainForm() {
      Text = "Control example";

      control1.Parent = this;
      control1.BackColor = System.Drawing.Color.SpringGreen;
      control1.Cursor = Cursors.Hand;
      control1.Location = new System.Drawing.Point(50, 50);
      control1.Size = new System.Drawing.Size(100, 50);
      control1.Click += delegate {
        control1.BackColor = control1.BackColor == System.Drawing.Color.SpringGreen ? System.Drawing.Color.OrangeRed : System.Drawing.Color.SpringGreen;
      };
    }

    private Control control1 = new Control();
  }
}
