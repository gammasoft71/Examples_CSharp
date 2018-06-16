using System;
using System.Windows.Forms;

namespace Examples {
  class MainForm : Form {
    public static void Main() {
      Application.EnableVisualStyles();
      Application.Run(new MainForm());
    }

    public MainForm() {
      this.Text = "Label example";

      this.label1.Parent = this;
      this.label1.Text = "label1";
      this.label1.Location = new System.Drawing.Point(10, 10);
    }

    private Label label1 = new Label();
  }
}
