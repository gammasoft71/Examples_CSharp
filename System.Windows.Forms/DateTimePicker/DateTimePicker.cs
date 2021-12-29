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
      dateTimePicker2.Value = new DateTime(1975, 4, 4, 12, 34, 56);
      dateTimePicker2.MinDate = new DateTime(1975, 4, 4, 10, 0, 0);
      dateTimePicker2.MaxDate = new DateTime(1975, 4, 4, 22, 59, 0);
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
