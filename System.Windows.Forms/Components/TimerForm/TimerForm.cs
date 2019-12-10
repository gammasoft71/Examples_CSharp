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
      Text = "Timer Example";
      StartPosition = FormStartPosition.Manual;
      Location = new System.Drawing.Point(400, 300);
      ClientSize = new System.Drawing.Size(230, 130);

      label.Parent = this;
      label.Text = string.Format("{0:N1}", (double)(counter) / 10);
      label.Location = new System.Drawing.Point(10, 10);
      label.Size = new System.Drawing.Size(210, 70);
      //label.AutoSize = true;
      label.Font = new System.Drawing.Font("Arial", 48, System.Drawing.FontStyle.Italic);
      label.ForeColor = System.Drawing.Color.DodgerBlue;

      timer.Interval = 100;
      timer.Tick += delegate(object sender, EventArgs e) {
        label.Text = string.Format("{0:N1}", (double)(++counter) / 10);
      };

      button.Parent = this;
      button.Text = "Start";
      button.Location = new System.Drawing.Point(10, 90);

      button.Click += delegate(object sender, EventArgs e) {
        timer.Enabled = !timer.Enabled;
        button.Text = timer.Enabled ? "Stop" : "Start";
      };
    }

    private Label label = new Label();
    private Button button = new Button();
    private Timer timer = new Timer();
    private int counter = 0;
  }
}
