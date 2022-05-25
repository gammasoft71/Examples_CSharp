using System;
using System.Net;
using System.Drawing;

namespace TestConsole {
  class MainClass {
    public static void Main(string[] args) {
      Console.WriteLine("Version = {0}", Environment.OSVersion);
      Console.WriteLine("Version = {0}", System.Runtime.InteropServices.RuntimeEnvironment.GetSystemVersion());
      Console.WriteLine("Version = {0}", System.Runtime.InteropServices.RuntimeInformation.OSDescription);

      Console.ReadKey();
    }
  }
}

// This code produces the following output:
//
// Hello, World!
