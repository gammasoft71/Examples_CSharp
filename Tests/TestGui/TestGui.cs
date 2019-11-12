using System;
using System.Drawing;
using System.Windows.Forms;

namespace Examples {
  class MainForm : Form {
    public static void Main() {
      Application.EnableVisualStyles();
      Application.Run(new MainForm());
    }

    public MainForm() {
      Text = "TestGui";
      AutoScroll = true;
      AutoScrollMargin = new Size(10, 10);

      panel.Location = new Point(350, 350);
      panel.BackColor = Color.SpringGreen;
      panel.Parent = this;

      AutoScrollPosition = new Point(300, 300);
      System.Diagnostics.Debug.WriteLine(string.Format("DispalyRectangle = {0}", DisplayRectangle));
    }

    private Panel panel = new Panel();
  }
}
