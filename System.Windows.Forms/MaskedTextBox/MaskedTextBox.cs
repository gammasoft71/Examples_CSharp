using System;
using System.Windows.Forms;

namespace Examples {
  class MainForm : Form {
    public static void Main() {
      Application.EnableVisualStyles();
      Application.Run(new MainForm());
    }

    public MainForm() {
      this.Text = "MaskedTextBox example";

      this.labelAge.Location = new System.Drawing.Point(10, 12);
      this.labelAge.Text = "Phone";
      this.labelAge.AutoSize = true;

      this.maskedTextBoxAge.Location = new System.Drawing.Point(50, 10);
      this.maskedTextBoxAge.Mask = "+999(999)99999999";
      this.maskedTextBoxAge.Text = "";

      this.Controls.AddRange(new Control[] { this.labelAge, this.maskedTextBoxAge });
    }


    private Label labelAge = new Label();
    private MaskedTextBox maskedTextBoxAge = new MaskedTextBox();
  }
}
