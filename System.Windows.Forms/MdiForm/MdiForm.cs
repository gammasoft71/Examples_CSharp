using System;
using System.Windows.Forms;

namespace Examples {
  class MdiChildForm : Form {
    public MdiChildForm() {
      this.richTextBox.Parent = this;
      this.richTextBox.Dock = DockStyle.Fill;
    }

    private RichTextBox richTextBox = new RichTextBox();
  }

  class MdiParentForm : Form {
    public static void Main() {
      Application.EnableVisualStyles();
      Application.Run(new MdiParentForm());
    }

    public MdiParentForm() {
      this.mainMenu.MenuItems.Add("File");
      this.mainMenu.MenuItems[0].MenuItems.Add(new MenuItem("New", this.OnMenuFileNewClick, Shortcut.CtrlN));
      this.mainMenu.MenuItems[0].MenuItems.Add(new MenuItem("Close", this.OnMenuFileCloseClick, Shortcut.CtrlW));
      this.mainMenu.MenuItems[0].MenuItems.Add(new MenuItem("-"));
      this.mainMenu.MenuItems[0].MenuItems.Add(new MenuItem("Quit", this.OnMenuFileQuitClick, Environment.OSVersion.Platform >= PlatformID.Unix ? Shortcut.CtrlQ : Shortcut.AltF4));

      this.Text = "Mdi example";
      this.IsMdiContainer = true;
      this.Size = new System.Drawing.Size(800, 600);
      this.Menu = this.mainMenu;
    }

    void OnMenuFileNewClick(object sender, EventArgs e) {
      MdiChildForm child = new MdiChildForm();
      child.MdiParent = this;
      child.Text = string.Format("child {0}", ++this.childCounter);
      child.Show();
    }

    void OnMenuFileCloseClick(object sender, EventArgs e) {
      if (this.ActiveMdiChild != null)
        this.ActiveMdiChild.Close();
    }

    void OnMenuFileQuitClick(object sender, EventArgs e) {
      this.Close();
    }

    private MainMenu mainMenu = new MainMenu();
    private int childCounter = 0;
  }
}
