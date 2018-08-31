using System;
using System.Windows.Forms;

namespace Examples {
  class MainForm : Form {
    public static void Main() {
      Application.EnableVisualStyles();
      Application.Run(new MainForm());
    }

    public MainForm() {
      this.Text = "Colors example";
      this.StartPosition = FormStartPosition.Manual;
      this.Location = new System.Drawing.Point(300, 200);
      this.ClientSize = new System.Drawing.Size(640, 420);

      this.panelKnownColors.Parent = this;
      this.panelKnownColors.Location = new System.Drawing.Point(10, 10);
      this.panelKnownColors.Size = new System.Drawing.Size(300, 400);
      this.panelKnownColors.BorderStyle = BorderStyle.Fixed3D;
      this.panelKnownColors.AutoScroll = true;

      int index = 0;
      foreach (System.Drawing.KnownColor knownColor in Enum.GetValues(typeof(System.Drawing.KnownColor))) {
        Panel panelKnownColor = new Panel();
        panelKnownColor.Parent = this.panelKnownColors;
        panelKnownColor.Bounds = new System.Drawing.Rectangle(10, index * 30, 100, 30);
        panelKnownColor.BackColor = System.Drawing.Color.FromKnownColor(knownColor);
        panelKnownColor.Click += this.OnKnownColorClick;

        Label labelKnownColorName =new Label();
        labelKnownColorName.Parent = this.panelKnownColors;
        labelKnownColorName.AutoSize = true;
        labelKnownColorName.Location = new System.Drawing.Point(120, index * 30 + 10);
        labelKnownColorName.Text = knownColor.ToString();
        labelKnownColorName.Click += this.OnKnownColorNameClick;
        ++index;
      }

      this.panelUserDefinedColor.Parent = this;
      this.panelUserDefinedColor.Location = new System.Drawing.Point(330, 10);
      this.panelUserDefinedColor.Size = new System.Drawing.Size(300, 400);
      this.panelUserDefinedColor.BorderStyle = BorderStyle.Fixed3D;

      this.labelAlpha.Parent = this.panelUserDefinedColor;
      this.labelAlpha.Location = new System.Drawing.Point(10, 15);
      this.labelAlpha.AutoSize = true;
      this.labelAlpha.Text = "A";

      this.trackBarAlpha.Parent = this.panelUserDefinedColor;
      this.trackBarAlpha.Location = new System.Drawing.Point(40, 12);
      this.trackBarAlpha.Maximum = 255;
      this.trackBarAlpha.Height = 25;
      this.trackBarAlpha.Width = 190;
      this.trackBarAlpha.TickStyle = TickStyle.None;
      this.trackBarAlpha.ValueChanged += delegate (object sender, EventArgs e) {
        this.numericUpDownAlpha.Value = this.trackBarAlpha.Value;
      };

      this.numericUpDownAlpha.Parent = this.panelUserDefinedColor;
      this.numericUpDownAlpha.Bounds = new System.Drawing.Rectangle(240, 12, 50, 20);
      this.numericUpDownAlpha.Minimum = 0;
      this.numericUpDownAlpha.Maximum = 255;
      this.numericUpDownAlpha.ValueChanged += this.OnArgbChanged;

      this.labelRed.Parent = this.panelUserDefinedColor;
      this.labelRed.Location = new System.Drawing.Point(10, 60);
      this.labelRed.AutoSize = true;
      this.labelRed.Text = "R";

      this.trackBarRed.Parent = this.panelUserDefinedColor;
      this.trackBarRed.Location = new System.Drawing.Point(40, 58);
      this.trackBarRed.Maximum = 255;
      this.trackBarRed.Height = 25;
      this.trackBarRed.Width = 190;
      this.trackBarRed.TickStyle = TickStyle.None;
      this.trackBarRed.ValueChanged += delegate (object sender, EventArgs e) {
        this.numericUpDownRed.Value = this.trackBarRed.Value;
      };

      this.numericUpDownRed.Parent = this.panelUserDefinedColor;
      this.numericUpDownRed.Bounds = new System.Drawing.Rectangle(240, 58, 50, 20);
      this.numericUpDownRed.Minimum = 0;
      this.numericUpDownRed.Maximum = 255;
      this.numericUpDownRed.ValueChanged += this.OnArgbChanged;

      this.labelGreen.Parent = this.panelUserDefinedColor;
      this.labelGreen.Location = new System.Drawing.Point(10, 105);
      this.labelGreen.AutoSize = true;
      this.labelGreen.Text = "G";

      this.trackBarGreen.Parent = this.panelUserDefinedColor;
      this.trackBarGreen.Location = new System.Drawing.Point(40, 102);
      this.trackBarGreen.Maximum = 255;
      this.trackBarGreen.Height = 25;
      this.trackBarGreen.Width = 190;
      this.trackBarGreen.TickStyle = TickStyle.None;
      this.trackBarGreen.ValueChanged += delegate (object sender, EventArgs e) {
        this.numericUpDownGreen.Value = this.trackBarGreen.Value;
      };

      this.numericUpDownGreen.Parent = this.panelUserDefinedColor;
      this.numericUpDownGreen.Minimum = 0;
      this.numericUpDownGreen.Maximum = 255;
      this.numericUpDownGreen.Bounds = new System.Drawing.Rectangle(240, 102, 50, 20);
      this.numericUpDownGreen.ValueChanged += this.OnArgbChanged;

      this.labelBlue.Parent = this.panelUserDefinedColor;
      this.labelBlue.Location = new System.Drawing.Point(10, 150);
      this.labelBlue.AutoSize = true;
      this.labelBlue.Text = "B";

      this.trackBarBlue.Parent = this.panelUserDefinedColor;
      this.trackBarBlue.Location = new System.Drawing.Point(40, 148);
      this.trackBarBlue.Maximum = 255;
      this.trackBarBlue.Height = 25;
      this.trackBarBlue.Width = 190;
      this.trackBarBlue.TickStyle = TickStyle.None;
      this.trackBarBlue.ValueChanged += delegate (object sender, EventArgs e) {
        this.numericUpDownBlue.Value = this.trackBarBlue.Value;
      };

      this.numericUpDownBlue.Parent = this.panelUserDefinedColor;
      this.numericUpDownBlue.Minimum = 0;
      this.numericUpDownBlue.Maximum = 255;
      this.numericUpDownBlue.Bounds = new System.Drawing.Rectangle(240, 148, 50, 20);
      this.numericUpDownBlue.ValueChanged += this.OnArgbChanged;


      this.panelColorBox.Parent = this.panelUserDefinedColor;
      this.panelColorBox.Bounds = new System.Drawing.Rectangle(45, 195, 190, 190);
      this.panelColorBox.BackColor = System.Drawing.Color.FromArgb(255, (byte)this.numericUpDownRed.Value, (byte)this.numericUpDownGreen.Value, (byte)this.numericUpDownBlue.Value);
      this.panelColorBox.BorderStyle = BorderStyle.Fixed3D;
    }

    public void OnKnownColorClick(object sender, EventArgs e) {
      System.Drawing.Color color = (sender as Panel).BackColor;
      this.trackBarAlpha.Value = color.A;
      this.numericUpDownAlpha.Value = color.A;
      this.trackBarRed.Value = color.R;
      this.numericUpDownRed.Value = color.R;
      this.trackBarGreen.Value = color.G;
      this.numericUpDownGreen.Value = color.G;
      this.trackBarBlue.Value = color.B;
      this.numericUpDownBlue.Value = color.B;
    }

    public void OnKnownColorNameClick(object sender, EventArgs e) {
      System.Drawing.Color color = System.Drawing.Color.FromName((sender as Label).Text);
      this.trackBarAlpha.Value = color.A;
      this.numericUpDownAlpha.Value = color.A;
      this.trackBarRed.Value = color.R;
      this.numericUpDownRed.Value = color.R;
      this.trackBarGreen.Value = color.G;
      this.numericUpDownGreen.Value = color.G;
      this.trackBarBlue.Value = color.B;
      this.numericUpDownBlue.Value = color.B;
    }

    public void OnArgbChanged(object sender, EventArgs e) {
      this.panelColorBox.BackColor = System.Drawing.Color.FromArgb((byte)this.numericUpDownAlpha.Value, (byte)this.numericUpDownRed.Value, (byte)this.numericUpDownGreen.Value, (byte)this.numericUpDownBlue.Value);
    }

    private Panel panelKnownColors = new Panel();
    private Panel panelUserDefinedColor = new Panel();
    private Label labelAlpha = new Label();
    private Label labelRed = new Label();
    private Label labelGreen = new Label();
    private Label labelBlue = new Label();
    private TrackBar trackBarAlpha = new TrackBar();
    private TrackBar trackBarRed = new TrackBar();
    private TrackBar trackBarGreen = new TrackBar();
    private TrackBar trackBarBlue = new TrackBar();
    private NumericUpDown numericUpDownAlpha = new NumericUpDown();
    private NumericUpDown numericUpDownRed = new NumericUpDown();
    private NumericUpDown numericUpDownGreen = new NumericUpDown();
    private NumericUpDown numericUpDownBlue = new NumericUpDown();
    private Panel panelColorBox = new Panel();
  }
}
