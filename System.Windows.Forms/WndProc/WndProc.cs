using System;
using System.Drawing;
using System.Windows.Forms;

namespace Examples {
  class Form1 : System.Windows.Forms.Form {
    // Constant value was found in the "windows.h" header file.
    private const int WM_ACTIVATEAPP = 0x001C;
    private bool appActive = true;

    public static void Main() {
      Application.Run(new Form1());
    }

    Form1() {
      this.ClientSize = new System.Drawing.Size(300, 300);
      this.Text = "Form1";
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.0f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
    }

    protected override void OnPaint(PaintEventArgs e) {
      // Paint a string in different styles depending on whether the application is active.
      if (appActive) {
        e.Graphics.FillRectangle(SystemBrushes.MenuHighlight, 20, 20, 260, 50);
        e.Graphics.DrawString("Application is active", this.Font, SystemBrushes.ControlText, 20, 20);
      } else {
        e.Graphics.FillRectangle(SystemBrushes.Control, 20, 20, 260, 50);
        e.Graphics.DrawString("Application is Inactive", this.Font, SystemBrushes.ControlText, 20, 20);
      }
    }

    protected override void WndProc(ref Message m) {
      // Listen for operating system messages.
      switch (m.Msg) {
        // The WM_ACTIVATEAPP message occurs when the application becomes the active application or becomes inactive.
        case WM_ACTIVATEAPP:
          // The WParam value identifies what is occurring.
          appActive = (((int)m.WParam != 0));
          // Invalidate to get new text painted.
          this.Invalidate();
          break;
      }
      base.WndProc(ref m);
    }
  }
}

