using System;
using System.Windows.Forms;

namespace Examples {
  class Program {
    public static void Main() {
      Action<string> messageTarget;

      if (Environment.GetCommandLineArgs().Length > 1)
        messageTarget = ShowWindowsMessage;
      else
        messageTarget = WriteLine;

      messageTarget("Hello, World!");
    }

    private static void ShowWindowsMessage(string message) {
      MessageBox.Show(message);
    }

    private static void WriteLine(string message) {
      Console.WriteLine(message);
    }
  }
}
