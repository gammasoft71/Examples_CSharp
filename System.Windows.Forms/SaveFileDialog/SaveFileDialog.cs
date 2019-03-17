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
      this.button.Text = "Save...";
      this.button.Location = new System.Drawing.Point(10, 10);
      this.button.Click += delegate(object sender, EventArgs e) {
        SaveFileDialog saveFileDialog = new SaveFileDialog();
        saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        saveFileDialog.FileName = "MyFile.txt";
        saveFileDialog.Filter = "Text Files (*.txt)|*.txt;*.md|All Files (*.*)|*.*";
        if (saveFileDialog.ShowDialog() == DialogResult.OK)
          this.label.Text = string.Format("File = {0}", saveFileDialog.FileName);
      };

      this.label.Text = "Path = ";
      this.label.Location = new System.Drawing.Point(10, 40);
      this.label.Width = 340;

      this.Text = "SaveFileDialog example";
      this.Controls.AddRange(new Control[] { this.button, this.label});
    }

    private Button button = new Button();
    private Label label = new Label();
  }
}
