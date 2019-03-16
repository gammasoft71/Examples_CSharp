using System;
using System.Windows.Forms;

namespace Examples {
  class MainForm : Form {
    public static void Main() {
      Application.EnableVisualStyles();
      Application.Run(new MainForm());
    }

    public MainForm() {
      this.Text = "SplitContainer example";
      this.ClientSize = new System.Drawing.Size(300, 300);

      this.splitContainerLeft.Parent = this;
      this.splitContainerLeft.Dock = DockStyle.Fill;
      this.splitContainerLeft.SplitterDistance = 70;
      this.splitContainerLeft.Panel1.BackColor = System.Drawing.Color.LightBlue;

      this.splitContainerRight.Parent = this.splitContainerLeft.Panel2;
      this.splitContainerRight.Dock = DockStyle.Fill;
      this.splitContainerRight.SplitterDistance = 160;
      this.splitContainerRight.Panel2.BackColor = System.Drawing.Color.LightYellow;

      this.splitContainerCenter.Parent = this.splitContainerRight.Panel1;
      this.splitContainerCenter.Dock = DockStyle.Fill;
      this.splitContainerCenter.Orientation = Orientation.Horizontal;
      this.splitContainerCenter.SplitterDistance = 147;
      this.splitContainerCenter.Panel1.BackColor = System.Drawing.Color.LightPink;
      this.splitContainerCenter.Panel2.BackColor = System.Drawing.Color.LightGreen;
    }

    private SplitContainer splitContainerLeft = new SplitContainer();
    private SplitContainer splitContainerRight = new SplitContainer();
    private SplitContainer splitContainerCenter = new SplitContainer();
  }
}
