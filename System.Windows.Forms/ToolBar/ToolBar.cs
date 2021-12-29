using System;
using System.Windows.Forms;

namespace Examples {
  class MainForm : Form {
    [STAThread]
    public static void Main() {
      Application.EnableVisualStyles();
      Application.Run(new MainForm());
    }

    public MainForm() {
      Text = "ToolBar example";

      listBox1.Parent = this;
      listBox1.Dock = DockStyle.Fill;

      newToolBarbutton.Text = "&New";
      newToolBarbutton.ImageIndex = 0;

      openToolBarbutton.Text = "&Open";
      openToolBarbutton.ImageIndex = 1;

      saveToolBarbutton.Text = "&Save";
      saveToolBarbutton.ImageIndex = 2;

      separatorToolBarbutton1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;

      aboutToolBarbutton.Text = "&About";
      aboutToolBarbutton.ImageIndex = 3;

      toolBar1.Parent = this;
      toolBar1.Buttons.AddRange(new ToolBarButton[] {newToolBarbutton, openToolBarbutton, saveToolBarbutton, separatorToolBarbutton1, aboutToolBarbutton});
      toolBar1.ButtonClick += ToolBar1_ButtonClick;

    }

    private void ToolBar1_ButtonClick(object sender, ToolBarButtonClickEventArgs e) {
      listBox1.Items.Add(string.Format("Item {0} clicked", e.Button.Text));
      listBox1.SelectedIndex = listBox1.Items.Count - 1;
    }

    private ToolBar toolBar1 = new ToolBar();
    private ListBox listBox1 = new ListBox();
    private ToolBarButton newToolBarbutton= new ToolBarButton();
    private ToolBarButton openToolBarbutton = new ToolBarButton();
    private ToolBarButton saveToolBarbutton = new ToolBarButton();
    private ToolBarButton separatorToolBarbutton1 = new ToolBarButton();
    private ToolBarButton aboutToolBarbutton = new ToolBarButton();
  }
}
