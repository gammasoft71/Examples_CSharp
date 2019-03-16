using System;
using System.Windows.Forms;

namespace Examples {
  class MainForm : Form {
    public static void Main() {
      Application.EnableVisualStyles();
      Application.Run(new MainForm());
    }

    public MainForm() {
      this.Text = "FlowLayoutPanel example";

      this.flowLayoutPanelCenter.Parent = this;
      this.flowLayoutPanelCenter.Dock = DockStyle.Fill;
      this.flowLayoutPanelCenter.FlowDirection = FlowDirection.TopDown;
      this.flowLayoutPanelCenter.AutoScroll = true;

      this.panel1.Parent = this.flowLayoutPanelCenter;
      this.panel1.BackColor = System.Drawing.Color.Red;

      this.panel2.Parent = this.flowLayoutPanelCenter;
      this.panel2.BackColor = System.Drawing.Color.Green;

      this.panel3.Parent = this.flowLayoutPanelCenter;
      this.panel3.BackColor = System.Drawing.Color.Blue;

      this.panel4.Parent = this.flowLayoutPanelCenter;
      this.panel4.BackColor = System.Drawing.Color.Yellow;

      this.flowLayoutPanelTop.Parent = this;
      this.flowLayoutPanelTop.Dock = DockStyle.Top;
      this.flowLayoutPanelTop.FlowDirection = FlowDirection.LeftToRight;
      this.flowLayoutPanelTop.Height = 32;

      this.button1.Parent = this.flowLayoutPanelTop;
      this.button1.FlatStyle = FlatStyle.Popup;
      this.button1.Width = 24;
      this.button1.Text = "A";

      this.button2.Parent = this.flowLayoutPanelTop;
      this.button2.FlatStyle = FlatStyle.Popup;
      this.button2.Width = 24;
      this.button2.Text = "B";

      this.button3.Parent = this.flowLayoutPanelTop;
      this.button3.FlatStyle = FlatStyle.Popup;
      this.button3.Width = 24;
      this.button3.Text = "C";
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
