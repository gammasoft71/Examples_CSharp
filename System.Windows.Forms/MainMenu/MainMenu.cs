using System;
using System.Windows.Forms;

namespace Examples {
  public class Form1 : Form {
    // The main entry point for the application.
    public static void Main() {
      Application.EnableVisualStyles();
      Application.Run(new Form1());
    }

    public Form1() {
      this.mainMenu.MenuItems.Add("File");
      this.mainMenu.MenuItems.Add("Edit");
      this.mainMenu.MenuItems.Add("View");

      this.mainMenu.MenuItems[0].MenuItems.Add(new MenuItem("New", this.OnMenuClick, Shortcut.CtrlN));
      this.mainMenu.MenuItems[0].MenuItems.Add(new MenuItem("Open...", this.OnMenuClick, Shortcut.CtrlO));
      this.mainMenu.MenuItems[0].MenuItems.Add(new MenuItem("Open recent", this.OnMenuClick));
      this.mainMenu.MenuItems[0].MenuItems.Add(new MenuItem("Close", this.OnMenuClick, Shortcut.CtrlW));
      this.mainMenu.MenuItems[0].MenuItems.Add(new MenuItem("-"));
      this.mainMenu.MenuItems[0].MenuItems.Add(new MenuItem("Save", this.OnMenuClick, Shortcut.CtrlS));
      this.mainMenu.MenuItems[0].MenuItems.Add(new MenuItem("Save as...", this.OnMenuClick));
      this.mainMenu.MenuItems[0].MenuItems.Add(new MenuItem("-"));
      this.mainMenu.MenuItems[0].MenuItems.Add(new MenuItem("Quit", this.OnMenuClick, Environment.OSVersion.Platform >= PlatformID.Unix ? Shortcut.CtrlQ : Shortcut.AltF4));

      this.mainMenu.MenuItems[1].MenuItems.Add(new MenuItem("Undo", this.OnMenuClick, Shortcut.CtrlZ));
      this.mainMenu.MenuItems[1].MenuItems.Add(new MenuItem("Redo", this.OnMenuClick, Shortcut.CtrlY));
      this.mainMenu.MenuItems[1].MenuItems.Add("-");
      this.mainMenu.MenuItems[1].MenuItems.Add(new MenuItem("Cut", this.OnMenuClick, Shortcut.CtrlX));
      this.mainMenu.MenuItems[1].MenuItems.Add(new MenuItem("Copy", this.OnMenuClick, Shortcut.CtrlC));
      this.mainMenu.MenuItems[1].MenuItems.Add(new MenuItem("Paste", this.OnMenuClick, Shortcut.CtrlV));
      this.mainMenu.MenuItems[1].MenuItems.Add("-");
      this.mainMenu.MenuItems[1].MenuItems.Add(new MenuItem("Select All", this.OnMenuClick, Shortcut.CtrlA));

      this.mainMenu.MenuItems[2].MenuItems.Add(new MenuItem("Show", this.OnMenuClick));
      this.mainMenu.MenuItems[2].MenuItems.Add(new MenuItem("Hide", this.OnMenuClick));

      this.listBox1.Parent = this;
      this.listBox1.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom;
      this.listBox1.Bounds = new System.Drawing.Rectangle(10, 10, this.ClientSize.Width - 20, this.ClientSize.Height - 20);

      this.Menu = this.mainMenu;
      this.Text = "MainMenu example";
    }

    void OnMenuClick(object sender, EventArgs e) {
      this.listBox1.Items.Add(string.Format("{0}/{1} clicked", ((sender as MenuItem).Parent as MenuItem).Text, (sender as MenuItem).Text));
      this.listBox1.SelectedIndex = this.listBox1.Items.Count - 1;
    }

    private MainMenu mainMenu = new MainMenu();
    private ListBox listBox1 = new ListBox();
  }
}
