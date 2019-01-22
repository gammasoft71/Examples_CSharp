using System;
using System.Diagnostics;

namespace Examples {
  class SocketExample {
    static bool exit = false;
    static int id = 0;
    static bool isBackground = false;
    static bool isThreadPoolThread = false;

    public static void Main(string[] args) {
      Debug.WriteLine("Start main");
      ProcessStartInfo si = new ProcessStartInfo("cmd", "/c timeout 2");
      si.UseShellExecute = false;
      Process process = Process.Start(si);
      process.EnableRaisingEvents = true;
      process.Exited += Process_Exited;
      while (!exit) Debug.Write(".");
      Debug.WriteLine("");
      Debug.WriteLine(string.Format("ct = {0}", System.Threading.Thread.CurrentThread.ManagedThreadId));
      Debug.WriteLine(string.Format("id = {0}", id));
      Debug.WriteLine(string.Format("isBackground = {0}", isBackground));
      Debug.WriteLine(string.Format("threadPoolThread = {0}", isThreadPoolThread));
      Debug.WriteLine("End main");
    }

    private static void Process_Exited(object sender, EventArgs e) {
      id = System.Threading.Thread.CurrentThread.ManagedThreadId;
      isBackground = System.Threading.Thread.CurrentThread.IsBackground;
      isThreadPoolThread = System.Threading.Thread.CurrentThread.IsThreadPoolThread;
      exit = true;
    }
  }
}

// This code example can produce the following output:
//
// Counter=186
// Counter=187
// Counter=188
// Counter=189
// ...
