using System;
using System.Drawing;
using System.Windows.Forms;

namespace Examples {
  class Program {
    public static void Main() {
      Application.EnableVisualStyles();

      Form form = new Form();
      //form.BackColor = Color.DodgerBlue;
      //form.ForeColor = Color.Yellow;
      System.Diagnostics.Debug.WriteLine(string.Format("form.BackColor = {0}", form.BackColor));
      System.Diagnostics.Debug.WriteLine(string.Format("form.ForeColor = {0}", form.ForeColor));
      System.Diagnostics.Debug.WriteLine(string.Format("form.Size = {0}", form.Size));

      Panel panel1 = new Panel();
      panel1.Parent = form;
      panel1.Location = new Point(10, 10);
      System.Diagnostics.Debug.WriteLine(string.Format("panel1.BackColor = {0}", panel1.BackColor));
      System.Diagnostics.Debug.WriteLine(string.Format("panel1.ForeColor = {0}", panel1.ForeColor));
      System.Diagnostics.Debug.WriteLine(string.Format("panel1.Size = {0}", panel1.Size));

      RadioButton radioButton1 = new RadioButton();
      radioButton1.Parent = panel1;
      radioButton1.Location = new Point(30, 10);
      radioButton1.Text = "unchecked";
      System.Diagnostics.Debug.WriteLine(string.Format("radioButton1.BackColor = {0}", radioButton1.BackColor));
      System.Diagnostics.Debug.WriteLine(string.Format("radioButton1.ForeColor = {0}", radioButton1.ForeColor));
      System.Diagnostics.Debug.WriteLine(string.Format("radioButton1.Size = {0}", radioButton1.Size));

      RadioButton radioButton2 = new RadioButton();
      radioButton2.Parent = panel1;
      radioButton2.Location = new Point(30, 40);
      radioButton2.Checked = true;
      radioButton2.Text = "checked";
      radioButton2.CheckedChanged += delegate {
        System.Diagnostics.Debug.WriteLine(string.Format("radioButton2.Checked = {0}", radioButton2.Checked));
      };
      System.Diagnostics.Debug.WriteLine(string.Format("radioButton2.BackColor = {0}", radioButton2.BackColor));
      System.Diagnostics.Debug.WriteLine(string.Format("radioButton2.ForeColor = {0}", radioButton2.ForeColor));
      System.Diagnostics.Debug.WriteLine(string.Format("radioButton2.Size = {0}", radioButton2.Size));

      Application.Run(form);
    }
  }
}
