using System;
using System.Windows.Forms;

namespace Examples {
  class MainForm : Form {
    public static void Main() {
      Application.EnableVisualStyles();
      Application.Run(new MainForm());
    }

    public MainForm() {
      this.Text = "NumericUpDown example";

      this.numericUpDown1.Parent = this;
      this.numericUpDown1.DecimalPlaces = 0;
      this.numericUpDown1.Location = new System.Drawing.Point(80, 50);
      this.numericUpDown1.Value = 50;

      this.numericUpDown2.Parent = this;
      this.numericUpDown2.DecimalPlaces = 2;
      this.numericUpDown2.Increment = 0.01M;
      this.numericUpDown2.Location = new System.Drawing.Point(80, 100);
      this.numericUpDown2.Maximum = 11.0M;
      this.numericUpDown2.Minimum = 10.0M;
    }

    private NumericUpDown numericUpDown1 = new NumericUpDown();
    private NumericUpDown numericUpDown2 = new NumericUpDown();
  }
}
