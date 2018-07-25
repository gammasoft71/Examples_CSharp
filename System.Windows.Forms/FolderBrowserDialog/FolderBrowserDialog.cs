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
      this.button.Text = "Folder...";
      this.button.Location = new System.Drawing.Point(10, 10);
      this.button.Click += delegate(object sender, EventArgs e) {
        FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
        folderBrowserDialog.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
          this.label.Text = string.Format("Path = {0}", folderBrowserDialog.SelectedPath);
      };

      this.label.Text = "Path = ";
      this.label.Location = new System.Drawing.Point(10, 40);
      this.label.Width = 340;

      this.Text = "FolderBrowserDialog example";
      this.Controls.AddRange(new Control[] { this.button, this.label});
    }

    private Button button = new Button();
    private Label label = new Label();
  }
}
