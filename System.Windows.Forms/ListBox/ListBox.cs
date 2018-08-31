using System;
using System.Windows.Forms;

namespace Examples {
  class MainForm : Form {
    public static void Main() {
      Application.EnableVisualStyles();
      Application.Run(new MainForm());
    }

    public MainForm() {
      this.Text = "ListBox example";

      this.StartPosition = FormStartPosition.Manual;
      this.Location = new System.Drawing.Point(200, 200);
      this.ClientSize = new System.Drawing.Size(360, 240);

      this.listBoxActionsLeft.Parent = this;
      this.listBoxActionsLeft.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Bottom;
      this.listBoxActionsLeft.Bounds = new System.Drawing.Rectangle(20, 20, 150, 200);
      this.listBoxActionsLeft.DoubleClick += delegate(object sender, EventArgs e) {
        if (this.listBoxActionsLeft.SelectedIndex != -1) {
          this.listBoxActionsRight.Items.Add(this.listBoxActionsLeft.SelectedItem);
          this.listBoxActionsRight.SelectedIndex = this.listBoxActionsRight.Items.Count - 1;
          this.listBoxActionsLeft.Items.Remove(this.listBoxActionsLeft.SelectedItem);
        }
      };

      this.listBoxActionsRight.Parent = this;
      this.listBoxActionsRight.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Right;
      this.listBoxActionsRight.Bounds = new System.Drawing.Rectangle(190, 20, 150, 200);
      this.listBoxActionsRight.DoubleClick += delegate(object sender, EventArgs e) {
        if (this.listBoxActionsRight.SelectedIndex != -1) {
          this.listBoxActionsLeft.Items.Add(this.listBoxActionsRight.SelectedItem);
          this.listBoxActionsLeft.SelectedIndex = this.listBoxActionsLeft.Items.Count - 1;
          this.listBoxActionsRight.Items.Remove(this.listBoxActionsRight.SelectedItem);
        }
      };

      this.listBoxActionsLeft.Items.AddRange(new string[] { "draw", "cut", "paste", "delete", "open", "close", "remove", "edit", "find", "increment", "decrement", "write", "read", "post", "build", "make", "release", "create", "choose", "erase"});
    }

    private ListBox listBoxActionsLeft = new ListBox();
    private ListBox listBoxActionsRight = new ListBox();
  }
}
