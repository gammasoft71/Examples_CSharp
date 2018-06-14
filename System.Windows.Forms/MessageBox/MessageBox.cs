using System;
using System.Windows.Forms;

namespace MessageBoxExample {
  class Form1 : Form {
    // The main entry point for the application.
    public static void Main() {
      Application.EnableVisualStyles();
      Application.Run(new Form1());
    }

    public Form1() {
      this.buttonShowMessage.Location = new System.Drawing.Point(10, 10);
      this.buttonShowMessage.Width = 100;
      this.buttonShowMessage.Text = "MessageBox";
      this.buttonShowMessage.Click += delegate(object sender, EventArgs e) {
        DialogResult result = MessageBox.Show("Hello, World!", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
        labelDialogResult.Text = string.Format("DialogResult = {0}", result);
      };

      this.labelDialogResult.Location = new System.Drawing.Point(10, 45);
      this.labelDialogResult.Width = 200;

      this.StartPosition = FormStartPosition.Manual;
      this.Location = new System.Drawing.Point(400, 200);
      this.Text = "MessageBox example";
      this.Controls.AddRange(new Control[] { this.buttonShowMessage, this.labelDialogResult});
    }

    private Button buttonShowMessage = new Button();
    private Label labelDialogResult = new Label();
  }
}
