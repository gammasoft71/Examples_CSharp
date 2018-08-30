using System;
using System.IO;
using System.Drawing;

namespace Examples {
  class Program {
    public static void Main(string[] args) {
      Bitmap bitmap = new Bitmap(Examples.Properties.Resources.Gammasoft);

      Console.WriteLine("HorizontalResolution = {0}", bitmap.HorizontalResolution);
      Console.WriteLine("VerticalResolution = {0}", bitmap.VerticalResolution);
      Console.WriteLine("PhysicalDimension = {0}", bitmap.PhysicalDimension);
      Console.WriteLine("PixelFormat = {0}", bitmap.PixelFormat);
      Console.WriteLine("RawFormat = {0}", bitmap.RawFormat);
      Console.WriteLine("Flags = {0}", bitmap.Flags);
      Console.WriteLine("Size = {0}", bitmap.Size);
    }
  }
}

// This code produces the following output:
//
// HorizontalResolution = 96
// VerticalResolution = 96
// PhysicalDimension = {Width=256, Height=256}
// PixelFormat = Format32bppArgb
// RawFormat = [ImageFormat: b96b3caa-0728-11d3-9d7b-0000f81ef32e]
// Flags = 2
// Size = {Width=256, Height=256}
