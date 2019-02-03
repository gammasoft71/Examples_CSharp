using System.Windows.Forms;

namespace HelloWorldForm {
  class MainForm : Form {
    public static void Main() {
      Application.EnableVisualStyles();
      Application.Run(new MainForm());
    }

    public MainForm() {
      this.label.Text = "Hello, World!";
      this.label.Font = new System.Drawing.Font("Arial", 32, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic);
      this.label.ForeColor = System.Drawing.Color.Green;
      this.label.Location = new System.Drawing.Point(5, 100);
      this.label.Size = new System.Drawing.Size(290, 100);

      this.Text = "My first application";
      this.StartPosition = FormStartPosition.CenterScreen;
      this.ClientSize = new System.Drawing.Size(300, 300);
      this.Controls.Add(this.label);
    }

    private Label label = new Label();
  }
}
