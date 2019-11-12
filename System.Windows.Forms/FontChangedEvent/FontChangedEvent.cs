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
      InitializeComponent();
    }

    private void InitializeComponent() {
      SuspendLayout();
      //
      // radioButton1
      //
      radioButton1.Location = new System.Drawing.Point(0, 0);
      radioButton1.Name = "radioButton1";
      radioButton1.Size = new System.Drawing.Size(150, 17);
      radioButton1.TabStop = true;
      radioButton1.Text = "Button1";
      radioButton1.FontChanged += new System.EventHandler(radioButton1_FontChanged);
      //
      // radioButton2
      //
      radioButton2.Location = new System.Drawing.Point(0, 39);
      radioButton2.Name = "radioButton2";
      radioButton2.Size = new System.Drawing.Size(150, 17);
      radioButton2.TabStop = true;
      radioButton2.Text = "Change Button1 font.";
      radioButton2.CheckedChanged += new System.EventHandler(radioButton2_CheckedChanged);
      //
      // Form1
      //
      ClientSize = new System.Drawing.Size(292, 273);
      Controls.Add(radioButton2);
      Controls.Add(radioButton1);
      Name = "Form1";
      ResumeLayout(false);
      PerformLayout();
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
