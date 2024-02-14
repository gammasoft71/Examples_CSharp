using System;

namespace Examples {
  class MainClass {
    public static void Main(string[] args) {
      var strings = "One Two Three Four\nFive".Split();

      Console.WriteLine($"strings.Length = {strings.Length}");
      foreach (var s in strings)
        Console.WriteLine(s);
    }
  }
}

// This code produces the following output:
//
// strings.Length = 5
// One
// Two
// Three
// Four
// Five
