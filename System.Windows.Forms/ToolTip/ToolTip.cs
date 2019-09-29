using System;
using System.Windows.Forms;

namespace Examples {
  class MainForm : Form {
    public static void Main() {
      Application.EnableVisualStyles();
      Application.Run(new MainForm());
    }

    public MainForm() {
      Text = "ToolTip example";

      button.Parent = this;
      button.Text = "button";
      button.Location = new System.Drawing.Point(10, 10);

      checkBox.Parent = this;
      checkBox.Text = "check";
      checkBox.Location = new System.Drawing.Point(10, 40);

      label.Parent = this;
      label.Text = "label";
      label.Location = new System.Drawing.Point(10, 70);

      toolTip.ToolTipTitle = "ToolTip title";
      toolTip.SetToolTip(button, "button toolTip...");
      toolTip.SetToolTip(checkBox, "checkBox toolTip...");
      toolTip.SetToolTip(label, "label toolTip...");
    }

    private Button button = new Button();
    private CheckBox checkBox = new CheckBox();
    private Label label = new Label();
    private ToolTip toolTip = new ToolTip();
  }
}
