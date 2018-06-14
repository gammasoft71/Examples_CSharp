using System;
using System.Windows.Forms;

namespace GroupBoxExample {
  class Form1 : Form {
    // The main entry point for the application.
    public static void Main() {
      Application.EnableVisualStyles();
      Application.Run(new Form1());
    }

    public Form1() {
      //this.groupBox1.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom;
      this.groupBox1.Text = "GroupBox 1";
      this.groupBox1.Bounds = new System.Drawing.Rectangle(10, 10, 305, 460);

      //this.groupBox2.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom;
      this.groupBox2.Bounds = new System.Drawing.Rectangle(325, 10, 305, 460);

      this.ClientSize = new System.Drawing.Size(640, 480);
      this.Text = "GroupBox example";
      this.Controls.AddRange(new Control[] { groupBox1, groupBox2 });
    }

    private GroupBox groupBox1 = new GroupBox();
    private GroupBox groupBox2 = new GroupBox();
  }
}
