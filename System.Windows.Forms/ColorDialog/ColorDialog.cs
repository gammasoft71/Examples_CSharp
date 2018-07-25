using System;
using System.Windows.Forms;

namespace FolderBrowserDialogExample {
  class Form1 : Form {
    // The main entry point for the application.
    public static void Main() {
      Application.EnableVisualStyles();
      Application.Run(new Form1());
    }

    public Form1() {
      this.button.Text = "Color...";
      this.button.Location = new System.Drawing.Point(10, 10);
      this.button.Click += delegate (object sender, EventArgs e) {
        ColorDialog colorDialog = new ColorDialog();
        colorDialog.Color = this.BackColor;
        if (colorDialog.ShowDialog() == DialogResult.OK)
          this.BackColor = colorDialog.Color;
      };

      this.Text = "ColorDialog example";
      this.Controls.Add(this.button);
    }

    private Button button = new Button();
  }
}
