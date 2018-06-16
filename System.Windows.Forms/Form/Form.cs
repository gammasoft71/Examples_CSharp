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
      this.button.Text = "Close";
      this.button.Location = new System.Drawing.Point(10, 10);
      this.button.Click += delegate(object sender, EventArgs e) {
        this.Close();
      };

      this.Text = "Form example";
      this.StartPosition = FormStartPosition.Manual;
      this.Location = new System.Drawing.Point(300, 200);
      this.Size = new System.Drawing.Size(640, 480);
      this.Controls.Add(this.button);
      this.FormClosing += delegate(object sender, FormClosingEventArgs e) {
        e.Cancel = MessageBox.Show("Are you sure you want exit?", "Close Form", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No;
      };
    }

    private Button button = new Button();
  }
}
