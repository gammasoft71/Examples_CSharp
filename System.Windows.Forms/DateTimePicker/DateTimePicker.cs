using System;
using System.Windows.Forms;

namespace Examples {
  class MainForm : Form {
    public static void Main() {
      Application.EnableVisualStyles();
      Application.Run(new MainForm());
    }

    public MainForm() {
      this.Text = "DateTimePicker example";

      this.dateTimePicker1.Parent = this;
      this.dateTimePicker1.Value = new DateTime(1975, 4, 4);
      this.dateTimePicker1.MinDate = new DateTime(1975, 4, 4);
      this.dateTimePicker1.MaxDate = DateTime.Now;
      this.dateTimePicker1.Location = new System.Drawing.Point(30, 30);

      this.label1.Parent = this;
      this.label1.Location = new System.Drawing.Point(30, 60);
      this.label1.Text = this.dateTimePicker1.Value.ToShortDateString();

      this.dateTimePicker1.ValueChanged += delegate (object sender, EventArgs e) {
        this.label1.Text = this.dateTimePicker1.Value.ToShortDateString();
      };
    }

    private DateTimePicker dateTimePicker1 = new DateTimePicker();
    private Label label1 = new Label();
  }
}
