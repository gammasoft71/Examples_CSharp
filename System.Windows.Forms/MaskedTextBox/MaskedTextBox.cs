using System;
using System.Windows.Forms;

namespace Examples {
  class MainForm : Form {
    public static void Main() {
      Application.EnableVisualStyles();
      Application.Run(new MainForm());
    }

    public MainForm() {
      Text = "MaskedTextBox example";

      labelAge.Location = new System.Drawing.Point(10, 12);
      labelAge.Text = "Phone";
      labelAge.AutoSize = true;

      maskedTextBoxAge.Location = new System.Drawing.Point(50, 10);
      maskedTextBoxAge.Mask = "+999(999)99999999";
      maskedTextBoxAge.Text = "";

      Controls.AddRange(new Control[] { labelAge, maskedTextBoxAge });
    }


    private Label labelAge = new Label();
    private MaskedTextBox maskedTextBoxAge = new MaskedTextBox();
  }
}
