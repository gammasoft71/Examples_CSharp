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
      this.label1.Text = "Gammasoft present CSharp examples";
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(10, 10);
      this.label1.Links.Add(new LinkLabel.Link(0, 9, "https://gammasoft71.wixsite.com/gammasoft"));
      this.label1.Links.Add(new LinkLabel.Link(18, 6, "https://gammasoft71.wixsite.com/gammasoft/csharp"));
      this.label1.LinkClicked += delegate(object sender, LinkLabelLinkClickedEventArgs e) {
        e.Link.Visited = true;
        System.Diagnostics.Process.Start(e.Link.LinkData as string);
      };
    }

    private LinkLabel label1 = new LinkLabel();
  }
}
