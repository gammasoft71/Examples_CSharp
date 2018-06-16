using System;
using System.Drawing;
using System.Windows.Forms;

namespace Examples {
  class Form1 : System.Windows.Forms.Form {
    // Constant value was found in the "windows.h" header file.
    private const int WM_ACTIVATEAPP = 0x001C;

    public static void Main() {
      Application.Run(new Form1());
    }

    Form1() {
      this.label.Bounds = new Rectangle(20, 20, 260, 60);
      this.label.BorderStyle = BorderStyle.Fixed3D;

      this.ClientSize = new System.Drawing.Size(300, 300);
      this.Text = "Form1";
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.0f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
      this.Controls.Add(label);
    }

    protected override void WndProc(ref Message m) {
      // Listen for operating system messages.
      switch (m.Msg) {
        // The WM_ACTIVATEAPP message occurs when the application becomes the active application or becomes inactive.
        case WM_ACTIVATEAPP:
          // The WParam value identifies what is occurring.
          bool appActive = (((int)m.WParam != 0));
          System.Diagnostics.Debug.WriteLine(string.Format("appActive = {0}", appActive));
          this.label.BackColor = appActive ? System.Drawing.Color.LightBlue : System.Drawing.Color.LightGray;
          this.label.ForeColor = appActive ? System.Drawing.SystemColors.ActiveCaptionText : System.Drawing.SystemColors.InactiveCaptionText;
          this.label.Text = appActive ? "Application is active" : "Application is inactive";
          break;
      }
      base.WndProc(ref m);
    }

    private Label label = new Label();
  }
}

