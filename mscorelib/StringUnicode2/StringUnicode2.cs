using System;

namespace Examples {
  class MainClass {
    public static void Main(string[] args) {
      Console.OutputEncoding = System.Text.Encoding.UTF8;
      Console.WriteLine(string.Join(" ", "\u65E5\u672C\u8A9E\u306E\u3072\u3089\u304C\u306A, \u6F22\u5B57\u3068\u30AB\u30BF\u30AB\u30CA\U0001F428"));
    }
  }
}

// This code produces the following output:
//
// 日 本 語 の ひ ら が な ,   漢 字 と カ タ カ ナ ? ?
