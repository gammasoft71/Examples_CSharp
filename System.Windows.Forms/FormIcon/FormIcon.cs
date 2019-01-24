using System;
using System.Windows.Forms;

namespace Examples {
  class MainForm : Form {
    public static void Main() {
      Application.EnableVisualStyles();
      Application.Run(new MainForm());
    }

    public MainForm() {
      this.Text = "Form Icon example";
      this.Icon = Examples.Properties.Resources.Gammasoft;
    }

    private Label label1 = new Label();
  }
}
