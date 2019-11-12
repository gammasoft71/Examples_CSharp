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
      button.Text = "Color...";
      button.Location = new System.Drawing.Point(10, 10);
      button.Click += delegate (object sender, EventArgs e) {
        ColorDialog colorDialog = new ColorDialog();
        colorDialog.Color = BackColor;
        if (colorDialog.ShowDialog() == DialogResult.OK)
          BackColor = colorDialog.Color;
      };

      Text = "ColorDialog example";
      Controls.Add(button);
    }

    private Button button = new Button();
  }
}
