using System;
using System.Windows.Forms;

namespace Examples {
  class Form1 : Form {
    // The main entry point for the application.
    public static void Main() {
      Application.EnableVisualStyles();
      Application.Run(new Form1());
    }

    public Form1() {
      this.tabPage3.Text = "tabPage3";

      this.tabControl1.Location = new System.Drawing.Point(10, 10);
      this.tabControl1.Size = new System.Drawing.Size(370, 250);
      this.tabControl1.TabPages.Add("tabPage1");
      this.tabControl1.TabPages.Add("tabPageé", "tabPage2");
      this.tabControl1.TabPages.Add(this.tabPage3);

      this.ClientSize = new System.Drawing.Size(390, 270);
      this.Text = "TabControl example";
      this.Controls.Add(this.tabControl1);
    }

    private TabControl tabControl1 = new TabControl();
    private TabPage tabPage3 = new TabPage();
  }
}
