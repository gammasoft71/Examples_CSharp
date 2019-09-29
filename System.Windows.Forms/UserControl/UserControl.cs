using System;
using System.Windows.Forms;

namespace Examples {
  class MainForm : Form {
    public static void Main() {
      Application.EnableVisualStyles();
      Application.Run(new MainForm());
    }

    public MainForm() {
      Text = "UserControl example";

      userControl1.Parent = this;
      userControl1.BackColor = System.Drawing.Color.LightBlue;
      userControl1.Cursor = Cursors.Hand;
      userControl1.Location = new System.Drawing.Point(50, 50);
      userControl1.DoubleClick += delegate {
        userControl1.BackColor = userControl1.BackColor == System.Drawing.Color.LightBlue ? System.Drawing.Color.LightPink : System.Drawing.Color.LightBlue;
      };
    }

    private UserControl userControl1 = new UserControl();
  }
}
