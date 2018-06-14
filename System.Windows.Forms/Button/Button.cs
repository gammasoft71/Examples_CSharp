using System;
using System.Windows.Forms;

namespace ButtonExample {
  class Form1 : Form {
    // The main entry point for the application.
    public static void Main() {
      Application.EnableVisualStyles();
      Application.Run(new Form1());
    }

    public Form1() {
      this.button1.Parent = this;
      this.button1.Text = "button1";
      this.button1.Location = new System.Drawing.Point(50, 50);
      this.button1.Click += delegate (object dender, EventArgs e) {
        this.label1.Text = string.Format("button1 clicked {0} times", ++this.button1Clicked);
      };

      this.button2.Parent = this;
      this.button2.Text = "button2";
      this.button2.Location = new System.Drawing.Point(50, 100);
      this.button2.Size = new System.Drawing.Size(200, 75);
      this.button2.Click += delegate (object sender, EventArgs e) {
        this.label2.Text = string.Format("button2 clicked {0} times", ++this.button2Clicked);
      };

      this.label1.Parent = this;
      this.label1.Text = "button1 clicked 0 times";
      this.label1.Location = new System.Drawing.Point(50, 200);
      this.label1.Width = 200;

      this.label2.Parent = this;
      this.label2.Text = "button2 clicked 0 times";
      this.label2.Location = new System.Drawing.Point(50, 230);
      this.label2.Width = 200;
    }

    private Button button1 = new Button();
    private Button button2 = new Button();
    private Label label1 = new Label();
    private Label label2 = new Label();
    private int button1Clicked = 0;
    private int button2Clicked = 0;
  }
}
