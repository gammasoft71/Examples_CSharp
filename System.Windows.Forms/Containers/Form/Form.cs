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
      buttonClose.Text = "Close";
      buttonClose.Location = new System.Drawing.Point(10, 10);
      buttonClose.Click += delegate (object sender, EventArgs e) {
        Close();
      };

      buttonExit.Text = "Exit";
      buttonExit.Location = new System.Drawing.Point(100, 10);
      buttonExit.Click += delegate (object sender, EventArgs e) {
        Application.Exit();
      };

      buttonExitThread.Text = "Exit Thread";
      buttonExitThread.Location = new System.Drawing.Point(190, 10);
      buttonExitThread.Click += delegate (object sender, EventArgs e) {
        Application.ExitThread();
      };

      Text = "Form example";
      StartPosition = FormStartPosition.Manual;
      Location = new System.Drawing.Point(300, 200);
      Size = new System.Drawing.Size(640, 480);
      Controls.AddRange(new Control[] {buttonClose, buttonExit, buttonExitThread});
      FormClosing += delegate(object sender, FormClosingEventArgs e) {
        e.Cancel = MessageBox.Show("Are you sure you want exit?", "Close Form", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No;
      };
    }

    private Button buttonClose = new Button();
    private Button buttonExit = new Button();
    private Button buttonExitThread = new Button();
  }
}
