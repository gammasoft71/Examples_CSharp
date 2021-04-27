using System;
using System.Drawing;
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
        colorDialog.CustomColors = customColors;
        if (colorDialog.ShowDialog() == DialogResult.OK)
          BackColor = colorDialog.Color;
        customColors = colorDialog.CustomColors;
      };

      Text = "ColorDialog example";
      Controls.Add(button);
    }

    private Button button = new Button();
    private int[] customColors = new int[] { ColorTranslator.ToOle(Color.Red), ColorTranslator.ToOle(Color.Green), ColorTranslator.ToOle(Color.Blue), ColorTranslator.ToOle(Color.Yellow) };
}
}
