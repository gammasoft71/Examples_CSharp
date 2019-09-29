using System;
using System.Windows.Forms;

namespace Examples {
  class MainForm : Form {
    public static void Main() {
      Application.EnableVisualStyles();
      Application.Run(new MainForm());
    }

    public MainForm() {
      Text = "ListBox example";

      StartPosition = FormStartPosition.Manual;
      Location = new System.Drawing.Point(200, 200);
      ClientSize = new System.Drawing.Size(360, 240);

      listBoxActionsLeft.Parent = this;
      listBoxActionsLeft.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Bottom;
      listBoxActionsLeft.Bounds = new System.Drawing.Rectangle(20, 20, 150, 200);
      listBoxActionsLeft.DoubleClick += delegate(object sender, EventArgs e) {
        if (listBoxActionsLeft.SelectedIndex != -1) {
          listBoxActionsRight.Items.Add(listBoxActionsLeft.SelectedItem);
          listBoxActionsRight.SelectedIndex = listBoxActionsRight.Items.Count - 1;
          listBoxActionsLeft.Items.Remove(listBoxActionsLeft.SelectedItem);
        }
      };

      listBoxActionsRight.Parent = this;
      listBoxActionsRight.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Right;
      listBoxActionsRight.Bounds = new System.Drawing.Rectangle(190, 20, 150, 200);
      listBoxActionsRight.DoubleClick += delegate(object sender, EventArgs e) {
        if (listBoxActionsRight.SelectedIndex != -1) {
          listBoxActionsLeft.Items.Add(listBoxActionsRight.SelectedItem);
          listBoxActionsLeft.SelectedIndex = listBoxActionsLeft.Items.Count - 1;
          listBoxActionsRight.Items.Remove(listBoxActionsRight.SelectedItem);
        }
      };

      listBoxActionsLeft.Items.AddRange(new string[] { "draw", "cut", "paste", "delete", "open", "close", "remove", "edit", "find", "increment", "decrement", "write", "read", "post", "build", "make", "release", "create", "choose", "erase"});
    }

    private ListBox listBoxActionsLeft = new ListBox();
    private ListBox listBoxActionsRight = new ListBox();
  }
}
