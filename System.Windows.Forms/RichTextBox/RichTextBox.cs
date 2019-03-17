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
      this.Text = "RichTextBox example";

      this.richTextBox.Parent = this;
      this.richTextBox.Dock = DockStyle.Fill;

      this.richTextBox.AppendText("Colored text :\n");
      this.richTextBox.SelectionStart = this.richTextBox.TextLength;
      this.richTextBox.SelectionColor = System.Drawing.Color.Red;
      this.richTextBox.AppendText("  Red\n");
      this.richTextBox.SelectionColor = System.Drawing.Color.Green;
      this.richTextBox.AppendText("  Green\n");
      this.richTextBox.SelectionColor = System.Drawing.Color.Blue;
      this.richTextBox.AppendText("  Blue\n");
      this.richTextBox.SelectionColor = this.richTextBox.ForeColor;
    }

    private RichTextBox richTextBox = new RichTextBox();
  }
}
