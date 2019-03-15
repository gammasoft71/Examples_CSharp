using System;
using System.Windows.Forms;

namespace Examples {
  class MainForm : Form {
    public static void Main() {
      Application.EnableVisualStyles();
      Application.Run(new MainForm());
    }

    public MainForm() {
      this.Text = "Splitter example";
      this.ClientSize = new System.Drawing.Size(300, 300);

      this.splitterTop.Parent = this;
      this.splitterTop.Dock = DockStyle.Top;

      this.panelTop.Parent = this;
      this.panelTop.Dock = DockStyle.Top;
      this.panelTop.Height = 150;
      this.panelTop.BackColor = System.Drawing.Color.LightPink;

      this.splitterLeft.Parent = this;
      this.splitterLeft.Dock = DockStyle.Left;

      this.panelLeft.Parent = this;
      this.panelLeft.Dock = DockStyle.Left;
      this.panelLeft.Width = 70;
      this.panelLeft.BackColor = System.Drawing.Color.LightBlue;

      this.splitterRight.Parent = this;
      this.splitterRight.Dock = DockStyle.Right;

      this.panelRight.Parent = this;
      this.panelRight.Dock = DockStyle.Right;
      this.panelRight.Width = 70;
      this.panelRight.BackColor = System.Drawing.Color.LightYellow;

      this.panelFill.Parent = this;
      this.panelFill.Dock = DockStyle.Fill;
      this.panelFill.BackColor = System.Drawing.Color.LightGreen;
    }

    private Splitter splitterTop = new Splitter();
    private Panel panelTop = new Panel();
    private Splitter splitterLeft = new Splitter();
    private Panel panelLeft = new Panel();
    private Splitter splitterRight = new Splitter();
    private Panel panelRight = new Panel();
    private Panel panelFill = new Panel();
  }
}
