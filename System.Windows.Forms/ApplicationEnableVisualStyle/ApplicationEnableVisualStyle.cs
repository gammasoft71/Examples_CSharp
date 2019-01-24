using System.Windows.Forms;

namespace Examples {
  class Form1 : Form {
    private Button button1 = new Button();

    // The main entry point for the application.
    public static void Main() {
      // Comment following line to see the difference (Windows only).
      Application.EnableVisualStyles();
      Application.Run(new Form1());
    }

    public Form1() {
      this.button1.Location = new System.Drawing.Point(24, 16);
      this.button1.Size = new System.Drawing.Size(120, 100);
      this.button1.Text = "I am themed.";

      // Sets up how the form should be displayed and adds the controls to the form.
      this.ClientSize = new System.Drawing.Size(300, 286);
      this.Controls.Add(this.button1);

      this.Text = "Application::EnableVisualStyles Example";
    }
  };
}
