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
      comboBox1.Location = new System.Drawing.Point(10, 10);
      comboBox1.Items.AddRange(new string[] { "item1", "item2", "item3", "item4", "item5", "item6", "item7", "item8", "item9", "item10" });
      comboBox1.SelectedIndex = 0;
      comboBox1.Parent = this;

      comboBox2.Location = new System.Drawing.Point(10, 50);
      comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
      comboBox2.Items.AddRange(new string[] { "item1", "item2", "item3", "item4", "item5", "item6", "item7", "item8", "item9", "item10" });
      comboBox2.SelectedIndex = 1;
      comboBox2.Parent = this;

      comboBox3.Location = new System.Drawing.Point(10, 90);
      comboBox3.DropDownStyle = ComboBoxStyle.Simple;
      comboBox3.Items.AddRange(new string[] { "item1", "item2", "item3", "item4", "item5", "item6", "item7", "item8", "item9", "item10" });
      comboBox3.SelectedIndex = 2;
      comboBox3.Parent = this;

      Text = "ComboBox example";
    }

    private ComboBox comboBox1 = new ComboBox();
    private ComboBox comboBox2 = new ComboBox();
    private ComboBox comboBox3 = new ComboBox();
  };
}
