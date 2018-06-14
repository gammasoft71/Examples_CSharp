using System;
using System.Drawing;

namespace Program {
  class MainClass {
    public static void PrintColor(Color color) {
      Console.WriteLine("{0} :", color);
      Console.WriteLine("A = {0}", color.A);
      Console.WriteLine("R = {0}", color.R);
      Console.WriteLine("G = {0}", color.G);
      Console.WriteLine("B = {0}", color.B);
      Console.WriteLine("H = {0}", color.GetHue());
      Console.WriteLine("S = {0}", color.GetSaturation());
      Console.WriteLine("V = {0}", color.GetBrightness());
      Console.WriteLine();
    }

    public static double GetBrightness(Color color)
    {
      double r = (float)color.R / 255.0f;
      double g = (float)color.G / 255.0f;
      double b = (float)color.B / 255.0f;

      float max, min;

      max = r; min = r;

      if (g > max) max = g;
      if (b > max) max = b;

      if (g < min) min = g;
      if (b < min) min = b;

      return (max + min) / 2;
    }

    public static void Main(string[] args) {
      PrintColor(Color.Blue);
      PrintColor(Color.DarkBlue);
    }
  }
}

// This code produces the following output:
//
// Hello, World!
