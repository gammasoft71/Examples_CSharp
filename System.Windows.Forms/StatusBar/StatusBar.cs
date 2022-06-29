using System;
using System.Drawing;
using System.Windows.Forms;

namespace Examples {
  class MainForm : Form {
    [STAThread]
    public static void Main() {
      Application.EnableVisualStyles();
      Application.Run(new MainForm());
    }

    public MainForm() {
      Text = "StatusBar example";
      ClientSize = new Size(820, 500);

      statusBarPanel1.Text = "Status one";
      statusBarPanel1.BorderStyle = StatusBarPanelBorderStyle.Sunken;
      statusBarPanel1.Width = 150;
      statusBarPanel1.AutoSize = StatusBarPanelAutoSize.Contents;
      statusBarPanel1.Icon = Icon.FromHandle(CreateImage(Color.LightGreen).GetHicon());
      statusBarPanel1.ToolTipText = "Status one tool tip text";

      statusBarPanel2.Text = "Status two";
      statusBarPanel2.AutoSize = StatusBarPanelAutoSize.Contents;
      statusBarPanel2.BorderStyle = StatusBarPanelBorderStyle.Sunken;

      statusBarPanel3.Text = "Status three";
      statusBarPanel3.AutoSize = StatusBarPanelAutoSize.Spring;
      statusBarPanel3.BorderStyle = StatusBarPanelBorderStyle.Sunken;

      statusBar1.Parent = this;
      statusBar1.Padding = new Padding(2);
      statusBar1.Panels.AddRange(new StatusBarPanel[] {statusBarPanel1, statusBarPanel2, statusBarPanel3});
      statusBar1.ShowPanels = true;
    }

    private Bitmap CreateImage(Color color) {
      var bitmap = new Bitmap(16, 16);
      var g = Graphics.FromImage(bitmap);
      g.FillEllipse(new SolidBrush(color), 0, 0, bitmap.Width, bitmap.Height);
      g.DrawEllipse(new Pen(ControlPaint.Dark(color, 0.2f)), 0, 0, bitmap.Width - 1, bitmap.Height - 1);
      return bitmap;
    }

    private StatusBar statusBar1 = new StatusBar();
    private StatusBarPanel statusBarPanel1 = new StatusBarPanel();
    private StatusBarPanel statusBarPanel2 = new StatusBarPanel();
    private StatusBarPanel statusBarPanel3 = new StatusBarPanel();
  }
}
