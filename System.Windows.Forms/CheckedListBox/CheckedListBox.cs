using System;
using System.Windows.Forms;

namespace Examples {
  class MainForm : Form {
    public static void Main() {
      Application.EnableVisualStyles();
      Application.Run(new MainForm());
    }

    public MainForm() {
      Text = "CheckedListBox example";
      StartPosition = FormStartPosition.Manual;
      Location = new System.Drawing.Point(200, 200);
      ClientSize = new System.Drawing.Size(200, 240);

      checkedlistBox.Parent = this;
      checkedlistBox.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom;
      checkedlistBox.Bounds = new System.Drawing.Rectangle(20, 20, 160, 200);

      for (int i = 1; i <= 50; ++i)
        checkedlistBox.Items.Add(string.Format("Item {0}", i), i % 2 != 0);
    }

    private CheckedListBox checkedlistBox = new CheckedListBox();
  }
}
