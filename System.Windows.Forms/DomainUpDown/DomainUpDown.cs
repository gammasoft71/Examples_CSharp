using System;
using System.Windows.Forms;

namespace Examples {
  class MainForm : Form {
    public static void Main() {
      Application.EnableVisualStyles();
      Application.Run(new MainForm());
    }

    public MainForm() {
      this.Text = "DomainUpDown example";

      this.domainUpDown1.Parent = this;
      this.domainUpDown1.Items.AddRange(new string[] { "item1", "item2", "item3", "item4" });
      this.domainUpDown1.SelectedIndex = 1;
      this.domainUpDown1.Location = new System.Drawing.Point(10, 10);

      this.label1.Parent = this;
      this.label1.Text = this.domainUpDown1.Text;
      this.label1.Location = new System.Drawing.Point(10, 40);

      this.domainUpDown1.TextChanged += delegate (object sender, EventArgs e) {
        this.label1.Text = this.domainUpDown1.Text;
      };
    }

    private DomainUpDown domainUpDown1 = new DomainUpDown();
    private Label label1 = new Label();
  }
}
