using System;
using System.Windows.Forms;

namespace Examples {
  class Form1 : Form {
    public static void Main() {
      Application.EnableVisualStyles();
      Application.Run(new Form1());
    }

    public Form1() {
      Text = "CheckBox example";
      Controls.AddRange(new Control[] {checkBox1, checkBox2, checkBox3, checkBox4, checkBox5});

      checkBox1.AutoCheck = false;
      checkBox1.Click += delegate {
        //checkBox1.Checked = !checkBox1.Checked;
        //checkBox1.Text = string.Format("{0}", checkBox1.CheckState);
      };
      checkBox1.Location = new System.Drawing.Point(30, 30);
      checkBox1.Text = string.Format("{0}", checkBox1.CheckState);

      checkBox2.CheckedChanged += delegate (object sender, EventArgs e) {
        checkBox2.Text = string.Format("{0}", checkBox2.CheckState);
      };
      checkBox2.Checked = true;
      checkBox2.Location = new System.Drawing.Point(30, 60);
      checkBox2.Checked = true;

      checkBox3.CheckStateChanged += delegate (object sender, EventArgs e) {
        checkBox3.Text = string.Format("{0}", checkBox3.CheckState);
      };
      checkBox3.CheckState = CheckState.Indeterminate;
      checkBox3.Location = new System.Drawing.Point(30, 90);
      checkBox3.Text = string.Format("{0}", checkBox3.CheckState);
      checkBox3.ThreeState = true;

      checkBox4.AutoCheck = false;
      checkBox4.Appearance = Appearance.Button;
      checkBox4.Click += delegate {
        //checkBox4.Checked = !checkBox4.Checked;
        //checkBox4.Text = string.Format("{0}", checkBox4.CheckState);
      };
      checkBox4.Location = new System.Drawing.Point(30, 120);
      checkBox4.Text = string.Format("{0}", checkBox4.CheckState);

      checkBox5.Appearance = Appearance.Button;
      checkBox5.CheckStateChanged += delegate (object sender, EventArgs e) {
        checkBox5.Text = string.Format("{0}", checkBox5.CheckState);
      };
      checkBox5.Checked = true;
      checkBox5.Location = new System.Drawing.Point(30, 150);
    }

    private CheckBox checkBox1 = new CheckBox();
    private CheckBox checkBox2 = new CheckBox();
    private CheckBox checkBox3 = new CheckBox();
    private CheckBox checkBox4 = new CheckBox();
    private CheckBox checkBox5 = new CheckBox();
  };
}
