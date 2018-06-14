using System;
using System.Drawing;
using System.Windows.Forms;

namespace MouseEvent {
  public class Form1 : Form {
    // The main entry point for the application.
    public static void Main() {
      Application.EnableVisualStyles();
      Application.Run(new Form1());
    }

    public Form1() {
      this.mainMenu.MenuItems.Add("File");
      this.mainMenu.MenuItems.Add("Edit");
      this.mainMenu.MenuItems[0].MenuItems.Add("New");
      this.mainMenu.MenuItems[0].MenuItems.Add("Open");
      this.mainMenu.MenuItems[0].MenuItems.Add("Close");
      this.mainMenu.MenuItems[0].MenuItems.Add("-");
      this.mainMenu.MenuItems[0].MenuItems.Add("Quit");
      this.mainMenu.MenuItems[1].MenuItems.Add("Cut");
      this.mainMenu.MenuItems[1].MenuItems.Add("Copy");
      this.mainMenu.MenuItems[1].MenuItems.Add("Paste");
      this.mainMenu.MenuItems[1].MenuItems.Add("-");
      this.mainMenu.MenuItems[1].MenuItems.Add("Select all");
      this.Menu = this.mainMenu;

      this.mainMenu.MenuItems[0].MenuItems[4].Click += delegate {
        this.Close();
      };
    }

    MainMenu mainMenu = new MainMenu();
  }
}
