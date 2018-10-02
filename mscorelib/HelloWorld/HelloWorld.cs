using System;

namespace HelloWorld {
  class MainClass {
    public static void Main(string[] args) {
      Console.WriteLine("Hello World!");
      string[] items = (string[])Array.CreateInstance(typeof(string), 20);
 
      foreach (var item in items)
        Console.WriteLine(item);
    }
  }
}

// This code produces the following output:
//
// Hello, World!
