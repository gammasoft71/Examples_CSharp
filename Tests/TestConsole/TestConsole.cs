using System;
using System.Drawing;

namespace TestConsole {
  class MainClass {
    public static void Main(string[] args) {
      Bitmap bmp = new Bitmap(32, 32);

      for (int y = 0; y < bmp.Height; y++)
        for (int x = 0; x < bmp.Width; x++)
          if (bmp.GetPixel(x, y)!= Color.FromArgb(0, 0, 0, 0))
            System.Diagnostics.Debug.WriteLine(string.Format("x = {0}, y = {1}, color = {2,-34}", x, y, bmp.GetPixel(x, y)));

      /*
      //Console.WriteLine("Hello World!");
      Console.WriteLine("p1 = {0}", new Point());
      Console.WriteLine("p2 = {0}", new Point(10, 20));
      Console.WriteLine("p3 = {0}", new Point(0x0014000A));

      Console.WriteLine("c1 = {0}", Color.FromKnownColor(KnownColor.DarkBlue));
      Console.WriteLine("c1 = {0}", Color.FromName("DarkBlue"));
      Console.WriteLine("c1 = {0}", Color.FromName("dark blue").Name);
      Console.WriteLine("c1 = {0:X8}", Color.FromName("Transparent").ToArgb());
      Console.WriteLine("c1 = {0}", Color.FromName("dark blue").IsEmpty);
      */
    }
  }
}

// This code produces the following output:
//
// Hello, World!
