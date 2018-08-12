using System;

namespace Examples {
  class Program {
    public static void Main(string[] args) {
      Console.Write("Hello ");
      Console.WriteLine("World!");
      Console.Write("Enter your name: ");
      string name = Console.ReadLine();
      Console.Write("Good day, ");
      Console.Write(name);
      Console.WriteLine("!");
    }
  }
}

// This code produces the following output:
//
// Hello, World!
