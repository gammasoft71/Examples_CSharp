using System;
using System.Drawing;
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
      ClientSize = new Size(820, 500);
      Controls.AddRange(new Control[] {listBox1, toolBar1});

      listBox1.Dock = DockStyle.Fill;

      newToolBarbutton.Text = "&New";
      newToolBarbutton.ImageIndex = 0;

      openToolBarbutton.Text = "&Open";
      openToolBarbutton.ImageIndex = 1;

      saveToolBarbutton.Text = "&Save";
      saveToolBarbutton.ImageIndex = 2;
      saveToolBarbutton.Style = ToolBarButtonStyle.ToggleButton;
      
      separatorToolBarbutton1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;

      dropDownMenu1.MenuItems.AddRange(new MenuItem[] {
        new MenuItem("&Content", OnMenuItemClick),
        new MenuItem("&Index", OnMenuItemClick),
        new MenuItem("&Search", OnMenuItemClick),
        new MenuItem("-"),
        new MenuItem("&About", OnMenuItemClick),
      });

      helpToolBarbutton.Text = "&Help";
      helpToolBarbutton.ImageIndex = 3;
      helpToolBarbutton.DropDownMenu = dropDownMenu1;
      helpToolBarbutton.Style = ToolBarButtonStyle.DropDownButton;

      toolBar1.ImageList = new ImageList {ColorDepth = ColorDepth.Depth32Bit};
      toolBar1.ImageList.Images.AddRange(new Image[] { ToolBarResource.New, ToolBarResource.Open, ToolBarResource.Save, ToolBarResource.About });
      toolBar1.Buttons.AddRange(new ToolBarButton[] { newToolBarbutton, openToolBarbutton, saveToolBarbutton, separatorToolBarbutton1, helpToolBarbutton });
      toolBar1.ButtonClick += OnToolBarButtonClick;
      toolBar1.TextAlign = ToolBarTextAlign.Right;
    }

    private void OnToolBarButtonClick(object sender, ToolBarButtonClickEventArgs e) {
      if (e.Button.Style == ToolBarButtonStyle.ToggleButton)
        listBox1.Items.Add(string.Format("Button {0} clicked, pushed = {1}", e.Button.Text, e.Button.Pushed));
      else
        listBox1.Items.Add(string.Format("Button {0} clicked", e.Button.Text));
      listBox1.SelectedIndex = listBox1.Items.Count - 1;
    }

    private void OnMenuItemClick(object sender, EventArgs e) {
      listBox1.Items.Add(string.Format("{0} clicked", (sender as MenuItem).Text));
      listBox1.SelectedIndex = listBox1.Items.Count - 1;
    }

    private ListBox listBox1 = new ListBox();

    private ToolBar toolBar1 = new ToolBar();
    private ToolBarButton newToolBarbutton = new ToolBarButton();
    private ToolBarButton openToolBarbutton = new ToolBarButton();
    private ToolBarButton saveToolBarbutton = new ToolBarButton();
    private ToolBarButton separatorToolBarbutton1 = new ToolBarButton();
    private ToolBarButton helpToolBarbutton = new ToolBarButton();
    private ContextMenu dropDownMenu1 = new ContextMenu();
  }
}
