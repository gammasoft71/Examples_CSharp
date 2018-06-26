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
      this.Text = "ProgressBar Example";

      this.progressBar1.Parent = this;
      this.progressBar1.Location = new System.Drawing.Point(50, 50);
      this.progressBar1.Style = ProgressBarStyle.Continuous;
      this.progressBar1.Width = 200;

      this.progressBar2.Parent = this;
      this.progressBar2.Location = new System.Drawing.Point(50, 80);
      this.progressBar2.Style = ProgressBarStyle.Continuous;
      this.progressBar2.Width = 200;
      this.progressBar2.Value = 50;

      this.progressBar3.Parent = this;
      this.progressBar3.Location = new System.Drawing.Point(50, 110);
      this.progressBar3.Style = ProgressBarStyle.Continuous;
      this.progressBar3.Width = 200;
      this.progressBar3.Maximum = 300;
      this.progressBar3.Value = 300;

      this.progressBar4.Parent = this;
      this.progressBar4.Location = new System.Drawing.Point(50, 140);
      this.progressBar4.Style = ProgressBarStyle.Continuous;
      this.progressBar4.Width = 200;
      this.progressBar4.Maximum = 140;

      this.progressBar5.Parent = this;
      this.progressBar5.Location = new System.Drawing.Point(50, 170);
      this.progressBar5.Width = 200;
      this.progressBar5.Style = ProgressBarStyle.Marquee;

      this.timer.Interval = 50;
      this.timer.Enabled = true;
      this.timer.Tick += delegate (object sender, EventArgs e) {
        this.progressBar4.Value = this.progressBar4.Value < this.progressBar4.Maximum ? this.progressBar4.Value + 1 : this.progressBar4.Minimum;
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
