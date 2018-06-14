using System;
using System.Windows.Forms;

namespace TrackBarExample {
  class Form1 : Form {
    // The main entry point for the application.
    public static void Main() {
      Application.EnableVisualStyles();
      Application.Run(new Form1());
    }

    public Form1() {
      this.Text = "TrackBar Example";

      this.trackBar.Parent = this;
      this.trackBar.Location = new System.Drawing.Point(20, 50);
      this.trackBar.Maximum = 200;
      this.trackBar.Width = 200;
      this.trackBar.TickStyle = TickStyle.None;
      this.trackBar.ValueChanged += delegate(object sender, EventArgs e) {
        this.progressBar.Value = this.trackBar.Value;
        this.label.Text = string.Format("{0}", this.trackBar.Value);
      };
      this.trackBar.Value = 100;

      this.progressBar.Parent = this;
      this.progressBar.Location = new System.Drawing.Point(20, 100);
      this.progressBar.Maximum = 200;
      this.progressBar.Width = 200;

      this.label.Parent = this;
      this.label.Location = new System.Drawing.Point(20, 150);
    }

    private TrackBar trackBar = new TrackBar();
    private ProgressBar progressBar = new ProgressBar();
    private Label label = new Label();
  }
}
