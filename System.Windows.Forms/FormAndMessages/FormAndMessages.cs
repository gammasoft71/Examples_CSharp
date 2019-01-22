using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Examples {
  class Form1 : Form {
    [DllImport("user32.dll")]
    public static extern int SendMessageW(IntPtr hWnd, int wMsg, IntPtr wParam, IntPtr lParam);

    private const int WM_ACTIVATEAPP = 0x001C;
    private const int WM_CANCELMODE = 0x001F;
    private const int WM_CLOSE = 0x0010;
    private const int WM_COMMAND = 0x0111;
    private const int WM_CREATE = 0x0001;
    private const int WM_DESTROY = 0x0002;
    private const int WM_ENABLE = 0x000A;
    private const int WM_ENTERSIZEMOVE = 0x0231;
    private const int WM_EXITSIZEMOVE = 0x0232;
    private const int WM_MOVE = 0x0003;
    private const int WM_NULL = 0x0000;
    private const int WM_QUIT = 0x0012;
    private const int WM_SETTEXT = 0x000C;
    private const int WM_SHOWWINDOW = 0x0018;
    private const int WM_SIZE = 0x0005;

    public Form1() {
      this.Text = "Form and Messages";
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Controls.Add(this.button1);

      this.LocationChanged += delegate {
        System.Diagnostics.Debug.WriteLine(string.Format("LocationChange Location = {0}", this.Location));
      };

      this.SizeChanged += delegate {
        System.Diagnostics.Debug.WriteLine(string.Format("SizeChanged Size = {0}", this.Size));
      };

      this.button1.Text = "Click";
      this.button1.Click += delegate {
        SendMessageW(this.Handle, WM_SETTEXT, IntPtr.Zero, Marshal.StringToBSTR("Hello, World!"));
        //this.Text = "Hello, World!";
      };
    }

    private int HIWORD(IntPtr l) {
      return (short)(((int)l >> 16) & 0xffff);
    }

    private int LOWORD(IntPtr l) {
      return (short)((int)l & 0xffff);
    }

    // The main entry point for the application.
    [STAThread]
    public static void Main() {
      Application.EnableVisualStyles();
      Application.Run(new Form1());
    }

    protected override void WndProc(ref Message message) {
      base.WndProc(ref message);

      switch(message.Msg) {
        case WM_ACTIVATEAPP: System.Diagnostics.Debug.WriteLine(string.Format("WM_ACTIVATEAPP activate = {0}, threat = {1}", message.WParam, message.LParam)); break;
        case WM_CANCELMODE: System.Diagnostics.Debug.WriteLine("WM_CANCELMODE"); break;
        case WM_CLOSE: System.Diagnostics.Debug.WriteLine("WM_CLOSE"); break;
        case WM_COMMAND: System.Diagnostics.Debug.WriteLine(string.Format("WM_COMMAND type = 0x{0:X8}, Control = {1}", message.WParam, message.LParam)); break;
        case WM_CREATE: System.Diagnostics.Debug.WriteLine(string.Format("WM_CREATE CREATESTRUCT pointer = {0}", message.LParam)); break;
        case WM_DESTROY: System.Diagnostics.Debug.WriteLine("WM_DESTROY"); break;
        case WM_ENABLE: System.Diagnostics.Debug.WriteLine(string.Format("WM_ENABLE enabled = {0}", message.WParam)); break;
        case WM_ENTERSIZEMOVE: System.Diagnostics.Debug.WriteLine("WM_ENTERSIZEMOVE"); break;
        case WM_EXITSIZEMOVE: System.Diagnostics.Debug.WriteLine("WM_EXITSIZEMOVE"); break;
        case WM_MOVE: System.Diagnostics.Debug.WriteLine(string.Format("WM_MOVE x = {0}, y = {1}", LOWORD(message.LParam), HIWORD(message.LParam))); break;
        case WM_NULL: System.Diagnostics.Debug.WriteLine("WM_NULL"); break;
        case WM_QUIT: System.Diagnostics.Debug.WriteLine(string.Format("WMQUIT exit code = {0}", message.WParam)); break;
        case WM_SETTEXT: System.Diagnostics.Debug.WriteLine(string.Format("WM_SETTEXT text = {0}", Marshal.PtrToStringAuto(message.LParam))); break;
        case WM_SHOWWINDOW: System.Diagnostics.Debug.WriteLine(string.Format("WM_SHOWWINDOW shown = {0}", message.WParam)); break;
        case WM_SIZE: System.Diagnostics.Debug.WriteLine(string.Format("WM_SIZE type = {0}, width = {1}, heignt = {2}", message.WParam, LOWORD(message.LParam), HIWORD(message.LParam))); break;
        //default: System.Diagnostics.Debug.WriteLine(string.Format("message 0x{0:X4}", message.Msg)); break;
      }
    }

    Button button1 = new Button();
  }
}
