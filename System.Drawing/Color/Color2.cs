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
      Console.WriteLine("V2 = {0}", GetBrightness(color));
      Console.WriteLine();
    }

    public static float GetBrightness(Color color) {
      return (float)Math.Max(Math.Max(color.R, color.G), color.B) / 255.0f;
    }

    public static void Main(string[] args) {
      PrintColor(Color.FromArgb(Color.Blue.A, Color.Blue.R, Color.Blue.G, Color.Blue.B));
      PrintColor(Color.DarkBlue);
    }
  }
}

// This code produces the following output:
//
// Hello, World!
