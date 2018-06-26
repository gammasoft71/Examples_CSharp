using System;
using System.Windows.Forms;

namespace Examples {
  class Form1 : Form {
    // The main entry point for the application.
    public static void Main() {
      Application.EnableVisualStyles();
      Application.Run(new Form1 {Text = "ProgressBar2 Example" });
    }

    public Form1() {
      this.progressBar1 = new ProgressBar {Parent = this, Location = new System.Drawing.Point(50, 50), Style = ProgressBarStyle.Continuous, Width = 200};
      this.progressBar2 = new ProgressBar {Parent = this, Location = new System.Drawing.Point(50, 80), Style = ProgressBarStyle.Continuous, Width = 200, Value = 50};
      this.progressBar3 = new ProgressBar {Parent = this, Location = new System.Drawing.Point(50, 110), Style = ProgressBarStyle.Continuous, Width = 200, Maximum = 300, Value = 300};
      this.progressBar4 = new ProgressBar {Parent = this, Location = new System.Drawing.Point(50, 140), Style = ProgressBarStyle.Continuous, Width = 200, Maximum = 140};
      this.progressBar5 = new ProgressBar {Parent = this, Location = new System.Drawing.Point(50, 170), Style = ProgressBarStyle.Marquee, Width = 200};
      this.timer = new Timer {Interval = 50, Enabled = true};
      this.timer.Tick += delegate (object sender, EventArgs e) {
        this.progressBar4.Value = this.progressBar4.Value < this.progressBar4.Maximum ? this.progressBar4.Value + 1 : this.progressBar4.Minimum;
      };
    }

    private ProgressBar progressBar1;
    private ProgressBar progressBar2;
    private ProgressBar progressBar3;
    private ProgressBar progressBar4;
    private ProgressBar progressBar5;
    private Timer timer;
  }
}
