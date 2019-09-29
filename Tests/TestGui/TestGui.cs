using System;
using System.Windows.Forms;

namespace Examples {
  class Program {
    public static void Main() {
      Application.EnableVisualStyles();

      Form form1 = new Form();
      form1.Text = "form1";
      form1.ClientSize = new System.Drawing.Size(200, 240);

      CheckBox checkBox1 = new CheckBox();
      checkBox1.Parent = form1;
      checkBox1.Location = new System.Drawing.Point(10, 10);
      checkBox1.Text = "CheckBox 1";
      checkBox1.CheckAlign = System.Drawing.ContentAlignment.TopRight;
      checkBox1.TextAlign = System.Drawing.ContentAlignment.BottomRight;

      Application.Run(form1);
    }
  }
}