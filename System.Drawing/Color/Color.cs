using System;
using System.Drawing;

namespace Examples {
  class MainClass {
    public static void Main(string[] args) {
      Console.WriteLine("Color.Black = {0}", Color.Black);
      Console.WriteLine("Color.Withe = {0}", Color.White);
      Console.WriteLine("Color.Blue = {0}", Color.Blue);
      Console.WriteLine("Color.LightGreen = {0}", Color.LightGreen);
      Console.WriteLine("Color.FromArgb(255, 253, 2, 0) = {0}", Color.FromArgb(255, 253, 2, 0));
      Console.WriteLine("Color.FromName(\"DodgerBlue\") = {0}", Color.FromName("DodgerBlue"));
    }
  }
}

// This code produces the following output:
//
// Color.Black = Color [Black]
// Color.Withe = Color [White]
// Color.Blue = Color [Blue]
// Color.LightGreen = Color [LightGreen]
// Color.FromArgb(255, 253, 2, 0) = Color [A=255, R=253, G=2, B=0]
// Color.FromName("DodgerBlue") = Color [DodgerBlue]
