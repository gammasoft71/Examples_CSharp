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
      button.Text = "Save...";
      button.Location = new System.Drawing.Point(10, 10);
      button.Click += delegate(object sender, EventArgs e) {
        SaveFileDialog saveFileDialog = new SaveFileDialog();
        saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        saveFileDialog.FileName = "MyFile.txt";
        saveFileDialog.Filter = "Text Files (*.txt)|*.txt;*.md|All Files (*.*)|*.*";
        if (saveFileDialog.ShowDialog() == DialogResult.OK)
          label.Text = string.Format("File = {0}", saveFileDialog.FileName);
      };

      label.Text = "Path = ";
      label.Location = new System.Drawing.Point(10, 40);
      label.Width = 340;

      Text = "SaveFileDialog example";
      Controls.AddRange(new Control[] { button, label});
    }

    private Button button = new Button();
    private Label label = new Label();
  }
}
