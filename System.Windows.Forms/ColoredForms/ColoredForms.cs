using System;
using System.Drawing;
using System.Windows.Forms;

namespace Examples {
  class MainClass {
    public static void Main(string[] args) {
      Application.EnableVisualStyles();

      System.Collections.Generic.List<Form> forms = new System.Collections.Generic.List<Form>();
      KnownColor formColor = KnownColor.AliceBlue;

      Button button = new Button();
      button.Text = "Create";
      button.Location = new System.Drawing.Point(10, 10);
      button.Click += delegate (object sender, EventArgs e) {
        Form form = new Form();
        form.BackColor = Color.FromKnownColor(formColor);
        form.Text = string.Format("{0}", formColor);
        form.Visible = true;
        forms.Add(form);
        formColor = formColor != KnownColor.YellowGreen ? (KnownColor)((int)formColor + 1) : KnownColor.AliceBlue;
      };

      Form mainForm = new Form();
      mainForm.Text = "Main Form";
      mainForm.StartPosition = FormStartPosition.Manual;
      mainForm.Location = new System.Drawing.Point(Screen.AllScreens[0].WorkingArea.Width - mainForm.Width - 20, 43);
      mainForm.Controls.Add(button);
      Application.Run(mainForm);
    }
  }
}
