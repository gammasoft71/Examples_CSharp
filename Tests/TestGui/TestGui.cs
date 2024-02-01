using System;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Examples {
  class Form1 : Form {
    [STAThread]
    public static void Main() {
      Application.EnableVisualStyles();
      Application.Run(new Form1());
    }
    public Form1() {
      BufferedGraphicsContext gc = new BufferedGraphicsContext();
      ClientSize = new Size(1000, 800);
      MinimumSize = Size;
      ResizeRedraw = true;
      Text = "Test GUI";

      Controls.AddRange(new Control[] {alignmentLabel, alignmentComboBox, lineAlignmentLabel, lineAlignmentComboBox, trimmingLabel, trimmingComboBox, hotKeyPrefixLabel, hotKeyPrefixComboBox, formatFlagsGroupBox });

      alignmentLabel.AutoSize = true;
      alignmentLabel.Location = new Point(10, 12);
      alignmentLabel.Text = "Alignment";

      alignmentComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
      alignmentComboBox.Items.AddRange(new object[] { "Near", "Center", "Far" });
      alignmentComboBox.Location = new Point(100, 10);
      alignmentComboBox.SelectedIndex = 0;
      alignmentComboBox.SelectedIndexChanged += delegate { Invalidate(); };

      lineAlignmentLabel.AutoSize = true;
      lineAlignmentLabel.Location = new Point(260, 12);
      lineAlignmentLabel.Text = "Line alignment";

      lineAlignmentComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
      lineAlignmentComboBox.Items.AddRange(new object[] { "Near", "Center", "Far" });
      lineAlignmentComboBox.Location = new Point(340, 10);
      lineAlignmentComboBox.SelectedIndex = 0;
      lineAlignmentComboBox.SelectedIndexChanged += delegate { Invalidate(); };

      trimmingLabel.AutoSize = true;
      trimmingLabel.Location = new Point(10, 42);
      trimmingLabel.Text = "Trimming";

      trimmingComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
      trimmingComboBox.Items.AddRange(new object[] { "None", "Character", "Word", "EllipsisCharacter", "EllipsisWord", "ElipsisPath" });
      trimmingComboBox.Location = new Point(100, 40);
      trimmingComboBox.SelectedIndex = 0;
      trimmingComboBox.SelectedIndexChanged += delegate { Invalidate(); };

      hotKeyPrefixLabel.AutoSize = true;
      hotKeyPrefixLabel.Location = new Point(260, 42);
      hotKeyPrefixLabel.Text = "Hot key prefix";

      hotKeyPrefixComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
      hotKeyPrefixComboBox.Items.AddRange(new object[] { "None", "Show", "Hide" });
      hotKeyPrefixComboBox.Location = new Point(340, 40);
      hotKeyPrefixComboBox.SelectedIndex = 0;
      hotKeyPrefixComboBox.SelectedIndexChanged += delegate { Invalidate(); };

      formatFlagsGroupBox.Controls.AddRange(new Control[] { directionRightToLeftCheckBox, directionVerticalCheckBox, FitBlackBoxCheckBox, DisplayFormatControlCheckBox, NoFontFallbackCheckBox, MeasureTrailingSpacesCheckBox, NoWrapCheckBox, LineLimitCheckBox, NoClipCheckBox });
      formatFlagsGroupBox.Location = new Point(10, 70);
      formatFlagsGroupBox.Size = new Size(450, 170);
      formatFlagsGroupBox.Text = "Fromat flags";

      directionRightToLeftCheckBox.AutoSize = true;
      directionRightToLeftCheckBox.Location = new Point(10, 20);
      directionRightToLeftCheckBox.Text = "Direction right to left";
      directionRightToLeftCheckBox.CheckedChanged += delegate { Invalidate(); };

      directionVerticalCheckBox.AutoSize = true;
      directionVerticalCheckBox.Location = new Point(250, 20);
      directionVerticalCheckBox.Text = "Direction vertical";
      directionVerticalCheckBox.CheckedChanged += delegate { Invalidate(); };

      FitBlackBoxCheckBox.AutoSize = true;
      FitBlackBoxCheckBox.Location = new Point(10, 50);
      FitBlackBoxCheckBox.Text = "Fit back box";
      FitBlackBoxCheckBox.CheckedChanged += delegate { Invalidate(); };

      DisplayFormatControlCheckBox.AutoSize = true;
      DisplayFormatControlCheckBox.Location = new Point(250, 50);
      DisplayFormatControlCheckBox.Text = "Display format control";
      DisplayFormatControlCheckBox.CheckedChanged += delegate { Invalidate(); };

      NoFontFallbackCheckBox.AutoSize = true;
      NoFontFallbackCheckBox.Location = new Point(10, 80);
      NoFontFallbackCheckBox.Text = "No font failback";
      NoFontFallbackCheckBox.CheckedChanged += delegate { Invalidate(); };

      MeasureTrailingSpacesCheckBox.AutoSize = true;
      MeasureTrailingSpacesCheckBox.Location = new Point(250, 80);
      MeasureTrailingSpacesCheckBox.Text = "Measure trailing spaces";
      MeasureTrailingSpacesCheckBox.CheckedChanged += delegate { Invalidate(); };

      NoWrapCheckBox.AutoSize = true;
      NoWrapCheckBox.Location = new Point(10, 110);
      NoWrapCheckBox.Text = "No wrap";
      NoWrapCheckBox.CheckedChanged += delegate { Invalidate(); };

      LineLimitCheckBox.AutoSize = true;
      LineLimitCheckBox.Location = new Point(250, 110);
      LineLimitCheckBox.Text = "Line limit";
      LineLimitCheckBox.CheckedChanged += delegate { Invalidate(); };

      NoClipCheckBox.AutoSize = true;
      NoClipCheckBox.Location = new Point(10, 140);
      NoClipCheckBox.Text = "No clip";
      NoClipCheckBox.CheckedChanged += delegate { Invalidate(); };
    }

    override protected void OnPaint(PaintEventArgs e) {
      base.OnPaint(e);

      var rect = new Rectangle(100, 270, e.ClipRectangle.Width - 200, e.ClipRectangle.Height - 487);

      e.Graphics.FillRectangle(new SolidBrush(Color.DarkCyan), rect);

      var text = "&Lorem &ipsum &&dolor sit amet, consectetur adipiscing elit.                                     \nSed non risus. Suspendisse lectus tortor, dignissim sit amet, adipiscing nec, ultricies sed, dolor. Cras elementum ultrices diam. Maecenas ligula massa, varius a, semper congue, euismod non, mi. Proin porttitor, orci nec nonummy molestie, enim est eleifend mi, non fermentum diam nisl sit amet erat. Duis semper. Duis arcu massa, scelerisque vitae, consequat in, pretium a, enim. Pellentesque congue. Ut in risus volutpat libero pharetra tempor. Cras vestibulum bibendum augue. Praesent egestas leo in pede. Praesent blandit odio eu enim. Pellentesque sed dui ut augue blandit sodales. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Aliquam nibh. Mauris ac mauris sed pede pellentesque fermentum. Maecenas adipiscing ante non diam sodales hendrerit.\n\nUt velit mauris, egestas sed, gravida nec, ornare ut, mi. Aenean ut orci vel massa suscipit pulvinar. Nulla sollicitudin. Fusce varius, ligula non tempus aliquam, nunc turpis ullamcorper nibh, in tempus sapien eros vitae ligula. Pellentesque rhoncus nunc et augue. Integer id felis. Curabitur aliquet pellentesque diam. Integer quis metus vitae elit lobortis egestas. Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Morbi vel erat non mauris convallis vehicula. Nulla et sapien. Integer tortor tellus, aliquam faucibus, convallis id, congue eu, quam. Mauris ullamcorper felis vitae erat. Proin feugiat, augue non elementum posuere, metus purus iaculis lectus, et tristique ligula justo vitae magna.\n\nAliquam convallis sollicitudin purus. Praesent aliquam, enim at fermentum mollis, ligula massa adipiscing nisl, ac euismod nibh nisl eu lectus. Fusce vulputate sem at sapien. Vivamus leo. Aliquam euismod libero eu enim. Nulla nec felis sed leo placerat imperdiet. Aenean suscipit nulla in justo. Suspendisse cursus rutrum augue. Nulla tincidunt tincidunt mi. Curabitur iaculis, lorem vel rhoncus faucibus, felis magna fermentum augue, et ultricies lacus lorem varius purus. Curabitur eu amet.\n";

      StringFormat format = new StringFormat();

      StringAlignment alignment = StringAlignment.Near;
      Enum.TryParse<StringAlignment>((String)alignmentComboBox.Items[alignmentComboBox.SelectedIndex], out alignment);
      format.Alignment = alignment;
      
      alignment = StringAlignment.Near;
      Enum.TryParse<StringAlignment>((String)lineAlignmentComboBox.Items[lineAlignmentComboBox.SelectedIndex], out alignment);
      format.LineAlignment = alignment;
      
      StringTrimming trimming = StringTrimming.None;
      Enum.TryParse<StringTrimming>((String)trimmingComboBox.Items[trimmingComboBox.SelectedIndex], out trimming);
      format.Trimming = trimming;

      HotkeyPrefix hotKeyPrefix = HotkeyPrefix.None;
      Enum.TryParse<HotkeyPrefix>((String)hotKeyPrefixComboBox.Items[hotKeyPrefixComboBox.SelectedIndex], out hotKeyPrefix);
      format.HotkeyPrefix = hotKeyPrefix;
      
      if (directionRightToLeftCheckBox.Checked) format.FormatFlags |= StringFormatFlags.DirectionRightToLeft;
      if (directionVerticalCheckBox.Checked) format.FormatFlags |= StringFormatFlags.DirectionVertical;
      if (FitBlackBoxCheckBox.Checked) format.FormatFlags |= StringFormatFlags.FitBlackBox;
      if (DisplayFormatControlCheckBox.Checked) format.FormatFlags |= StringFormatFlags.DisplayFormatControl;
      if (NoFontFallbackCheckBox.Checked) format.FormatFlags |= StringFormatFlags.NoFontFallback;
      if (MeasureTrailingSpacesCheckBox.Checked) format.FormatFlags |= StringFormatFlags.MeasureTrailingSpaces;
      if (NoWrapCheckBox.Checked) format.FormatFlags |= StringFormatFlags.NoWrap;
      if (LineLimitCheckBox.Checked) format.FormatFlags |= StringFormatFlags.LineLimit;
      if (NoClipCheckBox.Checked) format.FormatFlags |= StringFormatFlags.NoClip;

      var font = new Font(SystemFonts.DefaultFont.FontFamily, 16, FontStyle.Regular);
      e.Graphics.DrawString(text, font, new SolidBrush(Color.Black), rect, format);
    }

    Label alignmentLabel = new Label();
    ComboBox alignmentComboBox = new ComboBox();
    Label lineAlignmentLabel = new Label();
    ComboBox lineAlignmentComboBox = new ComboBox();
    Label trimmingLabel = new Label();
    ComboBox trimmingComboBox = new ComboBox();
    Label hotKeyPrefixLabel = new Label();
    ComboBox hotKeyPrefixComboBox = new ComboBox();
    GroupBox formatFlagsGroupBox = new GroupBox();
    CheckBox directionRightToLeftCheckBox = new CheckBox();
    CheckBox directionVerticalCheckBox = new CheckBox();
    CheckBox FitBlackBoxCheckBox = new CheckBox();
    CheckBox DisplayFormatControlCheckBox = new CheckBox();
    CheckBox NoFontFallbackCheckBox = new CheckBox();
    CheckBox MeasureTrailingSpacesCheckBox = new CheckBox();
    CheckBox NoWrapCheckBox = new CheckBox();
    CheckBox LineLimitCheckBox = new CheckBox();
    CheckBox NoClipCheckBox = new CheckBox();
  }
}
