using System;
using System.Windows.Forms;

namespace Examples {
  class MainForm : Form {
    public static void Main() {
      Application.EnableVisualStyles();
      Application.Run(new MainForm());
    }

    public MainForm() {
      Text = "DateTimePicker example";

      dateTimePicker1.Parent = this;
      dateTimePicker1.Value = new DateTime(1975, 4, 4);
      dateTimePicker1.MinDate = new DateTime(1975, 4, 4);
      dateTimePicker1.MaxDate = DateTime.Now;
      dateTimePicker1.Location = new System.Drawing.Point(30, 30);

      label1.Parent = this;
      label1.Location = new System.Drawing.Point(30, 60);
      label1.Text = dateTimePicker1.Value.ToShortDateString();

      dateTimePicker1.ValueChanged += delegate (object sender, EventArgs e) {
        label1.Text = dateTimePicker1.Value.ToShortDateString();
      };
    }

    private DateTimePicker dateTimePicker1 = new DateTimePicker();
    private Label label1 = new Label();
  }
}
