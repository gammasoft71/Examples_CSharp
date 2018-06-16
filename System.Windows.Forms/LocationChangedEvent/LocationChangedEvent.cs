using System;
using System.Windows.Forms;

namespace Examples {
  class MainForm : Form {
    public static void Main() {
      Application.EnableVisualStyles();
      Application.Run(new MainForm());
    }

    public MainForm() {
      this.InitializeComponent();
    }

    private void InitializeComponent() {
      this.SuspendLayout();
      //
      // statusStrip1
      //
      this.statusStrip1.Location = new System.Drawing.Point(0, 251);
      this.statusStrip1.Name = "statusStrip1";
      this.statusStrip1.Size = new System.Drawing.Size(292, 22);
      this.statusStrip1.Text = "statusStrip1";
      this.statusStrip1.LocationChanged += new System.EventHandler(this.statusStrip1_LocationChanged);
      //
      // Form1
      //
      this.ClientSize = new System.Drawing.Size(292, 273);
      this.Controls.Add(this.statusStrip1);
      this.Name = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    private void statusStrip1_LocationChanged(object sender, EventArgs e) {
      MessageBox.Show("The form has been resized.");
    }

    private StatusStrip statusStrip1 = new StatusStrip();
  }
}
