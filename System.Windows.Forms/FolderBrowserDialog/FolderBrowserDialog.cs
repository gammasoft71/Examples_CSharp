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
      button.Text = "Folder...";
      button.Location = new System.Drawing.Point(10, 10);
      button.Click += delegate(object sender, EventArgs e) {
        FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
        folderBrowserDialog.RootFolder = Environment.SpecialFolder.Desktop;
        folderBrowserDialog.SelectedPath = "C:\\Users\\Yves\\Projects\\xtd";
        if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
          label.Text = string.Format("Path = {0}", folderBrowserDialog.SelectedPath);
      };

      label.Text = "Path = ";
      label.Location = new System.Drawing.Point(10, 40);
      label.Width = 340;

      Text = "FolderBrowserDialog example";
      Controls.AddRange(new Control[] { button, label});
    }

    private Button button = new Button();
    private Label label = new Label();
  }
}
