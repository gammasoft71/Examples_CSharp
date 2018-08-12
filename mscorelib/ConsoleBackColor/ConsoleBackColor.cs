using System;

namespace Examples {
  class Program {
    public static void Main(string[] args) {
      WriteCharacterStrings(1, 26, true);
      Console.MoveBufferArea(0, Console.CursorTop - 10, 30, 1, Console.CursorLeft, Console.CursorTop + 1);
      Console.CursorTop = Console.CursorTop + 3;
      Console.WriteLine("Press any key...");
      Console.ReadKey();

      Console.ResetColor();
      Console.Clear();
      WriteCharacterStrings(1, 26, false);
    }

    private static void WriteCharacterStrings(int start, int end, bool changeColor) {
      for (int ctr = start; ctr <= end; ctr++) {
        if (changeColor)
          Console.BackgroundColor = (ConsoleColor)((ctr - 1) % 16);

        Console.WriteLine(new string(Convert.ToChar(ctr + 64), 30));
      }
    }
  }
}


// This code produces the following output:
//
// BBBBBBBBBBBBBBBBBBBBBBBBBBBBBB
// CCCCCCCCCCCCCCCCCCCCCCCCCCCCCC
// DDDDDDDDDDDDDDDDDDDDDDDDDDDDDD
// EEEEEEEEEEEEEEEEEEEEEEEEEEEEEE
// FFFFFFFFFFFFFFFFFFFFFFFFFFFFFF
// GGGGGGGGGGGGGGGGGGGGGGGGGGGGGG
// HHHHHHHHHHHHHHHHHHHHHHHHHHHHHH
// IIIIIIIIIIIIIIIIIIIIIIIIIIIIII
// JJJJJJJJJJJJJJJJJJJJJJJJJJJJJJ
// KKKKKKKKKKKKKKKKKKKKKKKKKKKKKK
// LLLLLLLLLLLLLLLLLLLLLLLLLLLLLL
// MMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
// NNNNNNNNNNNNNNNNNNNNNNNNNNNNNN
// OOOOOOOOOOOOOOOOOOOOOOOOOOOOOO
// PPPPPPPPPPPPPPPPPPPPPPPPPPPPPP
// QQQQQQQQQQQQQQQQQQQQQQQQQQQQQQ
// RRRRRRRRRRRRRRRRRRRRRRRRRRRRRR
// SSSSSSSSSSSSSSSSSSSSSSSSSSSSSS
// TTTTTTTTTTTTTTTTTTTTTTTTTTTTTT
// UUUUUUUUUUUUUUUUUUUUUUUUUUUUUU
// VVVVVVVVVVVVVVVVVVVVVVVVVVVVVV
// WWWWWWWWWWWWWWWWWWWWWWWWWWWWWW
// XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
// YYYYYYYYYYYYYYYYYYYYYYYYYYYYYY
// ZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZ
