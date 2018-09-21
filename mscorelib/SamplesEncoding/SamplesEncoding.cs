using System;
using System.Text;

namespace Examples {
  class SamplesEncoding {
    public static void Main() {
      // The characters to encode:
      //    Latin Small Letter Z (U+007A)
      //    Latin Small Letter A (U+0061)
      //    Combining Breve (U+0306)
      //    Latin Small Letter AE With Acute (U+01FD)
      //    Greek Small Letter Beta (U+03B2)
      //    a high-surrogate value (U+D8FF)
      //    a low-surrogate value (U+DCFF)
      char[] myChars = new char[] { 'z', 'a', '\u0306', '\u01FD', '\u03B2', '\uD8FF', '\uDCFF' };

      // Get different encodings.
      Encoding u7 = Encoding.UTF7;
      Encoding u8 = Encoding.UTF8;
      Encoding u16LE = Encoding.Unicode;
      Encoding u16BE = Encoding.BigEndianUnicode;
      Encoding u32 = Encoding.UTF32;

      // Encode the entire array, and print out the counts and the resulting bytes.
      PrintCountsAndBytes(myChars, u7);
      PrintCountsAndBytes(myChars, u8);
      PrintCountsAndBytes(myChars, u16LE);
      PrintCountsAndBytes(myChars, u16BE);
      PrintCountsAndBytes(myChars, u32);
    }

    public static void PrintCountsAndBytes(char[] chars, Encoding enc) {
      // Display the name of the encoding used.
      Console.Write("{0,-30} :", enc.ToString());

      // Display the exact byte count.
      int iBC = enc.GetByteCount(chars);
      Console.Write(" {0,-3}", iBC);

      // Display the maximum byte count.
      int iMBC = enc.GetMaxByteCount(chars.Length);
      Console.Write(" {0,-3} :", iMBC);

      // Encode the array of chars.
      byte[] bytes = enc.GetBytes(chars);

      // Display all the encoded bytes.
      PrintHexBytes(bytes);
    }

    public static void PrintHexBytes(byte[] bytes) {
      if ((bytes == null) || (bytes.Length == 0))
        Console.WriteLine("<none>");
      else {
        for (int i = 0; i < bytes.Length; i++)
          Console.Write("{0:X2} ", bytes[i]);
        Console.WriteLine();
      }
    }
  }
}

// This code produces the following output:
//
// Hello, World!
