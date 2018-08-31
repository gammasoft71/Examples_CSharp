using System;
using System.Windows.Forms;

namespace Examples {
  class MainForm : Form {
    public static void Main() {
      Application.EnableVisualStyles();
      Application.Run(new MainForm());
    }

    public MainForm() {
      this.Text = "VScrollBar example";

      this.scrollBar1.Parent = this;
      this.scrollBar1.Location = new System.Drawing.Point(30, 10);

      this.scrollBar2.Parent = this;
      this.scrollBar2.Location = new System.Drawing.Point(70, 10);
      this.scrollBar2.Minimum = 0;
      this.scrollBar2.Value = 100;
      this.scrollBar2.Maximum = 200;
      this.scrollBar2.Height = 220;
    }

    private VScrollBar scrollBar1 = new VScrollBar();
    private VScrollBar scrollBar2 = new VScrollBar();
  }
}
