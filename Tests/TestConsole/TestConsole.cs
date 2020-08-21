using System;
using System.Drawing;

namespace TestConsole {
  class MainClass {
    public static void Main(string[] args) {
      SystemIcons.Application.Save(System.IO.File.OpenWrite(System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Application.ico")));
      SystemIcons.Error.Save(System.IO.File.OpenWrite(System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Error.ico")));
      SystemIcons.Exclamation.Save(System.IO.File.OpenWrite(System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Exclamation.ico")));
      SystemIcons.Information.Save(System.IO.File.OpenWrite(System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Information.ico")));
      SystemIcons.Question.Save(System.IO.File.OpenWrite(System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Question.ico")));
      SystemIcons.Shield.Save(System.IO.File.OpenWrite(System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Shield.ico")));
    }
  }
}

// This code produces the following output:
//
// Hello, World!
