using System;
using System.Windows.Forms;

namespace Examples {
  class Form1 : Form {
    public static void Main() {
      Application.Run(new Form1());
    }

    Form1() {
      Application.Idle += this.OnApplicationIdle;
    }

    private void OnApplicationIdle(object sender, EventArgs e) {
      this.Text = string.Format("{0}", ++this.counter);
    }

    private int counter = 0;
  }
}
