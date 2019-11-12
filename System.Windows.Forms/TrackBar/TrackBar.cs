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
      ClientSize = new System.Drawing.Size(300, 300);
      Text = "TrackBar Example";

      trackBar.Parent = this;
      trackBar.Location = new System.Drawing.Point(50, 50);
      trackBar.Maximum = 200;
      trackBar.Orientation = Orientation.Vertical;
      trackBar.Size = new System.Drawing.Size(45, 200);
      trackBar.TickStyle = TickStyle.None;
      trackBar.ValueChanged += delegate(object sender, EventArgs e) {
        progressBar.Value = trackBar.Value;
        label.Text = string.Format("{0}", trackBar.Value);
      };
      trackBar.Value = 100;

      progressBar.Parent = this;
      progressBar.Location = new System.Drawing.Point(100, 50);
      progressBar.Maximum = 200;
      progressBar.Orientation = Orientation.Vertical;
      progressBar.Size = new System.Drawing.Size(23, 200);
      progressBar.Style = ProgressBarStyle.Continuous;

      label.Parent = this;
      label.Location = new System.Drawing.Point(150, 50);
    }

    private TrackBar trackBar = new TrackBar();
    private Gammasoft.ProgressBar progressBar = new Gammasoft.ProgressBar();
    private Label label = new Label();
  }
}
