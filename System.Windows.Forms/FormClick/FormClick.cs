using System;
using System.Windows.Forms;

namespace Examples {
  class FormClick {
    public static void Main() {
      Application.EnableVisualStyles();

      Form form = new Form();
      form.Text = "Click anywhere on the form";
      form.MouseClick += delegate(object sender, MouseEventArgs e) {
        if (e.Button == MouseButtons.Left)
          MessageBox.Show("The form is clicked", "FormClick", MessageBoxButtons.OK);
      };
      Application.Run(form);
    }
  }
}
