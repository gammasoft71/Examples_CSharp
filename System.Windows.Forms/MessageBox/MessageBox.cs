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
      buttonShowMessage.Location = new System.Drawing.Point(10, 10);
      buttonShowMessage.Width = 100;
      buttonShowMessage.Text = "MessageBox";
      buttonShowMessage.Click += delegate(object sender, EventArgs e) {
        DialogResult result = MessageBox.Show("Hello, World!", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
        labelDialogResult.Text = string.Format("DialogResult = {0}", result);
      };

      labelDialogResult.Location = new System.Drawing.Point(10, 45);
      labelDialogResult.Width = 200;

      StartPosition = FormStartPosition.Manual;
      Location = new System.Drawing.Point(400, 200);
      Text = "MessageBox example";
      Controls.AddRange(new Control[] { buttonShowMessage, labelDialogResult});
    }

    private Button buttonShowMessage = new Button();
    private Label labelDialogResult = new Label();
  }
}
