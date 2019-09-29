using System;
using System.Windows.Forms;

namespace Examples {
  class MainForm : Form {
    public static void Main() {
      Application.EnableVisualStyles();
      Application.Run(new MainForm());
    }

    public MainForm() {
      Icon = Examples.Properties.Resources.Gammasoft;
      Text = "NotifyIcon example";

      label1.Parent = this;
      label1.AutoSize = true;
      label1.Location = new System.Drawing.Point(10, 10);
      label1.Text = "Double click on Gammasoft tray icon\nto show or hide this form.";

      notifyIcon1.Icon = Examples.Properties.Resources.Gammasoft;
      notifyIcon1.Text = "NotifyIcon example";
      notifyIcon1.Visible = true;
      notifyIcon1.DoubleClick += delegate {
        Visible = !Visible;
      };
    }

    private NotifyIcon notifyIcon1 = new NotifyIcon();
    private Label label1 = new Label();
  }
}
