using System;
using System.Windows.Forms;

namespace Examples {
  class MainForm : Form {
    public static void Main() {
      Application.EnableVisualStyles();
      Application.Run(new MainForm());
    }

    public MainForm() {
      this.Text = "MonthCalendar example";

      this.monthCalendar1.Parent = this;
      this.monthCalendar1.MinDate = new DateTime(1971, 1, 5);
      this.monthCalendar1.MaxDate = new DateTime(2071, 1, 5);
      this.monthCalendar1.SelectionRange = new SelectionRange(DateTime.Now - TimeSpan.FromDays(1), DateTime.Now + TimeSpan.FromDays(1));
      this.monthCalendar1.Location = new System.Drawing.Point(10, 10);

      this.monthCalendar1.DateSelected += delegate {
        MessageBox.Show(string.Format("range = [{0}; {1}]", this.monthCalendar1.SelectionRange.Start.ToShortDateString(), this.monthCalendar1.SelectionRange.End.ToShortDateString()), "Date selected :");
      };
    }

    private MonthCalendar monthCalendar1 = new MonthCalendar();
  }
}
