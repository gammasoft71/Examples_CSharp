using System;
using System.Windows.Forms;

namespace Examples {
  class MainForm : Form {
    public static void Main() {
      Application.EnableVisualStyles();
      Application.Run(new MainForm());
    }

    public MainForm() {
      Text = "Splitter example";
      ClientSize = new System.Drawing.Size(300, 300);

      splitterTop.Parent = this;
      splitterTop.Dock = DockStyle.Top;

      panelTop.Parent = this;
      panelTop.Dock = DockStyle.Top;
      panelTop.Height = 150;
      panelTop.BackColor = System.Drawing.Color.LightPink;

      splitterLeft.Parent = this;
      splitterLeft.Dock = DockStyle.Left;

      panelLeft.Parent = this;
      panelLeft.Dock = DockStyle.Left;
      panelLeft.Width = 70;
      panelLeft.BackColor = System.Drawing.Color.LightBlue;

      splitterRight.Parent = this;
      splitterRight.Dock = DockStyle.Right;

      panelRight.Parent = this;
      panelRight.Dock = DockStyle.Right;
      panelRight.Width = 70;
      panelRight.BackColor = System.Drawing.Color.LightYellow;

      panelFill.Parent = this;
      panelFill.Dock = DockStyle.Fill;
      panelFill.BackColor = System.Drawing.Color.LightGreen;
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
