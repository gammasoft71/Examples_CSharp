using System;
using System.Media;
using System.Windows.Forms;

namespace Examples {
  class Form1 : Form {
    // The main entry point for the application.
    public static void Main() {
      Application.EnableVisualStyles();
      Application.Run(new Form1());
    }

    public Form1() {
      this.buttonAsterisk.Bounds = new System.Drawing.Rectangle(60, 50, 180, 40);
      this.buttonAsterisk.Text = "Asterisk";
      this.buttonAsterisk.Click += delegate(object sender, EventArgs e) {
        SystemSounds.Asterisk.Play();
      };

      this.buttonBeep.Bounds = new System.Drawing.Rectangle(60, 90, 180, 40);
      this.buttonBeep.Text = "Beep";
      this.buttonBeep.Click += delegate(object sender, EventArgs e) {
        SystemSounds.Beep.Play();
      };

      this.buttonExclamation.Bounds = new System.Drawing.Rectangle(60, 130, 180, 40);
      this.buttonExclamation.Text = "Exclamation";
      this.buttonExclamation.Click += delegate(object sender, EventArgs e) {
        SystemSounds.Exclamation.Play();
      };

      this.buttonHand.Bounds = new System.Drawing.Rectangle(60, 170, 180, 40);
      this.buttonHand.Text = "Hand";
      this.buttonHand.Click += delegate(object sender, EventArgs e) {
        SystemSounds.Hand.Play();
      };

      this.buttonQuestion.Bounds = new System.Drawing.Rectangle(60, 210, 180, 40);
      this.buttonQuestion.Text = "Question";
      this.buttonQuestion.Click += delegate(object sender, EventArgs e) {
        SystemSounds.Question.Play();
      };

      this.StartPosition = FormStartPosition.Manual;
      this.Location = new System.Drawing.Point(400, 200);
      this.ClientSize = new System.Drawing.Size(300, 300);
      this.Text = "SystemSounds example";
      this.Controls.AddRange(new Control[] { this.buttonAsterisk, this.buttonBeep, this.buttonExclamation, this.buttonHand, this.buttonQuestion});
    }

    private Button buttonAsterisk = new Button();
    private Button buttonBeep = new Button();
    private Button buttonExclamation = new Button();
    private Button buttonHand = new Button();
    private Button buttonQuestion = new Button();
  }
}
