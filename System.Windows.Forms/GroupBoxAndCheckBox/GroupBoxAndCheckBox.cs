using System;
using System.Windows.Forms;

namespace GroupBoxAndCheckBoxExample {
  class Form1 : Form {
    // The main entry point for the application.
    public static void Main() {
      Application.EnableVisualStyles();
      Application.Run(new Form1());
    }

    Form1() {
      this.StartPosition = FormStartPosition.Manual;
      this.Location = new System.Drawing.Point(400, 200);
      this.ClientSize = new System.Drawing.Size(300, 160);
      this.Text = "GroupBox and CheckBox example";

      this.group1.Parent = this;
      this.group1.Text = "Group 1";
      this.group1.Bounds = new System.Drawing.Rectangle(10, 10, 135, 140);

      this.check1.Parent = this.group1;
      this.check1.Location = new System.Drawing.Point(10, 30);
      this.check1.Text = "check 1";

      this.check2.Parent = this.group1;
      this.check2.Location = new System.Drawing.Point(10, 60);
      this.check2.Text = "check 2";
      this.check2.Checked = true;

      this.check3.Parent = this.group1;
      this.check3.Location = new System.Drawing.Point(10, 90);
      this.check3.Text = "check 3";

      this.group2.Parent = this;
      this.group2.Text = "Group 2";
      this.group2.Bounds = new System.Drawing.Rectangle(155, 10, 135, 140);

      this.check4.Parent = this.group2;
      this.check4.Location = new System.Drawing.Point(10, 30);
      this.check4.Text = "check 4";

      this.check5.Parent = this.group2;
      this.check5.Location = new System.Drawing.Point(10, 60);
      this.check5.Text = "check 5";

      this.check6.Parent = this.group2;
      this.check6.Location = new System.Drawing.Point(10, 90);
      this.check6.Text = "check 6";
      this.check6.Checked = true;
    }

    private GroupBox group1 = new GroupBox();
    private GroupBox group2 = new GroupBox();
    private CheckBox check1 = new CheckBox();
    private CheckBox check2 = new CheckBox();
    private CheckBox check3 = new CheckBox();
    private CheckBox check4 = new CheckBox();
    private CheckBox check5 = new CheckBox();
    private CheckBox check6 = new CheckBox();
  }
}
