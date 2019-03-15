using System;
using System.Windows.Forms;

namespace Examples {
  class MainForm : Form {
    public static void Main() {
      Application.EnableVisualStyles();
      Application.Run(new MainForm());
    }

    public MainForm() {
      this.Icon = Examples.Properties.Resources.Gammasoft;
      this.Text = "NotifyIcon example";

      this.label1.Parent = this;
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(10, 10);
      this.label1.Text = "Double click on Gammasoft tray icon\nto show or hide this form.";

      this.notifyIcon1.Icon = Examples.Properties.Resources.Gammasoft;
      this.notifyIcon1.Text = "NotifyIcon example";
      this.notifyIcon1.Visible = true;
      this.notifyIcon1.DoubleClick += delegate {
        this.Visible = !this.Visible;
      };
    }

    private NotifyIcon notifyIcon1 = new NotifyIcon();
    private Label label1 = new Label();
  }
}
