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
      tabPage3.Text = "tabPage3";

      tabControl1.Location = new System.Drawing.Point(10, 10);
      tabControl1.Size = new System.Drawing.Size(370, 250);

      tabControl1.TabPages.Add("tabPage1");
      tabControl1.TabPages.Add("tabPageé", "tabPage2");
      tabControl1.TabPages.Add(tabPage3);

      tabControl1.TabPages[0].UseVisualStyleBackColor = true;
      tabControl1.TabPages[1].BackColor = System.Drawing.SystemColors.Window;

      ClientSize = new System.Drawing.Size(390, 270);
      Text = "TabControl example";
      Controls.Add(tabControl1);
    }

    private TabControl tabControl1 = new TabControl();
    private TabPage tabPage3 = new TabPage();
  }
}
