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
      Menu = new MainMenu(new MenuItem[] {
         new MenuItem("&File", new MenuItem[] {
           new MenuItem("&New", OnMenuItemClick, Shortcut.CtrlN),
           new MenuItem("&Open", OnMenuItemClick, Shortcut.CtrlO),
           new MenuItem("-"),
           new MenuItem("&Save", OnMenuItemClick, Shortcut.CtrlS),
           new MenuItem("Save &As", OnMenuItemClick),
           new MenuItem("-"),
           new MenuItem("&Print", OnMenuItemClick, Shortcut.CtrlS),
           new MenuItem("Print pre&view", OnMenuItemClick),
           new MenuItem("-"),
           new MenuItem("&Exit", (_, EventArgs) => Close(), Shortcut.AltF4),
         }),
         new MenuItem("&Edit", new MenuItem[] {
           new MenuItem("&Undo", OnMenuItemClick, Shortcut.CtrlZ),
           new MenuItem("&Redo", OnMenuItemClick, Shortcut.CtrlShiftZ),
           new MenuItem("-"),
           new MenuItem("Cu&t", OnMenuItemClick, Shortcut.CtrlX),
           new MenuItem("&Copy", OnMenuItemClick, Shortcut.CtrlC),
           new MenuItem("&Paste", OnMenuItemClick, Shortcut.CtrlV),
           new MenuItem("-"),
           new MenuItem("Select &All", OnMenuItemClick, Shortcut.CtrlA),
         }),
         new MenuItem("&Tools", new MenuItem[] {
           new MenuItem("&Customize", OnMenuItemClick),
           new MenuItem("&Options", OnMenuItemClick),
         }),
         new MenuItem("&Help", new MenuItem[] {
           new MenuItem("&Content", OnMenuItemClick),
           new MenuItem("&Index", OnMenuItemClick),
           new MenuItem("&Search", OnMenuItemClick),
           new MenuItem("-"),
           new MenuItem("&About", OnMenuItemClick),
         }),
      });

      //listBox1.Parent = this;
      listBox1.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom;
      listBox1.Bounds = new System.Drawing.Rectangle(10, 10, ClientSize.Width - 20, ClientSize.Height - 20);

      TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();
      tableLayoutPanel.Parent = this;
      tableLayoutPanel.Dock = DockStyle.Fill;
      //tableLayoutPanel.RowCount = 2;
      //tableLayoutPanel.ColumnCount = 2;

      Button button1 = new Button();
      button1.Parent = tableLayoutPanel;
      button1.Dock = DockStyle.Fill;

      Button button2 = new Button();
      button2.Parent = tableLayoutPanel;
      button2.Dock = DockStyle.Fill;
    }

    private void OnMenuItemClick(object sender, EventArgs e) {
      listBox1.Items.Add(string.Format("{0}/{1} clicked", ((sender as MenuItem).Parent as MenuItem).Text, (sender as MenuItem).Text));
      listBox1.SelectedIndex = listBox1.Items.Count - 1;
    }

    private ListBox listBox1 = new ListBox();
    private SplitContainer splitCantainer = new SplitContainer();
  }
}
