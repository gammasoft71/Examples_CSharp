using System;
using System.Windows.Forms;

namespace Examples {
  class MainForm : Form {
    public static void Main() {
      Application.EnableVisualStyles();
      Application.Run(new MainForm());
    }

    public MainForm() {
      Text = "LinkLabel example";

      label1.Parent = this;
      label1.Text = "Gammasoft present CSharp examples";
      label1.AutoSize = true;
      label1.Location = new System.Drawing.Point(10, 10);
      label1.Links.Add(new LinkLabel.Link(0, 9, "https://gammasoft71.wixsite.com/gammasoft"));
      label1.Links.Add(new LinkLabel.Link(18, 6, "https://gammasoft71.wixsite.com/gammasoft/csharp"));
      label1.LinkClicked += delegate(object sender, LinkLabelLinkClickedEventArgs e) {
        e.Link.Visited = true;
        System.Diagnostics.Process.Start(e.Link.LinkData as string);
      };
    }

    private LinkLabel label1 = new LinkLabel();
  }
}
