using System;
using System.Windows.Forms;

namespace Examples {
  public class Form1 : Form {
    // The main entry point for the application.
    public static void Main() {
      Application.EnableVisualStyles();
      Application.Run(new Form1());
    }

    public Form1() {
      this.mainMenu.MenuItems.Add("File");
      this.mainMenu.MenuItems.Add("Edit");
      this.mainMenu.MenuItems[0].MenuItems.Add(new MenuItem("New", delegate { System.Diagnostics.Debug.WriteLine("MainMenu/File/New"); }, Shortcut.CtrlN));
      this.mainMenu.MenuItems[0].MenuItems.Add(new MenuItem("Open", delegate { System.Diagnostics.Debug.WriteLine("MainMenu/File/Open"); }, Shortcut.CtrlO));
      this.mainMenu.MenuItems[0].MenuItems.Add(new MenuItem("Close", delegate { System.Diagnostics.Debug.WriteLine("MainMenu/File/Close"); }, Shortcut.CtrlW));
      this.mainMenu.MenuItems[0].MenuItems.Add(new MenuItem("-"));
      this.mainMenu.MenuItems[0].MenuItems.Add(new MenuItem("Quit", delegate { System.Diagnostics.Debug.WriteLine("MainMenu/File/Close"); }, Environment.OSVersion.Platform >= PlatformID.Unix ? Shortcut.CtrlQ : Shortcut.AltF4));
      this.mainMenu.MenuItems[1].MenuItems.Add(new MenuItem("Cut", delegate { System.Diagnostics.Debug.WriteLine("MainMenu/Edit/Cut"); }, Shortcut.CtrlX));
      this.mainMenu.MenuItems[1].MenuItems.Add(new MenuItem("Copy", delegate { System.Diagnostics.Debug.WriteLine("MainMenu/Edit/Copy"); }, Shortcut.CtrlC));
      this.mainMenu.MenuItems[1].MenuItems.Add(new MenuItem("Paste", delegate { System.Diagnostics.Debug.WriteLine("MainMenu/Edit/Paste"); }, Shortcut.CtrlV));
      this.mainMenu.MenuItems[1].MenuItems.Add("-");
      this.mainMenu.MenuItems[1].MenuItems.Add(new MenuItem("Select All", delegate { System.Diagnostics.Debug.WriteLine("MainMenu/Edit/SelectAll"); }, Shortcut.CtrlA));
      this.Menu = this.mainMenu;
    }

    MainMenu mainMenu = new MainMenu();
  }
}
