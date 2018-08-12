using System;
using System.Drawing;
using System.Windows.Forms;

namespace Examples {
  class Form1 : Form {
    // The main entry point for the application.
    public static void Main() {
      Application.EnableVisualStyles();
      Application.Run(new Form1());
    }

    public Form1() {
      this.company.Text = "Company name";
      this.company.Location = new Point(10, 12);

      this.product.Text = "Product name";
      this.product.Location = new Point(10, 42);

      this.version.Text = "Product version";
      this.version.Location = new Point(10, 72);

      this.companyName.Text = Application.CompanyName;
      this.companyName.BorderStyle = BorderStyle.Fixed3D;
      this.companyName.BackColor = System.Drawing.Color.White;
      this.companyName.ForeColor = System.Drawing.Color.Black;
      this.companyName.Location = new Point(120, 10);
      this.companyName.Width = 170;

      this.productName.Text = Application.ProductName;
      this.productName.BorderStyle = BorderStyle.Fixed3D;
      this.productName.BackColor = System.Drawing.Color.White;
      this.productName.ForeColor = System.Drawing.Color.Black;
      this.productName.Location = new Point(120, 40);
      this.productName.Width = 170;

      this.productVersion.Text = Application.ProductVersion;
      this.productVersion.BorderStyle = BorderStyle.Fixed3D;
      this.productVersion.BackColor = System.Drawing.Color.White;
      this.productVersion.ForeColor = System.Drawing.Color.Black;
      this.productVersion.Location = new Point(120, 70);
      this.productVersion.Width = 170;

      this.Text = "Form with assembly info";
      this.Controls.AddRange(new Control[] { this.company, this.product, this.version, this.companyName, this.productName, this.productVersion });
      this.ClientSize = new System.Drawing.Size(300, 105);
    }

    private Label company = new Label();
    private Label product = new Label();
    private Label version = new Label();

    private Label companyName = new Label();
    private Label productName = new Label();
    private Label productVersion = new Label();
  };
}
