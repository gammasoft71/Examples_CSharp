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
      dateTimePicker1.Value = DateTime.Now;
      dateTimePicker1.MinDate = dateTimePicker1.Value.AddMonths(-3);
      dateTimePicker1.MaxDate = dateTimePicker1.Value.AddMonths(3);
      dateTimePicker1.Format = DateTimePickerFormat.Short;
      dateTimePicker1.ShowUpDown = true;
      dateTimePicker1.Location = new System.Drawing.Point(30, 30);
      System.Diagnostics.Debug.WriteLine(string.Format("default size = {0}", dateTimePicker1.Size));

      label1.Parent = this;
      label1.Location = new System.Drawing.Point(30, 60);
      label1.Text = dateTimePicker1.Value.ToShortDateString();

      dateTimePicker1.ValueChanged += delegate (object sender, EventArgs e) {
        label1.Text = dateTimePicker1.Value.ToShortDateString();
      };

      dateTimePicker2.Parent = this;
      dateTimePicker2.Value = DateTime.Now;
      dateTimePicker2.MinDate = dateTimePicker2.Value.AddHours(-3);
      dateTimePicker2.MaxDate = dateTimePicker2.Value.AddHours(3);
      dateTimePicker2.Format = DateTimePickerFormat.Time;
      dateTimePicker2.ShowUpDown = true;
      dateTimePicker2.Location = new System.Drawing.Point(30, 90);

      label2.Parent = this;
      label2.Location = new System.Drawing.Point(30, 60);
      label2.Text = dateTimePicker2.Value.ToShortDateString();

      dateTimePicker2.ValueChanged += delegate (object sender, EventArgs e) {
        label2.Text = dateTimePicker2.Value.ToShortDateString();
      };
    }

    private DateTimePicker dateTimePicker1 = new DateTimePicker();
    private Label label1 = new Label();
    private DateTimePicker dateTimePicker2 = new DateTimePicker();
    private Label label2 = new Label();
  }
}
