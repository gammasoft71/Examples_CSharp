using System;
using System.Windows.Forms;

namespace Examples {
  class Form1 : Form {
    // The main entry point for the application.
    public static void Main() {
      Application.EnableVisualStyles();
      Application.Run(new Form1());
    }

    public Form1() {
      Text = "ProgressBar Example";

      progressBar1.Parent = this;
      progressBar1.Location = new System.Drawing.Point(50, 50);
      progressBar1.Style = ProgressBarStyle.Continuous;
      progressBar1.Width = 200;

      progressBar2.Parent = this;
      progressBar2.Location = new System.Drawing.Point(50, 80);
      progressBar2.Style = ProgressBarStyle.Continuous;
      progressBar2.Value = 50;
      progressBar2.Width = 200;

      progressBar3.Parent = this;
      progressBar3.Location = new System.Drawing.Point(50, 110);
      progressBar3.Maximum = 300;
      progressBar3.Style = ProgressBarStyle.Continuous;
      progressBar3.Value = 300;
      progressBar3.Width = 200;

      progressBar4.Parent = this;
      progressBar4.Location = new System.Drawing.Point(50, 140);
      progressBar4.Style = ProgressBarStyle.Continuous;
      progressBar4.Maximum = 140;
      progressBar4.Style = ProgressBarStyle.Continuous;
      progressBar4.Width = 200;

      progressBar5.Parent = this;
      progressBar5.Location = new System.Drawing.Point(50, 170);
      progressBar5.Style = ProgressBarStyle.Marquee;
      progressBar5.Width = 200;

      timer.Interval = 50;
      timer.Enabled = true;
      timer.Tick += delegate (object sender, EventArgs e) {
        progressBar4.Value = progressBar4.Value < progressBar4.Maximum ? progressBar4.Value + 1 : progressBar4.Minimum;
      };
    }

    private ProgressBar progressBar1 = new ProgressBar();
    private ProgressBar progressBar2 = new ProgressBar();
    private ProgressBar progressBar3 = new ProgressBar();
    private ProgressBar progressBar4 = new ProgressBar();
    private ProgressBar progressBar5 = new ProgressBar();
    private Timer timer = new Timer();
  }
}
