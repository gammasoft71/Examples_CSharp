using System.Drawing;
using System.Windows.Forms;

namespace HelloWorldForm {
  class MainForm : Form {
    public static void Main() {
      Application.EnableVisualStyles();
      Application.Run(new MainForm());
    }

    public MainForm() {
      Text = "Hello world (label)";
      Controls.Add(label);

      label.Dock = DockStyle.Fill;
      label.Font = new Font(label.Font.FontFamily, 32, FontStyle.Bold | FontStyle.Italic);
      label.ForeColor = Color.Green;
      label.Text = "Hello, World!";
      label.TextAlign = ContentAlignment.MiddleCenter;
    }

    private Label label = new Label();
  }
}
