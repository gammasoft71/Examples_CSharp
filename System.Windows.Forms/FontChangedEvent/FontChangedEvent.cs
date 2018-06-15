using System;
using System.Windows.Forms;

namespace FolderBrowserDialogExample {
  class Form1 : Form {
    // The main entry point for the application.
    public static void Main() {
      Application.EnableVisualStyles();
      Application.Run(new Form1());
    }

    public Form1() {
      this.InitializeComponent();
    }

    private void InitializeComponent() {
      this.SuspendLayout();
      //
      // radioButton1
      //
      this.radioButton1.Location = new System.Drawing.Point(0, 0);
      this.radioButton1.Name = "radioButton1";
      this.radioButton1.Size = new System.Drawing.Size(150, 17);
      this.radioButton1.TabStop = true;
      this.radioButton1.Text = "Button1";
      this.radioButton1.FontChanged += new System.EventHandler(this.radioButton1_FontChanged);
      //
      // radioButton2
      //
      this.radioButton2.Location = new System.Drawing.Point(0, 39);
      this.radioButton2.Name = "radioButton2";
      this.radioButton2.Size = new System.Drawing.Size(150, 17);
      this.radioButton2.TabStop = true;
      this.radioButton2.Text = "Change Button1 font.";
      this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
      //
      // Form1
      //
      this.ClientSize = new System.Drawing.Size(292, 273);
      this.Controls.Add(this.radioButton2);
      this.Controls.Add(this.radioButton1);
      this.Name = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    private void radioButton2_CheckedChanged(object sender, EventArgs e) {
      radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.0f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
    }

    private void radioButton1_FontChanged(object sender, EventArgs e) {
      MessageBox.Show("The font has been changed.");
    }

    private RadioButton radioButton1 = new RadioButton();
    private RadioButton radioButton2 = new RadioButton();
  }
}
