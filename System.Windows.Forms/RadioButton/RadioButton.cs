using System;
using System.Windows.Forms;

namespace Examples {
  class Form1 : Form {
    // The main entry point for the application.
    public static void Main() {
      Application.EnableVisualStyles();
      Application.Run(new Form1());
    }

    public Form1() {
      this.radioButton1.Text = "radioButton 1";
      this.radioButton1.Location = new System.Drawing.Point(30, 30);
      this.radioButton1.Checked = true;

      this.radioButton2.Text = "radioButton 2";
      this.radioButton2.Location = new System.Drawing.Point(30, 60);

      this.radioButton3.Text = "radioButton 3";
      this.radioButton3.Location = new System.Drawing.Point(30, 90);

      this.Text = "RadioButton example";
      this.Controls.AddRange(new Control[] { this.radioButton1, this.radioButton2, this.radioButton3 });
    }

    private RadioButton radioButton1 = new RadioButton();
    private RadioButton radioButton2 = new RadioButton();
    private RadioButton radioButton3 = new RadioButton();
  }
}
