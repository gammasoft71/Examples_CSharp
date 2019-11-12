using System;
using System.Windows.Forms;

namespace Examples {
  class Form1 : Form {
    public static void Main() {
      Application.EnableVisualStyles();
      Application.Run(new Form1());
    }

    public Form1() {
      ClientSize = new System.Drawing.Size(390, 270);
      Text = "Colored TabPages example";
      Controls.Add(tabControl1);

      tabControl1.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom;
      tabControl1.Location = new System.Drawing.Point(10, 10);
      tabControl1.Size = new System.Drawing.Size(370, 250);
      tabControl1.TabPages.AddRange(new TabPage[] { tabPageLightPink, tabPageLightGreen, tabPageLightBlue, tabPageLightYellow });
      tabControl1.Alignment = TabAlignment.Bottom;

      tabPageLightPink.Text = "LightPink";
      tabPageLightPink.BackColor = System.Drawing.Color.LightPink;

      tabPageLightGreen.Text = "LightGreen";
      tabPageLightGreen.BackColor = System.Drawing.Color.LightGreen;

      tabPageLightBlue.Text = "LightBlue";
      tabPageLightBlue.BackColor = System.Drawing.Color.LightBlue;

      tabPageLightYellow.Text = "LightYellow";
      tabPageLightYellow.BackColor = System.Drawing.Color.LightYellow;
    }

    private TabControl tabControl1 = new TabControl();
    private TabPage tabPageLightPink = new TabPage();
    private TabPage tabPageLightGreen = new TabPage();
    private TabPage tabPageLightBlue = new TabPage();
    private TabPage tabPageLightYellow = new TabPage();
  }
}
