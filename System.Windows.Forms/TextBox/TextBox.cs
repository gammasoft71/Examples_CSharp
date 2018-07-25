using System;
using System.Windows.Forms;

namespace Examples {
  class MainForm : Form {
    public static void Main() {
      Application.EnableVisualStyles();
      Application.Run(new MainForm());
    }

    public MainForm() {
      this.Text = "TextBox example";

      this.textBox1.Parent = this;
      this.textBox1.Text = "textBox1";
      this.textBox1.Location = new System.Drawing.Point(10, 10);

      this.textBox2.Parent = this;
      this.textBox2.Text = "textBox2";
      this.textBox2.Location = new System.Drawing.Point(10, 50);
    }

    private TextBox textBox1 = new TextBox();
    private TextBox textBox2 = new TextBox();
  }
}
