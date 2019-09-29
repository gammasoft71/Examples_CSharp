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
      Controls.AddRange(new Control[] { radioButton1, radioButton2, radioButton3, radioButton4, radioButton5, label1 });
      Text = "Radio button example";

      radioButton1.AutoCheck = false;
      radioButton1.Checked = true;
      radioButton1.Click += delegate {
        // Uncomments next line to check / uncheck radio button 1 (auto_check is false...)
        //radioButton1.Checked = !radioButton1.Checked;
      };
      radioButton1.Font = new System.Drawing.Font(radioButton1.Font, System.Drawing.FontStyle.Italic);
      radioButton1.Location = new System.Drawing.Point(30, 30);
      radioButton1.Text = "radio 1";

      radioButton2.Location = new System.Drawing.Point(30, 60);
      radioButton2.Text = "radio 2";

      radioButton3.CheckedChanged += delegate (object sender, EventArgs e) {
        label1.Text = string.Format("Radio 3 checked = {0}", radioButton3.Checked);
      };
      radioButton3.Checked = true;
      radioButton3.Location = new System.Drawing.Point(30, 90);
      radioButton3.Text = "radio 3";

      radioButton4.Appearance = Appearance.Button;
      radioButton4.Location = new System.Drawing.Point(30, 120);
      radioButton4.Text = "radio 4";

      radioButton5.AutoCheck = false;
      radioButton5.Appearance = Appearance.Button;
      radioButton5.Checked = true;
      radioButton5.Click += delegate {
        // Uncomments next line to check / uncheck radio button 5 (auto_check is false...)
        //radioButton5.Checked = !radioButton5.Checked;
      };
      radioButton5.Font = new System.Drawing.Font(radioButton1.Font, System.Drawing.FontStyle.Italic);
      radioButton5.Location = new System.Drawing.Point(30, 150);
      radioButton5.Text = "radio 5";
      System.Diagnostics.Debug.WriteLine(string.Format("tb = {0}", radioButton3));

      label1.AutoSize = true;
      label1.Location = new System.Drawing.Point(30, 180);
    }

    private RadioButton radioButton1 = new RadioButton();
    private RadioButton radioButton2 = new RadioButton();
    private RadioButton radioButton3 = new RadioButton();
    private RadioButton radioButton4 = new RadioButton();
    private RadioButton radioButton5 = new RadioButton();
    private Label label1 = new Label();
  }
}
