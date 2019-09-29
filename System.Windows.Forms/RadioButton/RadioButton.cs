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
      this.Controls.AddRange(new Control[] { this.radioButton1, this.radioButton2, this.radioButton3, this.radioButton4, this.radioButton5, this.label1 });
      this.Text = "Radio button example";

      this.radioButton1.AutoCheck = false;
      this.radioButton1.Checked = true;
      this.radioButton1.Click += delegate {
        // Uncomments next line to check / uncheck radio button 1 (auto_check is false...)
        //this.radioButton1.Checked = !this.radioButton1.Checked;
      };
      this.radioButton1.Font = new System.Drawing.Font(this.radioButton1.Font, System.Drawing.FontStyle.Italic);
      this.radioButton1.Location = new System.Drawing.Point(30, 30);
      this.radioButton1.Text = "radio 1";

      this.radioButton2.Location = new System.Drawing.Point(30, 60);
      this.radioButton2.Text = "radio 2";

      this.radioButton3.CheckedChanged += delegate (object sender, EventArgs e) {
        this.label1.Text = string.Format("Radio 3 checked = {0}", this.radioButton3.Checked);
      };
      this.radioButton3.Checked = true;
      this.radioButton3.Location = new System.Drawing.Point(30, 90);
      this.radioButton3.Text = "radio 3";

      this.radioButton4.Appearance = Appearance.Button;
      this.radioButton4.Location = new System.Drawing.Point(30, 120);
      this.radioButton4.Text = "radio 4";

      this.radioButton5.AutoCheck = false;
      this.radioButton5.Appearance = Appearance.Button;
      this.radioButton5.Checked = true;
      this.radioButton5.Click += delegate {
        // Uncomments next line to check / uncheck radio button 5 (auto_check is false...)
        //this.radioButton5.Checked = !this.radioButton5.Checked;
      };
      this.radioButton5.Font = new System.Drawing.Font(this.radioButton1.Font, System.Drawing.FontStyle.Italic);
      this.radioButton5.Location = new System.Drawing.Point(30, 150);
      this.radioButton5.Text = "radio 5";
      System.Diagnostics.Debug.WriteLine(string.Format("tb = {0}", this.radioButton3));

      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(30, 180);
    }

    private RadioButton radioButton1 = new RadioButton();
    private RadioButton radioButton2 = new RadioButton();
    private RadioButton radioButton3 = new RadioButton();
    private RadioButton radioButton4 = new RadioButton();
    private RadioButton radioButton5 = new RadioButton();
    private Label label1 = new Label();
  }
}
