using System;
using System.Windows.Forms;

namespace GroupBoxAndRadioButtonExample {
  class Form1 : Form {
    // The main entry point for the application.
    public static void Main() {
      Application.EnableVisualStyles();
      Application.Run(new Form1());
    }

    public Form1() {
      this.StartPosition = FormStartPosition.Manual;
      this.Location = new System.Drawing.Point(400, 200);
      this.ClientSize = new System.Drawing.Size(300, 160);
      this.Text = "GroupBox and RadioButton example";

      this.groupBox1.Parent = this;
      this.groupBox1.Text = "Group 1";
      this.groupBox1.Bounds = new System.Drawing.Rectangle(10, 10, 135, 140);

      this.radio1.Parent = this.groupBox1;
      this.radio1.Location = new System.Drawing.Point(10, 30);
      this.radio1.Text = "radio button 1";
      this.radio1.Checked = true;

      this.radio2.Parent = this.groupBox1;
      this.radio2.Location = new System.Drawing.Point(10, 60);
      this.radio2.Text = "radio button 2";

      this.radio3.Parent = this.groupBox1;
      this.radio3.Location = new System.Drawing.Point(10, 90);
      this.radio3.Text = "radio button 3";

      this.groupBox2.Parent = this;
      this.groupBox2.Text = "Group 2";
      this.groupBox2.Bounds = new System.Drawing.Rectangle(155, 10, 130, 140);

      this.radio4.Parent = this.groupBox2;
      this.radio4.Location = new System.Drawing.Point(10, 30);
      this.radio4.Text = "radio button 4";

      this.radio5.Parent = this.groupBox2;
      this.radio5.Location = new System.Drawing.Point(10, 60);
      this.radio5.Text = "radio button 5";
      this.radio5.Checked = true;

      this.radio6.Parent = this.groupBox2;
      this.radio6.Location = new System.Drawing.Point(10, 90);
      this.radio6.Text = "radio button 6";
    }

    private GroupBox groupBox1 = new GroupBox();
    private GroupBox groupBox2 = new GroupBox();
    private RadioButton radio1 = new RadioButton();
    private RadioButton radio2 = new RadioButton();
    private RadioButton radio3 = new RadioButton();
    private RadioButton radio4 = new RadioButton();
    private RadioButton radio5 = new RadioButton();
    private RadioButton radio6 = new RadioButton();
  }
}


