using System;
using System.Windows.Forms;

namespace Examples {
  class MainClass {
    public static void Main() {
      Form form = new Form();
      form.BackColor = Examples.Properties.Settings.Default.BackColor;
      form.Height = Examples.Properties.Settings.Default.Height;
      form.Left = Examples.Properties.Settings.Default.Left;
      form.StartPosition = FormStartPosition.Manual;
      form.Text = Examples.Properties.Settings.Default.Text;
      form.Top = Examples.Properties.Settings.Default.Top;
      form.Width = Examples.Properties.Settings.Default.Width;

      Button buttonColor = new Button();
      buttonColor.Text = "Color...";
      buttonColor.Location = new System.Drawing.Point(10, 10);
      buttonColor.Parent = form;
      buttonColor.Click += delegate (object sender, EventArgs e) {
        ColorDialog colorDialog = new ColorDialog();
        colorDialog.Color = form.BackColor;
        if (colorDialog.ShowDialog() == DialogResult.OK)
          form.BackColor = colorDialog.Color;
      };

      Button buttonSave = new Button();
      buttonSave.Text = "Save";
      buttonSave.Location = new System.Drawing.Point(90, 10);
      buttonSave.Parent = form;
      buttonSave.Click += delegate (object sender, EventArgs e) {
        Examples.Properties.Settings.Default.BackColor = form.BackColor;
        Examples.Properties.Settings.Default.Height = form.Height;
        Examples.Properties.Settings.Default.Left = form.Left;
        Examples.Properties.Settings.Default.Top = form.Top;
        Examples.Properties.Settings.Default.Width = form.Width;
        Examples.Properties.Settings.Default.Save();
      };

      Button buttonReload = new Button();
      buttonReload.Text = "Reload";
      buttonReload.Location = new System.Drawing.Point(170, 10);
      buttonReload.Parent = form;
      buttonReload.Click += delegate (object sender, EventArgs e) {
        Examples.Properties.Settings.Default.Reload();
        form.BackColor = Examples.Properties.Settings.Default.BackColor;
        form.Height = Examples.Properties.Settings.Default.Height;
        form.Left = Examples.Properties.Settings.Default.Left;
        form.Top = Examples.Properties.Settings.Default.Top;
        form.Width = Examples.Properties.Settings.Default.Width;
      };

      Button buttonReset = new Button();
      buttonReset.Text = "Reset";
      buttonReset.Location = new System.Drawing.Point(250, 10);
      buttonReset.Parent = form;
      buttonReset.Click += delegate (object sender, EventArgs e) {
        Examples.Properties.Settings.Default.Reset();
        form.BackColor = Examples.Properties.Settings.Default.BackColor;
        form.Height = Examples.Properties.Settings.Default.Height;
        form.Left = Examples.Properties.Settings.Default.Left;
        form.Top = Examples.Properties.Settings.Default.Top;
        form.Width = Examples.Properties.Settings.Default.Width;
      };
      Application.Run(form);
    }
  }
}
