using System;

namespace Examples {
  class Program {
    public static void Main(string[] args) {
      Console.OutputEncoding = System.Text.Encoding.UTF8;
 
      // Create a Char array for the modern Cyrillic alphabet, from U+0410 to U+044F.
      int nChars = 0x044F - 0x0410 + 1;
      char[] chars = new char[nChars];
      ushort codePoint = 0x0410;
      for (int ctr = 0; ctr < chars.Length; ctr++) {
        chars[ctr] = Convert.ToChar(codePoint);
        codePoint++;
      }

      Console.WriteLine("Current code page: {0}\n", Console.OutputEncoding.CodePage);
      // Display the characters.
      foreach (var ch in chars) {
        Console.Write("{0}  ", ch);
        if (Console.CursorLeft >= 70)
          Console.WriteLine();
      }
    }
  }
}

// The example displays the following output:
//
// Current code page: 65001
//
// А  Б  В  Г  Д  Е  Ж  З  И  Й  К  Л  М  Н  О  П  Р  С  Т  У  Ф  Х  Ц  Ч
// Ш  Щ  Ъ  Ы  Ь  Э  Ю  Я  а  б  в  г  д  е  ж  з  и  й  к  л  м  н  о  п
// р  с  т  у  ф  х  ц  ч  ш  щ  ъ  ы  ь  э  ю  я
