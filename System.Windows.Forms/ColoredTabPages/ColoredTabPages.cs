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
      this.tabPageRed.Text = "Red";
      this.tabPageRed.BackColor = System.Drawing.Color.Red;

      this.tabPageGreen.Text = "Green";
      this.tabPageGreen.BackColor = System.Drawing.Color.Green;

      this.tabPageBlue.Text = "Blue";
      this.tabPageBlue.BackColor = System.Drawing.Color.Blue;

      this.tabPageYellow.Text = "Yellow";
      this.tabPageYellow.BackColor = System.Drawing.Color.Yellow;

      this.tabControl1.Location = new System.Drawing.Point(10, 10);
      this.tabControl1.Size = new System.Drawing.Size(370, 250);
      this.tabControl1.TabPages.AddRange(new TabPage[] { this.tabPageRed, this.tabPageGreen, this.tabPageBlue, this.tabPageYellow });

      this.ClientSize = new System.Drawing.Size(390, 270);
      this.Text = "Colored TabPages example";
      this.Controls.Add(this.tabControl1);
    }

    private TabControl tabControl1 = new TabControl();
    private TabPage tabPageRed = new TabPage();
    private TabPage tabPageGreen = new TabPage();
    private TabPage tabPageBlue = new TabPage();
    private TabPage tabPageYellow = new TabPage();
  }
}
