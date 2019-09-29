using System;
using System.Windows.Forms;

public static class RichTextBoxExtensions {
  public static void AppendText(this System.Windows.Forms.RichTextBox box, string text, System.Drawing.Color color) {
    box.SelectionStart = box.TextLength;
    box.SelectionLength = 0;

    box.SelectionColor = color;
    box.AppendText(text);
    box.SelectionColor = box.ForeColor;
  }
}

namespace Examples {
  class MainForm : Form {
    public static void Main() {
      Application.EnableVisualStyles();
      Application.Run(new MainForm());
    }

    public MainForm() {
      Text = "RichTextBox example";

      richTextBox.Parent = this;
      richTextBox.Dock = DockStyle.Fill;

      richTextBox.AppendText("Colored text :\n");
      richTextBox.SelectionStart = richTextBox.TextLength;
      richTextBox.SelectionColor = System.Drawing.Color.Red;
      richTextBox.AppendText("  Red\n");
      richTextBox.SelectionColor = System.Drawing.Color.Green;
      richTextBox.AppendText("  Green\n");
      richTextBox.SelectionColor = System.Drawing.Color.Blue;
      richTextBox.AppendText("  Blue\n");
      richTextBox.SelectionColor = richTextBox.ForeColor;
    }

    private RichTextBox richTextBox = new RichTextBox();
  }
}
