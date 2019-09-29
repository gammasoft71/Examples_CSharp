using System;
using System.Windows.Forms;

namespace Examples {
  class MainForm : Form {
    public static void Main() {
      Application.EnableVisualStyles();
      Application.Run(new MainForm());
    }

    public MainForm() {
      Text = "HScrollBar example";

      scrollBar1.Parent = this;
      scrollBar1.Location = new System.Drawing.Point(30, 40);

      scrollBar2.Parent = this;
      scrollBar2.Location = new System.Drawing.Point(30, 80);
      scrollBar2.Minimum = 0;
      scrollBar2.Value = 100;
      scrollBar2.Maximum = 200;
      scrollBar2.Width = 220;
    }

    private HScrollBar scrollBar1 = new HScrollBar();
    private HScrollBar scrollBar2 = new HScrollBar();
  }
}
