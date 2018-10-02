using System;
using System.Windows.Forms;

namespace Examples {
  class MainClass {
    public static void Main() {
      Form form = new Form();
      form.BackColor = Examples.Properties.Settings.Default.BackColor;
      form.Height = Examples.Properties.Settings.Default.Height;
      form.Text = Examples.Properties.Settings.Default.Text;
      form.Width = Examples.Properties.Settings.Default.Width;

      Button button = new Button();
      button.Text = "Color...";
      button.Location = new System.Drawing.Point(10, 10);
      button.Parent = form;
      button.Click += delegate (object sender, EventArgs e) {
        ColorDialog colorDialog = new ColorDialog();
        colorDialog.Color = form.BackColor;
        if (colorDialog.ShowDialog() == DialogResult.OK) {
          form.BackColor = colorDialog.Color;
          Examples.Properties.Settings.Default.BackColor = colorDialog.Color;
          Examples.Properties.Settings.Default.Save();
        }
      };
      Application.Run(form);
    }
  }
}
