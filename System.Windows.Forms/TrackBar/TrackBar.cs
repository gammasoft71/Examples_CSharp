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
      Text = "TrackBar Example";

      trackBar.Parent = this;
      trackBar.Location = new System.Drawing.Point(20, 50);
      trackBar.Maximum = 200;
      trackBar.Width = 200;
      trackBar.TickStyle = TickStyle.None;
      trackBar.ValueChanged += delegate(object sender, EventArgs e) {
        progressBar.Value = trackBar.Value;
        label.Text = string.Format("{0}", trackBar.Value);
      };
      trackBar.Value = 100;

      progressBar.Parent = this;
      progressBar.Location = new System.Drawing.Point(20, 100);
      progressBar.Maximum = 200;
      progressBar.Style = ProgressBarStyle.Continuous;
      progressBar.Width = 200;

      label.Parent = this;
      label.Location = new System.Drawing.Point(20, 150);
    }

    private TrackBar trackBar = new TrackBar();
    private ProgressBar progressBar = new ProgressBar();
    private Label label = new Label();
  }
}
