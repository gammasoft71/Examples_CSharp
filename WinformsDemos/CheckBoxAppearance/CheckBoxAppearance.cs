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

      this.labelFlatStyle.Text = "FlatStyle :";
      this.labelFlatStyle.Location = new System.Drawing.Point(10, 105);

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

      this.labelAppearance.Text = "Appearance :";
      this.labelAppearance.Location = new System.Drawing.Point(160, 105);

      this.comboBoxAppearance.Location = new Point(160, 130);
      this.comboBoxAppearance.DropDownStyle = ComboBoxStyle.DropDownList;
      this.comboBoxAppearance.Items.Add("Normal");
      this.comboBoxAppearance.Items.Add("Button");
      this.comboBoxAppearance.SelectedIndex = 0;
      this.comboBoxAppearance.SelectedIndexChanged += delegate {
        this.checkBox1.Appearance = this.checkBox2.Appearance = this.checkBox3.Appearance = this.checkBox4.Appearance = this.checkBox5.Appearance = this.checkBox6.Appearance = (Appearance)Enum.Parse(typeof(Appearance), (string)this.comboBoxAppearance.SelectedItem);
      };

      this.labelBackColor.Text = "BackColor :";
      this.labelBackColor.Location = new System.Drawing.Point(10, 165);

      this.panelBackColor.Location = new System.Drawing.Point(10, 190);
      this.panelBackColor.Size = new System.Drawing.Size(100, 23);
      this.panelBackColor.BorderStyle = BorderStyle.FixedSingle;
      this.panelBackColor.BackColor = this.checkBox1.BackColor;
      this.panelBackColor.Click += delegate {
        ColorDialog colorDialog = new ColorDialog();
        colorDialog.Color = this.panelBackColor.BackColor;
        if (colorDialog.ShowDialog() == DialogResult.OK) {
          this.panelBackColor.BackColor = this.checkBox1.BackColor = this.checkBox2.BackColor = this.checkBox3.BackColor = this.checkBox4.BackColor = this.checkBox5.BackColor = this.checkBox6.BackColor = colorDialog.Color;
        }
      };

      this.labelForeColor.Text = "ForeColor :";
      this.labelForeColor.Location = new System.Drawing.Point(160, 165);

      this.panelForeColor.Location = new System.Drawing.Point(160, 190);
      this.panelForeColor.Size = new System.Drawing.Size(100, 23);
      this.panelForeColor.BorderStyle = BorderStyle.FixedSingle;
      this.panelForeColor.BackColor = this.checkBox1.ForeColor;
      this.panelForeColor.Click += delegate {
        ColorDialog colorDialog = new ColorDialog();
        colorDialog.Color = this.panelBackColor.BackColor;
        if (colorDialog.ShowDialog() == DialogResult.OK) {
          this.panelForeColor.BackColor = this.checkBox1.ForeColor = this.checkBox2.ForeColor = this.checkBox3.ForeColor = this.checkBox4.ForeColor = this.checkBox5.ForeColor = this.checkBox6.ForeColor = colorDialog.Color;
        }
      };

      this.Text = "CheckBox appearance";
      this.Controls.AddRange(new Control[] { this.checkBox1, this.checkBox2, this.checkBox3, this.checkBox4, this.checkBox5, this.checkBox6, this.labelFlatStyle, this.comboBoxFlatStyle, this.labelAppearance, this.comboBoxAppearance, this.labelBackColor, this.panelBackColor, this.labelForeColor, this.panelForeColor });
      this.ClientSize = new Size(300, 230);
    }

    private CheckBox checkBox1 = new CheckBox();
    private CheckBox checkBox2 = new CheckBox();
    private CheckBox checkBox3 = new CheckBox();
    private CheckBox checkBox4 = new CheckBox();
    private CheckBox checkBox5 = new CheckBox();
    private CheckBox checkBox6 = new CheckBox();

    private Label labelFlatStyle = new Label();
    private ComboBox comboBoxFlatStyle = new ComboBox();
    private Label labelAppearance = new Label();
    private ComboBox comboBoxAppearance = new ComboBox();
    private Label labelBackColor = new Label();
    private Panel panelBackColor = new Panel();
    private Label labelForeColor = new Label();
    private Panel panelForeColor = new Panel();
  };
}
