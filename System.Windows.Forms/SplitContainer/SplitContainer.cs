using System;
using System.Windows.Forms;

namespace Examples {
  class MainForm : Form {
    public static void Main() {
      Application.EnableVisualStyles();
      Application.Run(new MainForm());
    }

    public MainForm() {
      Text = "SplitContainer example";
      ClientSize = new System.Drawing.Size(300, 300);

      splitContainerLeft.Parent = this;
      splitContainerLeft.Dock = DockStyle.Fill;
      splitContainerLeft.SplitterDistance = 70;
      splitContainerLeft.Panel1.BackColor = System.Drawing.Color.LightBlue;

      splitContainerRight.Parent = splitContainerLeft.Panel2;
      splitContainerRight.Dock = DockStyle.Fill;
      splitContainerRight.SplitterDistance = 160;
      splitContainerRight.Panel2.BackColor = System.Drawing.Color.LightYellow;

      splitContainerCenter.Parent = splitContainerRight.Panel1;
      splitContainerCenter.Dock = DockStyle.Fill;
      splitContainerCenter.Orientation = Orientation.Horizontal;
      splitContainerCenter.SplitterDistance = 147;
      splitContainerCenter.Panel1.BackColor = System.Drawing.Color.LightPink;
      splitContainerCenter.Panel2.BackColor = System.Drawing.Color.LightGreen;
    }

    private SplitContainer splitContainerLeft = new SplitContainer();
    private SplitContainer splitContainerRight = new SplitContainer();
    private SplitContainer splitContainerCenter = new SplitContainer();
  }
}
