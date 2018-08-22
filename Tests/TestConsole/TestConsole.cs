using System;

namespace HelloWorld {
  class MainClass {
    class Foo {
      public void Print(string s) {
        Console.WriteLine(s);
      }
    };
    delegate void Print(string s);
    public static void Main(string[] args) {
      //Console.WriteLine("Hello World!");
      Foo foo = new Foo();
      Print print = foo.Print;

      print += foo.Print;
      print += foo.Print;

      print("Hello, World!");
    }
  }
}

// This code produces the following output:
//
// Hello, World!
