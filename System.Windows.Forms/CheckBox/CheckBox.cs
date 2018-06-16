using System;
using System.Drawing;
using System.Windows.Forms;

namespace Examples {
  class Form1 : Form {
    // The main entry point for the application.
    public static void Main() {
      Application.EnableVisualStyles();
      Application.Run(new Form1());
    }

    public Form1() {
      this.checkBox1.Text = "Checked";
      this.checkBox1.Location = new System.Drawing.Point(30, 30);
      this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
      this.checkBox1.Parent = this;

      this.checkBox2.Text = "Unchecked";
      this.checkBox2.Location = new System.Drawing.Point(30, 60);
      this.checkBox2.CheckState = System.Windows.Forms.CheckState.Unchecked;
      this.checkBox2.Parent = this;

      this.checkBox3.Text = "Indeterminate";
      this.checkBox3.Location = new System.Drawing.Point(30, 90);
      this.checkBox3.CheckState = System.Windows.Forms.CheckState.Indeterminate;
      this.checkBox3.Parent = this;

      this.Text = "CheckBox example";
    }

    private CheckBox checkBox1 = new CheckBox();
    private CheckBox checkBox2 = new CheckBox();
    private CheckBox checkBox3 = new CheckBox();
  };
}
