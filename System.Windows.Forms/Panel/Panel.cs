using System;
using System.Windows.Forms;

namespace Examples {
  class Form1 : Form {
    // The main entry point for the application.
    public static void Main() {
      Application.EnableVisualStyles();
      Application.Run(new Form1());
    }

    public Form1() {
      panel1.BorderStyle = BorderStyle.FixedSingle;
      panel1.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom;
      panel1.Bounds = new System.Drawing.Rectangle(10, 10, 305, 460);

      panel2.BorderStyle = BorderStyle.Fixed3D;
      panel2.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom;
      panel2.Bounds = new System.Drawing.Rectangle(325, 10, 305, 460);

      StartPosition = FormStartPosition.Manual;
      Location = new System.Drawing.Point(200, 200);
      ClientSize = new System.Drawing.Size(640, 480);
      Text = "Panel example";
      Controls.AddRange(new Control[] { panel1, panel2});
    }

    private Panel panel1 = new Panel();
    private Panel panel2 = new Panel();
  }
}
