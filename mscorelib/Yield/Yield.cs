using System;

namespace Examples {
  class Program {
    public static void Main(string[] args) {
      // Display powers of 2 up to the exponent of 8:
      foreach (var value in Power(2, 8))
        Console.Write("{0} ", value);
      Console.WriteLine();
    }

    public static System.Collections.Generic.IEnumerable<int> Power(int number, int exponent) {
      int result = 1;

      for (int i = 0; i < exponent; i++) {
        result = result * number;
        yield return result;
      }
    }
  }
}

// This code produces the following output:
//
// 2 4 8 16 32 64 128 256
