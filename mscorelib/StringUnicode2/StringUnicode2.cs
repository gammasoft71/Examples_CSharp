using System;

namespace Examples {
  class MainClass {
    public static void Main(string[] args) {
      string str = "\u65E5\u672C\u8A9E\u306E\u3072\u3089\u304C\u306A\u002C\u0020\u6F22\u5B57\u3068\u30AB\u30BF\u30AB\u30CA\U0001F428\u0021";

      Console.OutputEncoding = System.Text.Encoding.UTF8;
      Console.WriteLine(string.Join(" ", str));

      // Remarks : the koala character (\U0001F428) is splitted into two utf16...
      string result = "";
      foreach (var c in str)
        result += string.Format("\\u{0:X4}", (int)c);
      Console.WriteLine(result);

    }
  }
}

// This code produces the following output on Windows:
//
// ? ? ? ? ? ? ? ? ,   ? ? ? ? ? ? ? ? !
// \u65E5\u672C\u8A9E\u306E\u3072\u3089\u304C\u306A\u002C\u0020\u6F22\u5B57\u3068\u30AB\u30BF\u30AB\u30CA\uD83D\uDC28\u0021

// Or the following output on utf8 console (macOS or linux):
//
// 日 本 語 の ひ ら が な ,   漢 字 と カ タ カ ナ 🐨 !
// \u65E5\u672C\u8A9E\u306E\u3072\u3089\u304C\u306A\u002C\u0020\u6F22\u5B57\u3068\u30AB\u30BF\u30AB\u30CA\uD83D\uDC28\u0021
