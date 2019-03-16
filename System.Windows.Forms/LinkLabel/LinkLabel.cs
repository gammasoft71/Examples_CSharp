using System;
using System.Windows.Forms;

namespace Examples {
  class MainForm : Form {
    public static void Main() {
      Application.EnableVisualStyles();
      Application.Run(new MainForm());
    }

    public MainForm() {
      this.Text = "LinkLabel example";

      this.label1.Parent = this;
      this.label1.Text = "Gammasoft";
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(10, 10);
      this.label1.Click += delegate(object sender, EventArgs e) {
        System.Diagnostics.Process.Start("https://gammasoft71.wixsite.com/gammasoft");
      };
    }

    private LinkLabel label1 = new LinkLabel();
  }
}
