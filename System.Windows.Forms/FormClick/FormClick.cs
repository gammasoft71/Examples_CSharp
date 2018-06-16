using System;
using System.Drawing;
using System.Windows.Forms;

namespace Examples {
  class FormClick {
    // The main entry point for the application.
    public static void Main() {
      Application.EnableVisualStyles();

      Color[] colors = new Color[] { Color.Pink, Color.LightBlue, Color.LightGreen, Color.LightYellow };
      int colorIndex = 0;

      Form form = new Form();
      form.BackColor = colors[colorIndex];
      form.Click += delegate(object sender, EventArgs e) {
        if (++colorIndex == colors.Length) colorIndex = 0;
        form.BackColor = colors[colorIndex];
      };
      Application.Run(form);
    }
  }
}
