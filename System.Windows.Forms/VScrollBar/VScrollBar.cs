using System;
using System.Windows.Forms;

namespace Examples {
  class MainForm : Form {
    public static void Main() {
      Application.EnableVisualStyles();
      Application.Run(new MainForm());
    }

    public MainForm() {
      Text = "VScrollBar example";

      scrollBar1.Parent = this;
      scrollBar1.Location = new System.Drawing.Point(30, 10);

      scrollBar2.Parent = this;
      scrollBar2.Location = new System.Drawing.Point(70, 10);
      scrollBar2.Minimum = 0;
      scrollBar2.Value = 100;
      scrollBar2.Maximum = 200;
      scrollBar2.Height = 220;
    }

    private VScrollBar scrollBar1 = new VScrollBar();
    private VScrollBar scrollBar2 = new VScrollBar();
  }
}
