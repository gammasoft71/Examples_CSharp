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
    private const int WM_ENTERSIZEMOVE = 0x0231;
    private const int WM_EXITSIZEMOVE = 0x0232;
    private const int WM_GETTEXT = 0x000D;
    private const int WM_GETTEXTLENGTH = 0x000E;
    private const int WM_KEYDOWN = 0x0100;
    private const int WM_KEYUP = 0x0101;
    private const int WM_CHAR = 0x0102;
    private const int WM_KILLFOCUS = 0x0008;
    private const int WM_LBUTTONDBLCLK = 0x0203;
    private const int WM_LBUTTONDOWN = 0x0201;
    private const int WM_LBUTTONUP = 0x0202;
    private const int WM_MBUTTONDOWN = 0x0207;
    private const int WM_MBUTTONUP = 0x0208;
    private const int WM_MBUTTONDBLCLK = 0x0209;
    private const int WM_MOUSEMOVE = 0x0200;
    private const int WM_MOUSEHWHEEL = 0x020E;
    private const int WM_MOUSELEAVE = 0x02A3;
    private const int WM_MOUSEWHEEL = 0x020A;
    private const int WM_MOVE = 0x0003;
    private const int WM_RBUTTONDOWN = 0x0204;
    private const int WM_RBUTTONUP = 0x0205;
    private const int WM_RBUTTONDBLCLK = 0x0206;
    private const int WM_SETFOCUS = 0x0007;
    private const int WM_SETTEXT = 0x000C;
    private const int WM_SHOWWINDOW = 0x0018;
    private const int WM_SIZE = 0x0005;
    private const int WM_XBUTTONDOWN = 0x020B;
    private const int WM_XBUTTONUP = 0x020C;
    private const int WM_XBUTTONDBLCLK = 0x020D;

    private const int WM_USER = 0x0400;
    private const int WM_MOUSEENTER = WM_USER + 0x0001;


    public Form1() {
      Text = "Form and Messages";
      Enabled = false;
      StartPosition = FormStartPosition.CenterScreen;
      
      LocationChanged += delegate {
        System.Diagnostics.Debug.WriteLine(string.Format("LocationChange Location = {0}", Location));
      };

      SizeChanged += delegate {
        System.Diagnostics.Debug.WriteLine(string.Format("SizeChanged Size = {0}", Size));
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

    protected override void OnCreateControl() {
      //base.OnCreateControl();
      System.Diagnostics.Debug.WriteLine("OnCreateControl()");
    }

    protected override void OnHandleCreated(EventArgs e) {
      base.OnHandleCreated(e);
    }

    protected override void WndProc(ref Message message) {
      base.WndProc(ref message);

      switch(message.Msg) {
        case WM_ACTIVATEAPP: System.Diagnostics.Debug.WriteLine(string.Format("WM_ACTIVATEAPP [activate={0}, threat={1}]", message.WParam, message.LParam)); break;
        case WM_CANCELMODE: System.Diagnostics.Debug.WriteLine("WM_CANCELMODE"); break;
        case WM_CHAR: System.Diagnostics.Debug.WriteLine(string.Format("WM_CHAR [char='{0}', repeat={1}]", (char)message.WParam, message.LParam)); break;
        case WM_CLOSE: System.Diagnostics.Debug.WriteLine("WM_CLOSE"); break;
        case WM_COMMAND: System.Diagnostics.Debug.WriteLine(string.Format("WM_COMMAND [type=0x{0:X8}, Control={1}]", message.WParam, message.LParam)); break;
        case WM_CREATE: System.Diagnostics.Debug.WriteLine(string.Format("WM_CREATE [CREATESTRUCT={0}]", message.LParam)); break;
        case WM_DESTROY: System.Diagnostics.Debug.WriteLine("WM_DESTROY"); break;
        case WM_ENTERSIZEMOVE: System.Diagnostics.Debug.WriteLine("WM_ENTERSIZEMOVE"); break;
        case WM_EXITSIZEMOVE: System.Diagnostics.Debug.WriteLine("WM_EXITSIZEMOVE"); break;
        case WM_GETTEXT: System.Diagnostics.Debug.WriteLine(string.Format("WM_GETTEXT [size={0}, buffer={1}]", message.WParam, message.LParam)); break;
        case WM_GETTEXTLENGTH: System.Diagnostics.Debug.WriteLine("WM_GETTEXTLENGTH"); break;
        case WM_KEYDOWN: System.Diagnostics.Debug.WriteLine(string.Format("WM_KEYDOWN [Key={0}, repeat={1}]", (Keys)message.WParam, message.LParam)); break;
        case WM_KEYUP: System.Diagnostics.Debug.WriteLine(string.Format("WM_KEYUP [Key={0}, repeat={1}]", (Keys)message.WParam, message.LParam)); break;
        case WM_KILLFOCUS: System.Diagnostics.Debug.WriteLine("WM_KILLFOCUS"); break;
        case WM_LBUTTONDBLCLK: System.Diagnostics.Debug.WriteLine(string.Format("WM_LBUTTONDBLCLK [Keys={0}, x={1}, y={2}]", message.WParam, LOWORD(message.LParam), HIWORD(message.LParam))); break;
        case WM_LBUTTONDOWN: System.Diagnostics.Debug.WriteLine(string.Format("WM_LBUTTONDOWN [Keys={0}, x={1}, y={2}]", message.WParam, LOWORD(message.LParam), HIWORD(message.LParam))); break;
        case WM_LBUTTONUP: System.Diagnostics.Debug.WriteLine(string.Format("WM_LBUTTONUP [Keys={0}, x={1}, y={2}]", message.WParam, LOWORD(message.LParam), HIWORD(message.LParam))); break;
        case WM_MBUTTONDBLCLK: System.Diagnostics.Debug.WriteLine(string.Format("WM_MBUTTONDBLCLK [Keys={0}, x={1}, y={2}]", message.WParam, LOWORD(message.LParam), HIWORD(message.LParam))); break;
        case WM_MBUTTONDOWN: System.Diagnostics.Debug.WriteLine(string.Format("WM_MBUTTONDOWN [Keys={0}, x={1}, y={2}]", message.WParam, LOWORD(message.LParam), HIWORD(message.LParam))); break;
        case WM_MBUTTONUP: System.Diagnostics.Debug.WriteLine(string.Format("WM_MBUTTONUP [Keys={0}, x={1}, y={2}]", message.WParam, LOWORD(message.LParam), HIWORD(message.LParam))); break;
        case WM_MOUSEENTER: System.Diagnostics.Debug.WriteLine("WM_MOUSEENTER"); break;
        case WM_MOUSEHWHEEL: System.Diagnostics.Debug.WriteLine(string.Format("WM_MOUSEHWHEEL [Keys={0}, Delta={1} x={2}, y={3}", LOWORD(message.WParam), HIWORD(message.WParam), LOWORD(message.LParam), HIWORD(message.LParam))); break;
        case WM_MOUSELEAVE: System.Diagnostics.Debug.WriteLine("WM_MOUSELEAVE"); break;
        case WM_MOUSEMOVE: System.Diagnostics.Debug.WriteLine(string.Format("WM_MOUSEMOVE [Keys={0}, x={1}, y={2}]", message.WParam, LOWORD(message.LParam), HIWORD(message.LParam))); break;
        case WM_MOUSEWHEEL: System.Diagnostics.Debug.WriteLine(string.Format("WM_MOUSEWHEEL [Keys={0}, Delta={1} x={2}, y={3}", LOWORD(message.WParam), HIWORD(message.WParam), LOWORD(message.LParam), HIWORD(message.LParam))); break;
        case WM_MOVE: System.Diagnostics.Debug.WriteLine(string.Format("WM_MOVE x = {0}, y = {1}", LOWORD(message.LParam), HIWORD(message.LParam))); break;
        case WM_RBUTTONDBLCLK: System.Diagnostics.Debug.WriteLine(string.Format("WM_RBUTTONDBLCLK [Keys={0}, x={1}, y={2}]", message.WParam, LOWORD(message.LParam), HIWORD(message.LParam))); break;
        case WM_RBUTTONDOWN: System.Diagnostics.Debug.WriteLine(string.Format("WM_RBUTTONDOWN [Keys={0}, x={1}, y={2}]", message.WParam, LOWORD(message.LParam), HIWORD(message.LParam))); break;
        case WM_RBUTTONUP: System.Diagnostics.Debug.WriteLine(string.Format("WM_RBUTTONUP [Keys={0}, x={1}, y={2}]", message.WParam, LOWORD(message.LParam), HIWORD(message.LParam))); break;
        case WM_SETFOCUS: System.Diagnostics.Debug.WriteLine("WM_SETFOCUS"); break;
        case WM_SETTEXT: System.Diagnostics.Debug.WriteLine(string.Format("WM_SETTEXT text = {0}", Marshal.PtrToStringAuto(message.LParam))); break;
        case WM_SHOWWINDOW: System.Diagnostics.Debug.WriteLine(string.Format("WM_SHOWWINDOW shown = {0}", message.WParam)); break;
        case WM_SIZE: System.Diagnostics.Debug.WriteLine(string.Format("WM_SIZE type = {0}, width = {1}, heignt = {2}", message.WParam, LOWORD(message.LParam), HIWORD(message.LParam))); break;
        default: System.Diagnostics.Debug.WriteLine(string.Format("[Msg=0x{0:X4}, HWnd=0x{1:X}, WParam=0x{2:X}, LParam=0x{3:X}, Result=0x{4:X}]", message.Msg, (long)message.HWnd, (long)message.WParam, (long)message.LParam, (long)message.Result)); break;
      }
    }
  }
}
