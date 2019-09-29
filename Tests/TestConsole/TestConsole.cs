using System;
using System.Drawing;

namespace TestConsole {
  class MainClass {
    public static void Main(string[] args) {
      //Console.WriteLine("Hello World!");
      Console.WriteLine("p1 = {0}", new Point());
      Console.WriteLine("p2 = {0}", new Point(10, 20));
      Console.WriteLine("p3 = {0}", new Point(0x0014000A));

      Console.WriteLine("c1 = {0}", Color.FromKnownColor(KnownColor.DarkBlue));
      Console.WriteLine("c1 = {0}", Color.FromName("DarkBlue"));
      Console.WriteLine("c1 = {0}", Color.FromName("dark blue").Name);
      Console.WriteLine("c1 = {0:X8}", Color.FromName("Transparent").ToArgb());
      Console.WriteLine("c1 = {0}", Color.FromName("dark blue").IsEmpty);
    }
  }
}

// This code produces the following output:
//
// Hello, World!
