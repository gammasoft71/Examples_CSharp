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
      button.Text = "Close";
      button.Location = new System.Drawing.Point(10, 10);
      button.Click += delegate(object sender, EventArgs e) {
        Close();
      };

      Text = "Form example";
      StartPosition = FormStartPosition.Manual;
      Location = new System.Drawing.Point(300, 200);
      Size = new System.Drawing.Size(640, 480);
      Controls.Add(button);
      FormClosing += delegate(object sender, FormClosingEventArgs e) {
        e.Cancel = MessageBox.Show("Are you sure you want exit?", "Close Form", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No;
      };
    }

    private Button button = new Button();
  }
}
