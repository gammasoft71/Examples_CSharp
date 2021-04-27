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
      //Menu = CreateStandardMenu(OnMenuItemClick);
      Text = "Fill rectangle example";
      ClientSize = new Size(340, 300);

      Paint += delegate (Object sender, PaintEventArgs e) {
        ControlPaint.DrawButton(e.Graphics, new Rectangle(10, 10, 75, 25), ButtonState.Normal);
        ControlPaint.DrawButton(e.Graphics, new Rectangle(10, 40, 75, 25), ButtonState.Inactive);
        ControlPaint.DrawButton(e.Graphics, new Rectangle(10, 70, 75, 25), ButtonState.Pushed);
        ControlPaint.DrawButton(e.Graphics, new Rectangle(10, 100, 75, 25), ButtonState.Checked);
        ControlPaint.DrawButton(e.Graphics, new Rectangle(10, 130, 75, 25), ButtonState.Flat);
        ControlPaint.DrawButton(e.Graphics, new Rectangle(10, 160, 75, 25), ButtonState.All);

        ButtonRenderer.DrawButton(e.Graphics, new Rectangle(100, 10, 75, 25), System.Windows.Forms.VisualStyles.PushButtonState.Normal);
        ButtonRenderer.DrawButton(e.Graphics, new Rectangle(100, 40, 75, 25), System.Windows.Forms.VisualStyles.PushButtonState.Disabled);
        ButtonRenderer.DrawButton(e.Graphics, new Rectangle(100, 70, 75, 25), System.Windows.Forms.VisualStyles.PushButtonState.Pressed);
        ButtonRenderer.DrawButton(e.Graphics, new Rectangle(100, 100, 75, 25), System.Windows.Forms.VisualStyles.PushButtonState.Hot);
        ButtonRenderer.DrawButton(e.Graphics, new Rectangle(100, 130, 75, 25), System.Windows.Forms.VisualStyles.PushButtonState.Default);
      };

      Button b1 = new Button { Parent = this, Location = new Point(10, 200) };
      Button b2 = new Button { Parent = this, Location = new Point(10, 230), FlatStyle = FlatStyle.System };
      Button b3 = new Button { Parent = this, Location = new Point(100, 200), FlatStyle = FlatStyle.Popup };
      Button b4 = new Button { Parent = this, Location = new Point(100, 230), FlatStyle = FlatStyle.Flat };

      /*
      Paint += delegate (object sender, PaintEventArgs e) {
        var solidTransparentBrush = new System.Drawing.SolidBrush(Color.Transparent);
        e.Graphics.FillRectangle(solidTransparentBrush, new Rectangle(10, 10, 100, 100));

        var solidRedBrush = new System.Drawing.SolidBrush(Color.Red);
        e.Graphics.FillRectangle(solidRedBrush, new Rectangle(120, 10, 100, 100));

        var linearGradientBrush = new System.Drawing.Drawing2D.LinearGradientBrush(new Rectangle(230, 10, 100, 100), Color.Green, Color.White,System.Drawing.Drawing2D.LinearGradientMode.Horizontal);
        e.Graphics.FillRectangle(linearGradientBrush, new Rectangle(230, 10, 100, 100));

        var hatchBrush = new System.Drawing.Drawing2D.HatchBrush(System.Drawing.Drawing2D.HatchStyle.SolidDiamond, Color.Blue, Color.White);
        e.Graphics.FillRectangle(hatchBrush, new Rectangle(10, 120, 100, 100));

        var textureBrush = new System.Drawing.TextureBrush(CreateImageFromColor(Color.Yellow));
        e.Graphics.FillRectangle(textureBrush, new Rectangle(120, 120, 100, 100));
      };
      */
    }

    private Image CreateImageFromColor(Color color) {
      var bitmap = new Bitmap(16, 16);
      var g = Graphics.FromImage(bitmap);
      g.FillEllipse(new SolidBrush(color), 0, 0, bitmap.Width, bitmap.Height);
      g.DrawEllipse(new Pen(Color.Black), 0, 0, bitmap.Width - 1, bitmap.Height - 1);
      return bitmap;
    }

    private void OnMenuItemClick(object sender, EventArgs e) {
    }

    private MainMenu CreateStandardMenu(EventHandler menuItemClick) {
      return new MainMenu(new MenuItem[] {
         new MenuItem("&File", new MenuItem[] {
           new MenuItem("&New", menuItemClick, Shortcut.CtrlN),
           new MenuItem("&Open", menuItemClick, Shortcut.CtrlO),
           new MenuItem("-"),
           new MenuItem("&Save", menuItemClick, Shortcut.CtrlS),
           new MenuItem("Save &As", OnMenuItemClick),
           new MenuItem("-"),
           new MenuItem("&Print", menuItemClick, Shortcut.CtrlS),
           new MenuItem("Print pre&view", OnMenuItemClick),
           new MenuItem("-"),
           new MenuItem("&Exit", (_, EventArgs) => Close(), Shortcut.AltF4),
         }),
         new MenuItem("&Edit", new MenuItem[] {
           new MenuItem("&Undo", menuItemClick, Shortcut.CtrlZ),
           new MenuItem("&Redo", menuItemClick, Shortcut.CtrlShiftZ),
           new MenuItem("-"),
           new MenuItem("Cu&t", menuItemClick, Shortcut.CtrlX),
           new MenuItem("&Copy", menuItemClick, Shortcut.CtrlC),
           new MenuItem("&Paste", menuItemClick, Shortcut.CtrlV),
           new MenuItem("-"),
           new MenuItem("Select &All", menuItemClick, Shortcut.CtrlA),
         }),
         new MenuItem("&Tools", new MenuItem[] {
           new MenuItem("&Customize", OnMenuItemClick),
           new MenuItem("&Options", OnMenuItemClick),
         }),
         new MenuItem("&Help", new MenuItem[] {
           new MenuItem("&Content", OnMenuItemClick),
           new MenuItem("&Index", OnMenuItemClick),
           new MenuItem("&Search", OnMenuItemClick),
           new MenuItem("-"),
           new MenuItem("&About", OnMenuItemClick),
         }),
      });
    }
  }
}
