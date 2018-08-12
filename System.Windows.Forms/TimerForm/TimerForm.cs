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
      this.Text = "Timer Example";
      this.StartPosition = FormStartPosition.Manual;
      this.Location = new System.Drawing.Point(400, 300);
      this.ClientSize = new System.Drawing.Size(230, 130);

      this.label.Parent = this;
      this.label.Text = string.Format("{0:N1}", (double)(this.counter) / 10);
      this.label.Location = new System.Drawing.Point(10, 10);
      this.label.Size = new System.Drawing.Size(210, 70);
      //this.label.AutoSize = true;
      this.label.Font = new System.Drawing.Font("Arial", 48, System.Drawing.FontStyle.Italic);
      this.label.ForeColor = System.Drawing.Color.DodgerBlue;

      this.timer.Interval = 100;
      this.timer.Tick += delegate(object sender, EventArgs e) {
        this.label.Text = string.Format("{0:N1}", (double)(++this.counter) / 10);
      };

      this.button.Parent = this;
      this.button.Text = "Start";
      this.button.Location = new System.Drawing.Point(10, 90);

      this.button.Click += delegate(object sender, EventArgs e) {
        this.timer.Enabled = !this.timer.Enabled;
        this.button.Text = this.timer.Enabled ? "Stop" : "Start";
      };
    }

    private Label label = new Label();
    private Button button = new Button();
    private Timer timer = new Timer();
    private int counter = 0;
  }
}
