using System;
using System.Drawing;
using System.Windows.Forms;

namespace Examples {
  class Form1 : Form {
    public static void Main() {
      Application.EnableVisualStyles();
      Application.Run(new Form1 {Text = "ProgressBar2 Example"});
    }

    public Form1() {
      this.Controls.Add(new ProgressBar {Location = new Point(50, 50), Style = ProgressBarStyle.Continuous, Width = 200});
      this.Controls.Add(new ProgressBar {Location = new Point(50, 80), Style = ProgressBarStyle.Continuous, Width = 200, Value = 50});
      this.Controls.Add(new ProgressBar {Location = new Point(50, 110), Style = ProgressBarStyle.Continuous, Width = 200, Maximum = 300, Value = 300});
      this.Controls.Add(new ProgressBar {Location = new Point(50, 140), Style = ProgressBarStyle.Continuous, Width = 200, Maximum = 140});
      this.Controls.Add(new ProgressBar {Location = new Point(50, 170), Style = ProgressBarStyle.Marquee, Width = 200});
      Timer timer = new Timer {Interval = 50, Enabled = true};
      timer.Tick += (sender, e) => (this.Controls[3] as ProgressBar).Value = (this.Controls[3] as ProgressBar).Value < (this.Controls[3] as ProgressBar).Maximum ? (this.Controls[3] as ProgressBar).Value + 1 : (this.Controls[3] as ProgressBar).Minimum;
    }
  }
}
