using System;
using System.Windows.Forms;

namespace Examples {
  class Form1 : Form {
    public static void Main() {
      Application.EnableVisualStyles();
      Application.Run(new Form1());
    }

    public Form1() {
      button1.Parent = this;
      button1.Text = "button1";
      button1.Location = new System.Drawing.Point(50, 50);
       button1.Click += delegate (object dender, EventArgs e) {
        label1.Text = string.Format("button1 clicked {0} times", ++button1Clicked);
      };

      button2.Parent = this;
      button2.Text = "button2";
      button2.Location = new System.Drawing.Point(50, 100);
      button2.Size = new System.Drawing.Size(200, 75);
      button2.Click += delegate (object sender, EventArgs e) {
        label2.Text = string.Format("button2 clicked {0} times", ++button2Clicked);
      };

      label1.Parent = this;
      label1.Text = "button1 clicked 0 times";
      label1.Location = new System.Drawing.Point(50, 200);
      label1.Width = 200;

      label2.Parent = this;
      label2.Text = "button2 clicked 0 times";
      label2.Location = new System.Drawing.Point(50, 230);
      label2.Width = 200;
    }

    private Button button1 = new Button();
    private Button button2 = new Button();
    private Label label1 = new Label();
    private Label label2 = new Label();
    private int button1Clicked = 0;
    private int button2Clicked = 0;
  }
}
