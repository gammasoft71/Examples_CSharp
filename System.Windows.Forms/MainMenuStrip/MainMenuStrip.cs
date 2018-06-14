using System;
using System.Drawing;
using System.Windows.Forms;

namespace MouseEvent {
  public class Form1 : Form {
    // The main entry point for the application.
    public static void Main() {
      Application.EnableVisualStyles();
      Application.Run(new Form1());
    }

    public Form1() {
      this.menuSrtrip.Parent = this;
      this.menuSrtrip.Items.Add("File");
      this.menuSrtrip.Items.Add("Edit");
      ((ToolStripMenuItem)this.menuSrtrip.Items[0]).DropDown.Items.Add("New");
      ((ToolStripMenuItem)this.menuSrtrip.Items[0]).DropDown.Items.Add("Open");
      ((ToolStripMenuItem)this.menuSrtrip.Items[0]).DropDown.Items.Add("Close");
      ((ToolStripMenuItem)this.menuSrtrip.Items[0]).DropDown.Items.Add("-");
      ((ToolStripMenuItem)this.menuSrtrip.Items[0]).DropDown.Items.Add("Quit");
      ((ToolStripMenuItem)this.menuSrtrip.Items[1]).DropDown.Items.Add("Cut");
      ((ToolStripMenuItem)this.menuSrtrip.Items[1]).DropDown.Items.Add("Copy");
      ((ToolStripMenuItem)this.menuSrtrip.Items[1]).DropDown.Items.Add("Paste");
      ((ToolStripMenuItem)this.menuSrtrip.Items[1]).DropDown.Items.Add("-");
      ((ToolStripMenuItem)this.menuSrtrip.Items[1]).DropDown.Items.Add("Select all");
      this.MainMenuStrip = this.menuSrtrip;

      ((ToolStripMenuItem)this.MainMenuStrip.Items[0]).DropDown.Items[4].Click += delegate {
        this.Close();
      };
    }

    MenuStrip menuSrtrip = new MenuStrip();
  }
}
