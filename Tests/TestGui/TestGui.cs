using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Examples {
  class MainForm : Form {
    delegate void Invoker();

    public static void Main() {
      bool close = false;
      Application.EnableVisualStyles();

      Form formMain = new Form();
      formMain.Text = "Test Gui";
      formMain.FormClosed += delegate {
        close = true;
      };

      /*
      MenuItem test = new MenuItem("Test");
      System.Diagnostics.Debug.WriteLine(string.Format("{0}", test));

      MenuItem menuItemFile = new MenuItem("File");
      menuItemFile.MenuItems.Add(test);

      MainMenu mainMenu = new MainMenu();
      mainMenu.MenuItems.Add(menuItemFile);
      System.Diagnostics.Debug.WriteLine(string.Format("{0}", mainMenu));

      formMain.Menu = test.GetMainMenu();
      */

      ListBox listBox = new ListBox();
      listBox.Parent = formMain;
      listBox.Dock = DockStyle.Fill;

      formMain.Show();
      Thread thread = new Thread(delegate (object threadId) {
        int counter = 0;
      while (!close) {
          listBox.Invoke(new Invoker(delegate {
            string str = string.Format("thread: {0}, counter: {1}", threadId, ++counter);
            listBox.Items.Add(str);
            listBox.SelectedIndex = listBox.Items.Count - 1;
            System.Diagnostics.Debug.WriteLine(str);
          }));
          Thread.Yield();
        }
      });
      thread.IsBackground = true;
      thread.Start(0);

      Application.Run(formMain);
    }
  }
}
