using System;
using System.Windows.Forms;

namespace Examples {
  class MainForm : Form {
    public static void Main() {
      Application.EnableVisualStyles();
      Application.Run(new MainForm());
    }

    public MainForm() {
      this.Text = "HScrollBar example";

      this.scrollBar1.Parent = this;
      this.scrollBar1.Location = new System.Drawing.Point(30, 40);

      this.scrollBar2.Parent = this;
      this.scrollBar2.Location = new System.Drawing.Point(30, 80);
      this.scrollBar2.Minimum = 0;
      this.scrollBar2.Value = 100;
      this.scrollBar2.Maximum = 200;
      this.scrollBar2.Width = 220;
    }

    private HScrollBar scrollBar1 = new HScrollBar();
    private HScrollBar scrollBar2 = new HScrollBar();
  }
}
