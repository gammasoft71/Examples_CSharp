using System;

namespace Examples {
  class Program {
    // The main entry point for the application.
    public static void Main() {
      // Creates and initializes a new Array.
      string[] myArray = new string[10];

      myArray[0] = "The";
      myArray[1] = "quick";
      myArray[2] = "brown";
      myArray[3] = "fox";
      myArray[4] = "jumped";
      myArray[5] = "over";
      myArray[6] = "the";
      myArray[7] = "lazy";
      myArray[8] = "dog";

      // Displays the values of the Array.
      Console.WriteLine("The Array contains the following values:");
      for (int index = 0; index < myArray.Length; index++)
        Console.WriteLine("[{0}] {1}", index, myArray[index]);
    }
  }
}

// This code produces the following output:
//
// The Array contains the following values:
// [0] The
// [1] quick
// [2] brown
// [3] fox
// [4] jumped
// [5] over
// [6] the
// [7] lazy
// [8] dog
// [9]
