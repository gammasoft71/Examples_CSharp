using System;
using System.Drawing;
using System.Windows.Forms;

namespace Examples {
  class MainForm : Form {
    [STAThread]
    public static void Main() {
      Application.EnableVisualStyles();
      Application.Run(new MainForm());
    }
    public MainForm() {
      Controls.Add(formStylesTabControl);
      Size = new System.Drawing.Size(600, 480);
      Padding = new System.Windows.Forms.Padding(10);
      Text = "Form tests";
      System.Diagnostics.Debug.WriteLine("CreapeParams = {0}", CreateParams);

      formStylesTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
      formStylesTabControl.TabPages.AddRange(new TabPage[] {decorationTabPage, windowStateTabPage, showTabPage });

      decorationTabPage.Text = "Decorations";
      windowStateTabPage.Text = "State";
      showTabPage.Text = "Show";

      decorationTabPage.Controls.AddRange(new Control[] { captionLabel, captionTextBox, borderStyleComboBox, minimizeBoxCheckBox, maximizeBoxCheckBox, closeBoxCheckBox, controlBoxCheckBox, helpButtonCheckBox, showIconCheckBox, showInTaskbarCheckBox });
      windowStateTabPage.Controls.AddRange(new Control[] { maximizeButton, normalButton, minimizeButton });
      showTabPage.Controls.AddRange(new Control[] { showNormalButton, showModelessButton, showTopMostButton, showModalButton });

      borderStyleComboBox.Location = new Point(10, 10);
      borderStyleComboBox.Width = 200;
      borderStyleComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
      borderStyleComboBox.Items.AddRange(new object[] { FormBorderStyle.None, FormBorderStyle.FixedSingle, FormBorderStyle.Fixed3D, FormBorderStyle.FixedDialog, FormBorderStyle.Sizable, FormBorderStyle.FixedToolWindow, FormBorderStyle.SizableToolWindow});
      borderStyleComboBox.SelectedIndex = (int)FormBorderStyle;
      borderStyleComboBox.SelectedIndexChanged += delegate {
        FormBorderStyle = (FormBorderStyle)borderStyleComboBox.SelectedIndex;
        System.Diagnostics.Debug.WriteLine("CreapeParams = {0}", CreateParams);
      };

      captionLabel.Location = new Point(10, 40);
      captionLabel.Text = "Caption";
      captionTextBox.Location = new Point(110, 40);
      captionTextBox.Width = 100;
      captionTextBox.Text = Text;
      captionTextBox.TextChanged += delegate {
        Text = captionTextBox.Text;
        System.Diagnostics.Debug.WriteLine("CreapeParams = {0}", CreateParams);
      };

      minimizeBoxCheckBox.Location = new Point(10, 70);
      minimizeBoxCheckBox.Text = "MinimizeBox";
      minimizeBoxCheckBox.Checked = MinimizeBox;
      minimizeBoxCheckBox.CheckedChanged += delegate {
        MinimizeBox = minimizeBoxCheckBox.Checked;
        System.Diagnostics.Debug.WriteLine("CreapeParams = {0}", CreateParams);
      };

      maximizeBoxCheckBox.Location = new Point(10, 100);
      maximizeBoxCheckBox.Text = "MaximizeBox";
      maximizeBoxCheckBox.Checked = MaximizeBox;
      maximizeBoxCheckBox.CheckedChanged += delegate {
        MaximizeBox = maximizeBoxCheckBox.Checked;
        System.Diagnostics.Debug.WriteLine("CreapeParams = {0}", CreateParams);
      };

      closeBoxCheckBox.Location = new Point(10, 130);
      closeBoxCheckBox.Text = "CloseBox";
      closeBoxCheckBox.Enabled = false;
      //closeBoxCheckBox.Checked = CloseBox;
      closeBoxCheckBox.CheckedChanged += delegate {
        //CloseBox = closeBoxCheckBox.Checked;
        System.Diagnostics.Debug.WriteLine("CreapeParams = {0}", CreateParams);
      };

      controlBoxCheckBox.Location = new Point(10, 160);
      controlBoxCheckBox.Text = "ControlBox";
      controlBoxCheckBox.Checked = ControlBox;
      controlBoxCheckBox.CheckedChanged += delegate {
        ControlBox = controlBoxCheckBox.Checked;
        System.Diagnostics.Debug.WriteLine("CreapeParams = {0}", CreateParams);
      };

      helpButtonCheckBox.Location = new Point(10, 190);
      helpButtonCheckBox.Text = "HelpButton";
      helpButtonCheckBox.Checked = HelpButton;
      helpButtonCheckBox.CheckedChanged += delegate {
        HelpButton = helpButtonCheckBox.Checked;
        System.Diagnostics.Debug.WriteLine("CreapeParams = {0}", CreateParams);
      };

      showIconCheckBox.Location = new Point(10, 220);
      showIconCheckBox.Text = "ShowIcon";
      showIconCheckBox.Checked = ShowIcon;
      showIconCheckBox.CheckedChanged += delegate {
        ShowIcon = showIconCheckBox.Checked;
        System.Diagnostics.Debug.WriteLine("CreapeParams = {0}", CreateParams);
      };

      showInTaskbarCheckBox.Location = new Point(10, 250);
      showInTaskbarCheckBox.Text = "ShowInTaskbar";
      showInTaskbarCheckBox.Checked = ShowInTaskbar;
      showInTaskbarCheckBox.CheckedChanged += delegate {
        ShowInTaskbar = showInTaskbarCheckBox.Checked;
        System.Diagnostics.Debug.WriteLine("CreapeParams = {0}", CreateParams);
      };

      maximizeButton.Location = new Point(10, 10);
      maximizeButton.Text = "Maximize";
      maximizeButton.Click += delegate {
        WindowState = FormWindowState.Maximized;
        System.Diagnostics.Debug.WriteLine("CreapeParams = {0}", CreateParams);
      };

      normalButton.Location = new Point(10, 40);
      normalButton.Text = "Normal";
      normalButton.Click += delegate {
        WindowState = FormWindowState.Normal;
        System.Diagnostics.Debug.WriteLine("CreapeParams = {0}", CreateParams);
      };

      minimizeButton.Location = new Point(10, 70);
      minimizeButton.Text = "Minimize";
      minimizeButton.Click += delegate {
        WindowState = FormWindowState.Minimized;
        System.Diagnostics.Debug.WriteLine("CreapeParams = {0}", CreateParams);
      };

      showNormalButton.Location = new Point(10, 10);
      showNormalButton.Width = 140;
      showNormalButton.Text = "Show Normal";
      showNormalButton.Click += delegate {
        Form form = new Form { Text = "Dialog Show Normal", Size = new Size(250, 100) };
        form.Show();
      };

      showModelessButton.Location = new Point(10, 40);
      showModelessButton.Width = 140;
      showModelessButton.Text = "Show Modeless";
      showModelessButton.Click += delegate {
        Form form = new Form { Text = "Dialog Show Modeless", Size = new Size(250, 100), Owner = this };
        form.Show();
      };

      showTopMostButton.Location = new Point(10, 70);
      showTopMostButton.Width = 140;
      showTopMostButton.Text = "Show TopMost";
      showTopMostButton.Click += delegate {
        Form form = new Form { Text = "Dialog Show TopMost", Size = new Size(250, 100), TopMost = true };
        form.Show();
      };

      showModalButton.Location = new Point(10, 100);
      showModalButton.Width = 140;
      showModalButton.Text = "Show Modal";
      showModalButton.Click += delegate {
        Form form = new Form { Text = "Dialog Show Modal", Size = new Size(250, 100) };
        form.ShowDialog(this);
      };

    }

    TabControl formStylesTabControl = new TabControl();
    TabPage decorationTabPage = new TabPage();
    TabPage windowStateTabPage = new TabPage();
    TabPage showTabPage = new TabPage();
    
    ComboBox borderStyleComboBox = new ComboBox();
    Label captionLabel = new Label();
    TextBox captionTextBox = new TextBox();
    CheckBox minimizeBoxCheckBox = new CheckBox();
    CheckBox maximizeBoxCheckBox = new CheckBox();
    CheckBox closeBoxCheckBox = new CheckBox();
    CheckBox controlBoxCheckBox = new CheckBox();
    CheckBox helpButtonCheckBox = new CheckBox();
    CheckBox showIconCheckBox = new CheckBox();
    CheckBox showInTaskbarCheckBox = new CheckBox();

    Button maximizeButton = new Button();
    Button normalButton = new Button();
    Button minimizeButton = new Button();

    Button showNormalButton = new Button();
    Button showModelessButton = new Button();
    Button showTopMostButton = new Button();
    Button showModalButton = new Button();

  }
}
