using System;
using System.Drawing;
using System.Windows.Forms;

namespace Examples {
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
      this.menuSrtrip.Items.Add("View");

      (this.menuSrtrip.Items[0] as ToolStripMenuItem).DropDown.Items.Add(new ToolStripMenuItem("New", null, this.OnMenuClick, Keys.N| Keys.Control));
      (this.menuSrtrip.Items[0] as ToolStripMenuItem).DropDown.Items.Add(new ToolStripMenuItem("Open", null, this.OnMenuClick, Keys.O | Keys.Control));
      (this.menuSrtrip.Items[0] as ToolStripMenuItem).DropDown.Items.Add(new ToolStripMenuItem("Open recent...", null, this.OnMenuClick));
      (this.menuSrtrip.Items[0] as ToolStripMenuItem).DropDown.Items.Add(new ToolStripMenuItem("Close", null, this.OnMenuClick, Keys.W | Keys.Control));
      (this.menuSrtrip.Items[0] as ToolStripMenuItem).DropDown.Items.Add("-");
      (this.menuSrtrip.Items[0] as ToolStripMenuItem).DropDown.Items.Add(new ToolStripMenuItem("Save", null, this.OnMenuClick, Keys.S | Keys.Control));
      (this.menuSrtrip.Items[0] as ToolStripMenuItem).DropDown.Items.Add(new ToolStripMenuItem("Save as...", null, this.OnMenuClick));
      (this.menuSrtrip.Items[0] as ToolStripMenuItem).DropDown.Items.Add("-");
      (this.menuSrtrip.Items[0] as ToolStripMenuItem).DropDown.Items.Add(new ToolStripMenuItem("Quit", null, this.OnMenuClick, Environment.OSVersion.Platform >= PlatformID.Unix ? Keys.Q | Keys.Control : Keys.F4 | Keys.Alt));

      (this.menuSrtrip.Items[1] as ToolStripMenuItem).DropDown.Items.Add(new ToolStripMenuItem("Undo", null, this.OnMenuClick, Keys.Z | Keys.Control));
      (this.menuSrtrip.Items[1] as ToolStripMenuItem).DropDown.Items.Add(new ToolStripMenuItem("Redo", null, this.OnMenuClick, Keys.Y | Keys.Control));
      (this.menuSrtrip.Items[1] as ToolStripMenuItem).DropDown.Items.Add("-");
      (this.menuSrtrip.Items[1] as ToolStripMenuItem).DropDown.Items.Add(new ToolStripMenuItem("Cut", null, this.OnMenuClick, Keys.X | Keys.Control));
      (this.menuSrtrip.Items[1] as ToolStripMenuItem).DropDown.Items.Add(new ToolStripMenuItem("Copy", null, this.OnMenuClick, Keys.C | Keys.Control));
      (this.menuSrtrip.Items[1] as ToolStripMenuItem).DropDown.Items.Add(new ToolStripMenuItem("Paste", null, this.OnMenuClick, Keys.V | Keys.Control));
      (this.menuSrtrip.Items[1] as ToolStripMenuItem).DropDown.Items.Add("-");
      (this.menuSrtrip.Items[1] as ToolStripMenuItem).DropDown.Items.Add(new ToolStripMenuItem("Select all", null, this.OnMenuClick, Keys.A | Keys.Control));

      (this.menuSrtrip.Items[2] as ToolStripMenuItem).DropDown.Items.Add(new ToolStripMenuItem("Show", null, this.OnMenuClick));
      (this.menuSrtrip.Items[2] as ToolStripMenuItem).DropDown.Items.Add(new ToolStripMenuItem("Hide", null, this.OnMenuClick));

      this.listBox1.Parent = this;
      this.listBox1.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom;
      this.listBox1.Bounds = new System.Drawing.Rectangle(10, this.menuSrtrip.Height + 10, this.ClientSize.Width - 20, this.ClientSize.Height - this.menuSrtrip.Height + - 20);

      this.MainMenuStrip = this.menuSrtrip;
      this.Text = "MenuStrip example";
    }

    void OnMenuClick(object sender, EventArgs e) {
      this.listBox1.Items.Add(string.Format("{0}/{1} clicked", (sender as ToolStripMenuItem).OwnerItem.Text, (sender as ToolStripMenuItem).Text));
      this.listBox1.SelectedIndex = this.listBox1.Items.Count - 1;
    }

    MenuStrip menuSrtrip = new MenuStrip();
    ListBox listBox1 = new ListBox();
  }
}
