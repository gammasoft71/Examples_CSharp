using System;
using System.Threading;
using System.Windows.Forms;

namespace Examples {
  class Program {
    delegate void Invoker();

    public static void Main() {
      Application.EnableVisualStyles();

      bool closed = false;

      Form formMain = new Form();
      formMain.Text = "Form and thread example";
      formMain.FormClosed += delegate {
        closed = true;
      };

      ListBox listBox = new ListBox();
      listBox.Parent = formMain;
      listBox.Dock = DockStyle.Fill;

      formMain.Show();

      Thread[] threads = new Thread[Environment.ProcessorCount];
      for (int index = 0; index < threads.Length; index++) {
        threads[index] = new Thread(new ParameterizedThreadStart(delegate (object user_thread_id) {
          int counter = 0;
          while(!closed) {
            Thread.Sleep(50);
            listBox.BeginInvoke(new Invoker(delegate {
              listBox.Items.Add(string.Format("thread: {0}, counter: {1}", user_thread_id, ++counter));
              listBox.SelectedIndex = listBox.Items.Count - 1;
            }));
          }
        }));
        threads[index].Start(index);
      }

      Application.Run(formMain);

      for (int index = 0; index < threads.Length; index++)
        threads[index].Join();
    }
  }
}
