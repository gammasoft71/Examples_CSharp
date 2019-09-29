using System;
using System.Windows.Forms;

namespace Examples {
  class MainForm : Form {
    [STAThread]
    public static void Main() {
      Application.EnableVisualStyles();
      Application.Run(new MainForm());
    }

    public MainForm() {
      Text = "WebBrowser example";
      ClientSize = new System.Drawing.Size(1024, 768);

      webBrowser.Parent = this;
      webBrowser.Dock = DockStyle.Fill;
      webBrowser.Url = new Uri("https://gammasoft71.wixsite.com/gammasoft");
    }

    private WebBrowser webBrowser = new WebBrowser();
  }
}
