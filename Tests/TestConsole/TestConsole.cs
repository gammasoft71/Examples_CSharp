using System;
using System.Text.RegularExpressions;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace HelloWorld {
  class MainClass {
    public static void Main(string[] args) {
      //Console.WriteLine("Hello World!");
      Match match = Regex.Match("bonjour à tous et surtout bonjour", "bonjour$");
      CaptureCollection captures = match.Captures;
      foreach (Capture capture in captures)
        Console.WriteLine("capture = {0}, index {1}, length {2}", capture, capture.Index, capture.Length);
    }
  }
}

// This code produces the following output:
//
// Hello, World!
