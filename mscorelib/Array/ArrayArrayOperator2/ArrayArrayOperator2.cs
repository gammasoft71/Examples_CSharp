using System;

namespace Examples {
  class Program {
    // The main entry point for the application.
    public static void Main() {
      // Creates and initializes a new Array.
      string[,] myArray = new string[2, 5];

      myArray[0, 0] = "The";
      myArray[0, 1] = "quick";
      myArray[0, 2] = "brown";
      myArray[0, 3] = "fox";
      myArray[0, 4] = "jumped";
      myArray[1, 0] = "over";
      myArray[1, 1] = "the";
      myArray[1, 2] = "lazy";
      myArray[1, 3] = "dog";

      // Displays the values of the Array.
      Console.WriteLine("The Array contains the following values:");
      for (int index1 = 0; index1 < myArray.GetLength(0); index1++)
        for (int index2 = 0; index2 < myArray.GetLength(1); index2++)
          Console.WriteLine("({0}, {1}) {2}", index1, index2, myArray[index1, index2]);
    }
  }
}

// This code produces the following output:
//
// The Array contains the following values:
// (0, 0) The
// (0, 1) quick
// (0, 2) brown
// (0, 3) fox
// (0, 4) jumped
// (1, 0) over
// (1, 1) the
// (1, 2) lazy
// (1, 3) dog
// (1, 4)
