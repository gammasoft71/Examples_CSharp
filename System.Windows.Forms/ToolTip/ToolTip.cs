using System;
using System.Windows.Forms;

namespace Examples {
  class MainForm : Form {
    public static void Main() {
      Application.EnableVisualStyles();
      Application.Run(new MainForm());
    }

    public MainForm() {
      this.Text = "ToolTip example";

      this.button.Parent = this;
      this.button.Text = "button";
      this.button.Location = new System.Drawing.Point(10, 10);

      this.checkBox.Parent = this;
      this.checkBox.Text = "check";
      this.checkBox.Location = new System.Drawing.Point(10, 40);

      this.label.Parent = this;
      this.label.Text = "label";
      this.label.Location = new System.Drawing.Point(10, 70);

      toolTip.ToolTipTitle = "ToolTip title";
      toolTip.SetToolTip(this.button, "button toolTip...");
      toolTip.SetToolTip(this.checkBox, "checkBox toolTip...");
      toolTip.SetToolTip(this.label, "label toolTip...");
    }

    private Button button = new Button();
    private CheckBox checkBox = new CheckBox();
    private Label label = new Label();
    private ToolTip toolTip = new ToolTip();
  }
}
