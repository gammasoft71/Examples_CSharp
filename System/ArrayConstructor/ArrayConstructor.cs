using System;

namespace Examples {
  class Program {
    // The main entry point for the application.
    public static void Main() {
      // make a single dimension array
      int[] myArray1 = new int[5];

      // make a 3 dimensional array
      int[,,] myArray2 = new int[5, 3, 2];

      // make an array with initialiser list
      int[] myArray3 = { 10, 20, 30, 40, 50, 60, 70 };

      int index = 0;
      // show the array values
      Console.WriteLine("The Array contains the following values:");
      foreach (int value in myArray3)
        Console.WriteLine("[{0}] {1}", index++, value);
    }
  }
}

// This code produces the following output:
//
// The Array contains the following values:
// [0] 10
// [1] 20
// [2] 30
// [3] 40
// [4] 50
// [5] 60
// [6] 70
