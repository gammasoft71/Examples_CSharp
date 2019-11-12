using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Examples {
  class MainForm : Form {
    public static void Main() {
      Application.EnableVisualStyles();
      Application.Run(new MainForm());
    }

    public MainForm() {
      Text = "TextBox example";

      textBox1.Parent = this;
      textBox1.Text = "textBox1";
      textBox1.Location = new System.Drawing.Point(10, 10);

      textBox2.Parent = this;
      textBox2.Text = "textBox2";
      textBox2.Location = new System.Drawing.Point(10, 50);
      textBox2.GotFocus += delegate {
        Debug.WriteLine(string.Format("Got Focus"));
      };
      textBox2.LostFocus += delegate {
        Debug.WriteLine(string.Format("Lost Focus"));
      };

      ActiveControl = textBox2;
      //textBox2.Select();
      //textBox2.Focus();
    }

    private TextBox textBox1 = new TextBox();
    private TextBox textBox2 = new TextBox();
  }
}
