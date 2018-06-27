namespace Examples {
  class Form1 : System.Windows.Forms.Form {
    public static void Main() {
      System.Windows.Forms.Application.EnableVisualStyles();
      System.Windows.Forms.Application.Run(new Form1());
    }

    public Form1() {
      this.Controls.Add(new System.Windows.Forms.Button { Text = "button1", Location = new System.Drawing.Point(50, 50) });
      this.Controls.Add(new System.Windows.Forms.Button { Text = "button2", Location = new System.Drawing.Point(50, 100), Size = new System.Drawing.Size(200, 75) });
      this.Controls.Add(new System.Windows.Forms.Label { Text = "button1 clicked 0 times", Location = new System.Drawing.Point(50, 200), Size = new System.Drawing.Size(200, 20) });
      this.Controls.Add(new System.Windows.Forms.Label { Text = "button2 clicked 0 times", Location = new System.Drawing.Point(50, 230), Size = new System.Drawing.Size(200, 20) });
      this.Controls[0].Click += (sender, e) => this.Controls[2].Text = string.Format("button1 clicked {0} times", ++this.button1Clicked);
      this.Controls[1].Click += (sender, e) => this.Controls[3].Text = string.Format("button2 clicked {0} times", ++this.button2Clicked);
    }

    private int button1Clicked = 0, button2Clicked = 0;
  }
}
