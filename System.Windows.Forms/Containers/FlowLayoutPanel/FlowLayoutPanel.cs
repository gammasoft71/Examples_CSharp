using System;
using System.Windows.Forms;

namespace Examples {
  class MainForm : Form {
    public static void Main() {
      Application.EnableVisualStyles();
      Application.Run(new MainForm());
    }

    public MainForm() {
      Text = "FlowLayoutPanel example";

      flowLayoutPanelCenter.Parent = this;
      flowLayoutPanelCenter.Dock = DockStyle.Fill;
      flowLayoutPanelCenter.FlowDirection = FlowDirection.TopDown;
      flowLayoutPanelCenter.AutoScroll = true;

      panel1.Parent = flowLayoutPanelCenter;
      panel1.BackColor = System.Drawing.Color.LightPink;

      panel2.Parent = flowLayoutPanelCenter;
      panel2.BackColor = System.Drawing.Color.LightGreen;

      panel3.Parent = flowLayoutPanelCenter;
      panel3.BackColor = System.Drawing.Color.LightBlue;

      panel4.Parent = flowLayoutPanelCenter;
      panel4.BackColor = System.Drawing.Color.LightYellow;

      flowLayoutPanelTop.Parent = this;
      flowLayoutPanelTop.Dock = DockStyle.Top;
      flowLayoutPanelTop.FlowDirection = FlowDirection.LeftToRight;
      flowLayoutPanelTop.Height = 32;

      button1.Parent = flowLayoutPanelTop;
      button1.FlatStyle = FlatStyle.Popup;
      button1.Width = 24;
      button1.Text = "A";

      button2.Parent = flowLayoutPanelTop;
      button2.FlatStyle = FlatStyle.Popup;
      button2.Width = 24;
      button2.Text = "B";

      button3.Parent = flowLayoutPanelTop;
      button3.FlatStyle = FlatStyle.Popup;
      button3.Width = 24;
      button3.Text = "C";
    }

    private FlowLayoutPanel flowLayoutPanelTop = new FlowLayoutPanel();
    private Button button1 = new Button();
    private Button button2 = new Button();
    private Button button3 = new Button();

    private FlowLayoutPanel flowLayoutPanelCenter = new FlowLayoutPanel();
    private Panel panel1 = new Panel();
    private Panel panel2 = new Panel();
    private Panel panel3 = new Panel();
    private Panel panel4 = new Panel();
  }
}
