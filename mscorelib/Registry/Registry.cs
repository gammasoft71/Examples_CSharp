using System;

namespace HelloWorld {
  class MainClass {
    public static void WriteKeys() {
      Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("Gammasoft").CreateSubKey("RegistryTest");

      key.SetValue("String", "StringValue");
      key.SetValue("Integer", 42);
      key.SetValue("Guid", Guid.NewGuid());
    }

    public static void ReadKeys() {
      Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Gammasoft").OpenSubKey("RegistryTest");
      Console.WriteLine(key.GetValue("String"));
      Console.WriteLine(key.GetValue("Integer"));
      Console.WriteLine(key.GetValue("Guid"));
    }

    public static void RemoveKeys() {
      Microsoft.Win32.Registry.CurrentUser.DeleteSubKeyTree("Gammasoft");
    }

    public static void Main(string[] args) {
      WriteKeys();
      ReadKeys();
      RemoveKeys();
    }
  }
}

// This code produces the following output:
//
