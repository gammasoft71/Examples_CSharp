using System;
using System.Windows.Forms;

namespace Examples {
  class NumericTextBox : TextBox {
    public NumericTextBox() {
      KeyPress += delegate (object sender, KeyPressEventArgs e) {
        e.Handled = (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.') || (e.KeyChar == '.' && base.Text.IndexOf('.') != -1);
      };
    }

    public double Value {
      get {
        double result = 0;
        double.TryParse(base.Text.Replace(".", System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator), out result);
        return result;
      }
      set { base.Text = value.ToString(); }
    }

    public override string Text {
      get { return ""; }
      set { }
    }

    protected override void OnTextChanged(EventArgs e) {
      base.OnTextChanged(e);
      OnValueChanged(e);
    }

    protected void OnValueChanged(EventArgs e) {
      if (ValueChanged != null) ValueChanged(this, EventArgs.Empty);
    }

    public event EventHandler ValueChanged;
  }

  class MainForm : Form {
    public static void Main() {
      Application.EnableVisualStyles();
      Application.Run(new MainForm());
    }

    public MainForm() {
      Text = "NumericTextBox example";

      numericTextBox1.Parent = this;
      numericTextBox1.Value = 42;
      numericTextBox1.Location = new System.Drawing.Point(10, 10);
      numericTextBox1.ValueChanged += delegate {
        System.Diagnostics.Debug.WriteLine(string.Format("ValueChange [Value={0}]", numericTextBox1.Value));
      };
    }

    private NumericTextBox numericTextBox1 = new NumericTextBox();
  }
}
