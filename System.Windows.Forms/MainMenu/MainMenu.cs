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
      Text = "MainMenu example";
      Menu = new MainMenu(new MenuItem[] {
         new MenuItem("&File", new MenuItem[] {
           new MenuItem("&New", OnMenuItemClick, Shortcut.CtrlN),
           new MenuItem("-"),
           new MenuItem("&Open", OnMenuItemClick, Shortcut.CtrlO),
           new MenuItem("Open &Recent", new MenuItem[] {
             new MenuItem("Path/File1", OnMenuItemClick),
             new MenuItem("Path/File2", OnMenuItemClick),
             new MenuItem("Path/File3", OnMenuItemClick),
             new MenuItem("Path/File4", OnMenuItemClick),
             new MenuItem("Path/File5", OnMenuItemClick)
           }),
           new MenuItem("&Close", OnMenuItemClick, Shortcut.CtrlW),
           new MenuItem("-"),
           new MenuItem("&Save", OnMenuItemClick, Shortcut.CtrlS),
           new MenuItem("Save &As", OnMenuItemClick),
           new MenuItem("-"),
           new MenuItem("&Print", OnMenuItemClick, Shortcut.CtrlP),
           new MenuItem("Print pre&view", OnMenuItemClick),
           new MenuItem("-"),
           new MenuItem("&Exit", OnMenuItemClick, Shortcut.AltF4),
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

      listBox1.Parent = this;
      listBox1.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom;
      listBox1.Bounds = new System.Drawing.Rectangle(10, 10, ClientSize.Width - 20, ClientSize.Height - 20);
    }

    private void OnMenuItemClick(object sender, EventArgs e) {
      listBox1.Items.Add(string.Format("{0}/{1} clicked", ((sender as MenuItem).Parent as MenuItem).Text, (sender as MenuItem).Text));
      listBox1.SelectedIndex = listBox1.Items.Count - 1;
    }

    private ListBox listBox1 = new ListBox();
  }
}
