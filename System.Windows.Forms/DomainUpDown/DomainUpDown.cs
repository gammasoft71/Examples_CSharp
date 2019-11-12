using System;
using System.Windows.Forms;

namespace Examples {
  class MainForm : Form {
    public static void Main() {
      Application.EnableVisualStyles();
      Application.Run(new MainForm());
    }

    public MainForm() {
      Text = "DomainUpDown example";

      domainUpDown1.Parent = this;
      domainUpDown1.Items.AddRange(new string[] { "item1", "item2", "item3", "item4", "item5", "item6", "item7", "item8", "item9", "item10" });
      domainUpDown1.Location = new System.Drawing.Point(10, 10);
      domainUpDown1.TextChanged += delegate (object sender, EventArgs e) {
        label1.Text = domainUpDown1.SelectedItem.ToString();
      };
      domainUpDown1.SelectedIndex = 1;

      label1.Parent = this;
      label1.Location = new System.Drawing.Point(10, 40);
    }

    private DomainUpDown domainUpDown1 = new DomainUpDown();
    private Label label1 = new Label();
  }
}
