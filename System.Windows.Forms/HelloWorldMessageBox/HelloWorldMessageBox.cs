using System;
using System.Drawing;
using System.Windows.Forms;

namespace Examples {
  class MainClass {
    public static void Main() {
      Application.EnableVisualStyles();

      Button button = new Button();
      button.Text = "Click me";
      button.Location = new Point(10, 10);
      button.Click += delegate(object sender, EventArgs e) {
        MessageBox.Show("Hello, World!");
      };

      Form form = new Form();
      form.Text = "Hello World Form";
      form.Controls.Add(button);

      Application.Run(form);
    }
  }
}
