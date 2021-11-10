#define TRACE

using System.Diagnostics;
using System.Windows.Forms;

namespace KeyEvents {
  class MainForm : Form {
    public static void Main() {
      Application.EnableVisualStyles();
      Application.Run(new MainForm());
    }

    public MainForm() {
      Text = "Key events example";

      KeyDown += delegate (object sender, KeyEventArgs e) {
        Trace.WriteLine(string.Format("KeyDown={{KeyCode={0}, KeyData=[{1}], Value=0x{2:X4}, Modifiers=[{3}]}}", e.KeyCode, e.KeyData, e.KeyValue, e.Modifiers));        
      };
      KeyPress += delegate (object sender, KeyPressEventArgs e) {
        Trace.WriteLine(string.Format("KeyPress={{KeyChar={0}}}", e.KeyChar));
      };
      KeyUp+= delegate (object sender, KeyEventArgs e) {
        Trace.WriteLine(string.Format("KeyUp={{KeyCode={0}, KeyData=[{1}], Value=0x{2:X4}, Modifiers=[{3}]}}", e.KeyCode, e.KeyData, e.KeyValue, e.Modifiers));
      };
    }

    private Label label = new Label();
  }
}
