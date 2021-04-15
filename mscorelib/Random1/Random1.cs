using System;

namespace HelloWorld {
  class MainClass {
    public static void Main(string[] args) {
      byte[] bytes1 = new byte[100];
      byte[] bytes2 = new byte[100];
      Random rnd1 = new Random();
      Random rnd2 = new Random();

      rnd1.NextBytes(bytes1);
      rnd2.NextBytes(bytes2);

      Console.WriteLine("First Series:");
      for (int i = 0; i < bytes1.Length; i++) {
        Console.Write("{0, 5}", bytes1[i]);
        if ((i + 1) % 10 == 0)
          Console.WriteLine();
      }

      Console.WriteLine();
      Console.WriteLine("Second Series:");
      for (int i = 0; i < bytes2.Length; i++) {
        Console.Write("{0, 5}", bytes2[i]);
        if ((i + 1) % 10 == 0)
          Console.WriteLine();
      }
      Console.ReadKey();
    }
  }
}

// This code can produces the following output:
//
// First Series:
//   225   31    4   93   69  189   82  100  198   36
//   249  218   12   43  179    6  129  187  189   40
//    45  243  233   31   98  119   31   92  204   37
//   148   18  239   51  152  181  146   93  133   31
//    74    8   26  172  108  224  160  221   86   25
//   100  149   53  112  153  237   53  229  250  206
//   157  246  152  161  144  230  235  217  147  254
//   116   36   53  157  222   36  217   61  178  130
//   214   66    5  179  192  255  221  127  153  170
//   127  172   99  183  130   83  112  121   27  133
// 
// Second Series:
//   225   31    4   93   69  189   82  100  198   36
//   249  218   12   43  179    6  129  187  189   40
//    45  243  233   31   98  119   31   92  204   37
//   148   18  239   51  152  181  146   93  133   31
//    74    8   26  172  108  224  160  221   86   25
//   100  149   53  112  153  237   53  229  250  206
//   157  246  152  161  144  230  235  217  147  254
//   116   36   53  157  222   36  217   61  178  130
//   214   66    5  179  192  255  221  127  153  170
//   127  172   99  183  130   83  112  121   27  133
