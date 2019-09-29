using System;
using System.Windows.Forms;

namespace Examples {
  class MainForm : Form {
    public static void Main() {
      Application.EnableVisualStyles();
      Application.Run(new MainForm());
    }

    public MainForm() {
      Text = "MonthCalendar example";

      monthCalendar1.Parent = this;
      monthCalendar1.MinDate = new DateTime(1971, 1, 5);
      monthCalendar1.MaxDate = new DateTime(2071, 1, 5);
      monthCalendar1.SelectionRange = new SelectionRange(DateTime.Now - TimeSpan.FromDays(1), DateTime.Now + TimeSpan.FromDays(1));
      monthCalendar1.Location = new System.Drawing.Point(10, 10);

      monthCalendar1.DateSelected += delegate {
        MessageBox.Show(string.Format("range = [{0}; {1}]", monthCalendar1.SelectionRange.Start.ToShortDateString(), monthCalendar1.SelectionRange.End.ToShortDateString()), "Date selected :");
      };
    }

    private MonthCalendar monthCalendar1 = new MonthCalendar();
  }
}
