using System;
using System.Collections.Generic;

namespace Examples {
  class MainClass {
    public static void Main(string[] args) {
      List<string> names = new List<string>();
      names.Add("Bruce");
      names.Add("Alfred");
      names.Add("Tim");
      names.Add("Richard");

      // Display the contents of the list using the Print method.
      names.ForEach(Print);

      // The following demonstrates the lambda of C++ to display the contents of the list to the console.
      names.ForEach(delegate(string name) {
        Console.WriteLine(name);
      });
    }

    private static void Print(string s) {
      Console.WriteLine(s);
    }
  }
}

// This code produces the following output:
//
// Bruce
// Alfred
// Tim
// Richard
// Bruce
// Alfred
// Tim
// Richard
