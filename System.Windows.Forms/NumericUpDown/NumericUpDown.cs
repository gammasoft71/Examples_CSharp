using System;
using System.Windows.Forms;

namespace Examples {
  class MainForm : Form {
    public static void Main() {
      Application.EnableVisualStyles();
      Application.Run(new MainForm());
    }

    public MainForm() {
      Text = "NumericUpDown example";

      numericUpDown1.Parent = this;
      numericUpDown1.DecimalPlaces = 0;
      numericUpDown1.Location = new System.Drawing.Point(80, 50);
      numericUpDown1.Value = 50;

      numericUpDown2.Parent = this;
      numericUpDown2.DecimalPlaces = 2;
      numericUpDown2.Increment = 0.01M;
      numericUpDown2.Location = new System.Drawing.Point(80, 100);
      numericUpDown2.Maximum = 11.0M;
      numericUpDown2.Minimum = 10.0M;
    }

    private NumericUpDown numericUpDown1 = new NumericUpDown();
    private NumericUpDown numericUpDown2 = new NumericUpDown();
  }
}
