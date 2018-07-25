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
      this.checkBox1.Text = "Unchecked";
      this.checkBox1.Location = new System.Drawing.Point(10, 10);

      this.checkBox2.Text = "Checked";
      this.checkBox2.Location = new System.Drawing.Point(10, 40);
      this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;

      this.checkBox3.Text = "Indeterminate";
      this.checkBox3.Location = new System.Drawing.Point(10, 70);
      this.checkBox3.CheckState = System.Windows.Forms.CheckState.Indeterminate;

      this.checkBox4.Text = "Unchecked";
      this.checkBox4.Location = new System.Drawing.Point(160, 10);
      this.checkBox4.Enabled = false;

      this.checkBox5.Text = "Checked";
      this.checkBox5.Location = new System.Drawing.Point(160, 40);
      this.checkBox5.CheckState = System.Windows.Forms.CheckState.Checked;
      this.checkBox5.Enabled = false;

      this.checkBox6.Text = "Indeterminate";
      this.checkBox6.Location = new System.Drawing.Point(160, 70);
      this.checkBox6.CheckState = System.Windows.Forms.CheckState.Indeterminate;
      this.checkBox6.Enabled = false;

      this.label1.Text = "FlatStyle :";
      this.label1.Location = new System.Drawing.Point(10, 105);

      this.comboBoxFlatStyle.Location = new Point(10, 130);
      this.comboBoxFlatStyle.DropDownStyle = ComboBoxStyle.DropDownList;
      this.comboBoxFlatStyle.Items.Add("Standard");
      this.comboBoxFlatStyle.Items.Add("Flat");
      this.comboBoxFlatStyle.Items.Add("Popup");
      this.comboBoxFlatStyle.Items.Add("System");
      this.comboBoxFlatStyle.SelectedIndex = 0;
      this.comboBoxFlatStyle.SelectedIndexChanged += delegate {
        this.checkBox1.FlatStyle = this.checkBox2.FlatStyle = this.checkBox3.FlatStyle = this.checkBox4.FlatStyle = this.checkBox5.FlatStyle = this.checkBox6.FlatStyle = (FlatStyle)Enum.Parse(typeof(FlatStyle), (string)this.comboBoxFlatStyle.SelectedItem);
      };

      this.label2.Text = "Appearance :";
      this.label2.Location = new System.Drawing.Point(160, 105);

      this.comboBoxAppearance.Location = new Point(160, 130);
      this.comboBoxAppearance.DropDownStyle = ComboBoxStyle.DropDownList;
      this.comboBoxAppearance.Items.Add("Normal");
      this.comboBoxAppearance.Items.Add("Button");
      this.comboBoxAppearance.SelectedIndex = 0;
      this.comboBoxAppearance.SelectedIndexChanged += delegate {
        this.checkBox1.Appearance = this.checkBox2.Appearance = this.checkBox3.Appearance = this.checkBox4.Appearance = this.checkBox5.Appearance = this.checkBox6.Appearance = (Appearance)Enum.Parse(typeof(Appearance), (string)this.comboBoxAppearance.SelectedItem);
      };

      this.Text = "CheckBox demo";
      this.Controls.AddRange(new Control[] { this.checkBox1, this.checkBox2, this.checkBox3, this.checkBox4, this.checkBox5, this.checkBox6, this.label1, this.comboBoxFlatStyle, this.label2, this.comboBoxAppearance });
      this.ClientSize = new Size(300, 170);
    }

    private CheckBox checkBox1 = new CheckBox();
    private CheckBox checkBox2 = new CheckBox();
    private CheckBox checkBox3 = new CheckBox();
    private CheckBox checkBox4 = new CheckBox();
    private CheckBox checkBox5 = new CheckBox();
    private CheckBox checkBox6 = new CheckBox();

    private Label label1 = new Label();
    private ComboBox comboBoxFlatStyle = new ComboBox();
    private Label label2 = new Label();
    private ComboBox comboBoxAppearance = new ComboBox();
  };
}
