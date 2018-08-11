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
      this.comboBox1.Location = new System.Drawing.Point(10, 10);
      this.comboBox1.Items.AddRange(new string[] {"item1", "item2", "item3"});
      this.comboBox1.SelectedIndex = 1;
      this.comboBox1.Parent = this;

      this.Text = "ComboBox example";
    }

    private ComboBox comboBox1 = new ComboBox();
  };
}
