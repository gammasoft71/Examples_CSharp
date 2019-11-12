using System;
using System.Windows.Forms;

namespace FolderBrowserDialogExample {
  class Form1 : Form {
    // The main entry point for the application.
    [STAThread]
    public static void Main() {
      Application.EnableVisualStyles();
      Application.Run(new Form1());
    }

    public Form1() {
      button.Text = "Open...";
      button.Location = new System.Drawing.Point(10, 10);
      button.Click += delegate(object sender, EventArgs e) {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
        System.Diagnostics.Debug.WriteLine(string.Format("dialog = {0}", openFileDialog));
        if (openFileDialog.ShowDialog() == DialogResult.OK)
          label.Text = string.Format("File = {0}", openFileDialog.FileName);
      };

      label.Text = "Path = ";
      label.Location = new System.Drawing.Point(10, 40);
      label.Width = 340;

      Text = "OpenFileDialog example";
      Controls.AddRange(new Control[] { button, label});
    }

    private Button button = new Button();
    private Label label = new Label();
  }
}
