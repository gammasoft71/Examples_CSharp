using System.Windows.Forms;

namespace SomeControls {
  class MainForm : Form {
    // The main entry point for the application.
    public static void Main() {
      Application.EnableVisualStyles();
      Application.Run(new MainForm());
    }

    public MainForm() {
      this.button.Text = "Button";
      this.button.Location = new System.Drawing.Point(10, 10);

      this.label.Text = "こんにちは世界！";
      this.label.Location = new System.Drawing.Point(100, 13);
      this.label.Width = 200;

      this.radioButton1.Text = "RadioButton1";
      this.radioButton1.Location = new System.Drawing.Point(10, 40);
      this.radioButton1.Checked = true;

      this.radioButton2.Text = "RadioButton2";
      this.radioButton2.Location = new System.Drawing.Point(10, 70);

      this.radioButton3.Text = "RadioButton3";
      this.radioButton3.Location = new System.Drawing.Point(10, 100);

      this.groupBox.Text = "GroupBox";
      this.groupBox.Location = new System.Drawing.Point(10, 60);
      this.groupBox.Size = new System.Drawing.Size(200, 150);
      this.groupBox.Controls.AddRange(new Control[] { this.radioButton1, this.radioButton2, this.radioButton3});

      this.checkBox1.Text = "Checked";
      this.checkBox1.Location = new System.Drawing.Point(10, 10);
      this.checkBox1.CheckState = CheckState.Checked;

      this.checkBox2.Text = "Unchecked";
      this.checkBox2.Location = new System.Drawing.Point(10, 40);
      this.checkBox2.CheckState = CheckState.Unchecked;

      this.checkBox3.Text = "Indeterminate";
      this.checkBox3.Location = new System.Drawing.Point(10, 70);
      this.checkBox3.CheckState = CheckState.Indeterminate;

      this.panel.Location = new System.Drawing.Point(220, 60);
      this.panel.Size = new System.Drawing.Size(200, 150);
      this.panel.BorderStyle = BorderStyle.Fixed3D;
      this.panel.Controls.AddRange(new Control[] { this.checkBox1, this.checkBox2, this.checkBox3});

      this.progressBar.Location = new System.Drawing.Point(10, 240);
      this.progressBar.Width = 410;
      this.progressBar.Value = 40;

      this.Text = "Some Controls";
      this.ClientSize = new System.Drawing.Size(430, 280);
      this.Controls.AddRange(new Control[] { this.button, this.label, this.groupBox, this.panel, this.progressBar});
    }

    private Button button = new Button();
    private Label label = new Label();
    private RadioButton radioButton1 = new RadioButton(), radioButton2 = new RadioButton(), radioButton3 = new RadioButton();
    private GroupBox groupBox = new GroupBox();
    private CheckBox checkBox1 = new CheckBox(), checkBox2 = new CheckBox(), checkBox3 = new CheckBox();
    private Panel panel = new Panel();
    private ProgressBar progressBar = new ProgressBar();
  }
}
