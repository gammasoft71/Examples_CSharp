using System;
using System.Windows.Forms;

namespace Examples {
  class Program {
    public static void Main() {
      System.Drawing.Rectangle area = Screen.PrimaryScreen.WorkingArea;

      Form form1 = new Form();
      form1.StartPosition = FormStartPosition.Manual;
      form1.Location = area.Location;
      form1.Size = new System.Drawing.Size(area.Size.Width / 2, area.Size.Height / 2);
      form1.Text = "screen 1/4";
      form1.Visible = true;

      Form form2 = new Form();
      form2.StartPosition = FormStartPosition.Manual;
      form2.Location = new System.Drawing.Point(area.Location.X + area.Size.Width / 2, area.Location.Y);
      form2.Size = new System.Drawing.Size(area.Size.Width / 2, area.Size.Height / 2);
      form2.Text = "screen 2/4";
      form2.Visible = true;

      Form form3 = new Form();
      form3.StartPosition = FormStartPosition.Manual;
      form3.Location = new System.Drawing.Point(area.Location.X, area.Location.Y + area.Size.Height / 2);
      form3.Size = new System.Drawing.Size(area.Size.Width / 2, area.Size.Height / 2);
      form3.Text = "screen 3/4";
      form3.Visible = true;

      Form form4 = new Form();
      form4.StartPosition = FormStartPosition.Manual;
      form4.Location = new System.Drawing.Point(area.Location.X + area.Size.Width / 2, area.Location.Y + area.Size.Height / 2);
      form4.Size = new System.Drawing.Size(area.Size.Width / 2, area.Size.Height / 2);
      form4.Text = "screen 4/4";
      form4.Visible = true;

      Application.EnableVisualStyles();
      Application.Run(form1);
    }
  }
}
