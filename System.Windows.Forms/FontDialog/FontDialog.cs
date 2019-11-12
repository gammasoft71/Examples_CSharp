using System;
using System.Windows.Forms;

namespace FolderBrowserDialogExample {
  class Form1 : Form {
    // The main entry point for the application.
    public static void Main() {
      Application.EnableVisualStyles();
      Application.Run(new Form1());
    }

    public Form1() {
      label.Text = "The quick brown fox jumps over the lazy dog.\n" +
        "THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG.\n" +
        "0123456789+-*/%~^&|=<>≤≥±÷≠{{[()]}},;:.?¿!¡\n" +
        "àçéèêëïî@@°_#§$ù£€æœøπµ©®∞\\\"'\n" +
        "\u0400\u0401\u0402\u0403\u0404\u0405\u0406\u0407\u0408\u0409\u040a\u040b\u040c\u040d\u040e\u040f\n" +
        "\u0410\u0411\u0412\u0413\u0414\u0415\u0416\u0417\u0418\u0419\u041a\u041b\u041c\u041d\u041e\u041f\n" +
      "\u4ea0\u4ea1\u4ea2\u4ea3\u4ea4\u4ea5\u4ea6\u4ea7\u4ea8\u4ea9\u4eaa\u4eab\u4eac\u4ead\u4eae\u4eaf\n" +
        "\u4eb0\u4eb1\u4eb2\u4eb3\u4eb4\u4eb5\u4eb6\u4eb7\u4eb8\u4eb9\u4eba\u4ebb\u4ebc\u4ebd\u4ebe\u4ebf\n";
      //"\U0001F428";
      label.Location = new System.Drawing.Point(10, 50);
      label.Size = new System.Drawing.Size(380, 340);

      button.Text = "Font...";
      button.Location = new System.Drawing.Point(10, 10);

      button.Click += delegate (object sender, EventArgs e) {
        FontDialog fontDialog = new FontDialog();
        fontDialog.ShowColor = true;
        fontDialog.Font = label.Font;
        fontDialog.Color = label.ForeColor;
        if (fontDialog.ShowDialog() == DialogResult.OK) {
          label.Font = fontDialog.Font;
          label.ForeColor = fontDialog.Color;
        }
      };

      Text = "Font Example";
      ClientSize = new System.Drawing.Size(400, 400);
      Controls.AddRange(new Control[] { button, label });
    }

    private Button button = new Button();
    private Label label = new Label();
  }
}
