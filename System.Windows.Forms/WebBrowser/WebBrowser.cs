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
      this.Text = "WebBrowser example";
      this.ClientSize = new System.Drawing.Size(1024, 768);

      this.webBrowser.Parent = this;
      this.webBrowser.Dock = DockStyle.Fill;
      this.webBrowser.Url = new Uri("https://gammasoft71.wixsite.com/gammasoft");
    }

    private WebBrowser webBrowser = new WebBrowser();
  }
}
