#define TRACE

using System.Windows.Forms;

namespace Examples {
  class MainClass {
    public static void Main() {
      Form form = new Form();
      form.Text = Examples.Properties.Resources.Caption;
      System.Diagnostics.Trace.WriteLine(Examples.Properties.Resources.Information);

      Application.Run(form);
    }
  }
}
