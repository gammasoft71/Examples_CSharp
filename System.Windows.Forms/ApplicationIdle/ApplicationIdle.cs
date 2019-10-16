using System;
using System.Windows.Forms;

namespace Examples {
  class Form1 : Form {
    public static void Main() {
      Application.Run(new Form1());
    }

    Form1() {
      Application.Idle += OnApplicationIdle;
    }

    private void OnApplicationIdle(object sender, EventArgs e) {
      Text = string.Format("{0}", ++counter);
    }

    private int counter = 0;
  }
}
