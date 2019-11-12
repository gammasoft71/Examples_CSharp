using System;
using System.Drawing;
using System.Windows.Forms;

namespace Examples {
 class Form1 : Form {
    public static void Main() {
      Application.EnableVisualStyles();
      Application.Run(new Form1());
    }

    public Form1() {
      Text = "Painting example";
      ClientSize = new Size(640, 480);

      panelColorsContainer.BorderStyle = BorderStyle.FixedSingle;
      panelColorsContainer.Location = new Point(10, 10);
      panelColorsContainer.ClientSize = new Size(512, 32);
      panelColorsContainer.Parent = this;

      buttonClear.Parent = this;
      buttonClear.Location = new Point(542, 15);
      buttonClear.Text = "Clear";
      buttonClear.Click += delegate {
        picture = new Bitmap(pictureWidth, pictureHeight);
        panelPainting.Invalidate(false);
      };

      trackBarZoom.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      trackBarZoom.AutoSize = false;
      trackBarZoom.Location = new Point(10, 50);
      trackBarZoom.TickStyle = TickStyle.None;
      trackBarZoom.SetRange(1, 50);
      trackBarZoom.Value = zoom;
      trackBarZoom.Parent = this;
      trackBarZoom.Size = new Size(ClientSize.Width - 20, 25);
      trackBarZoom.ValueChanged += delegate {
        zoom = trackBarZoom.Value;
        panelPainting.Invalidate(false);
      };

      panelPainting.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Right;
      panelPainting.BackColor = Color.WhiteSmoke;
      panelPainting.BorderStyle = BorderStyle.FixedSingle;
      panelPainting.Location = new Point(10, 82);
      panelPainting.Parent = this;
      panelPainting.Size = new Size(620, 388);

      foreach (Color color in new Color[] { Color.DarkMagenta, Color.DarkCyan, Color.Brown, Color.DarkBlue, Color.DarkGreen, Color.DarkRed, Color.Gray, Color.DarkGray, Color.Magenta, Color.Cyan, Color.Yellow, Color.Blue, Color.Green, Color.Red, Color.White, Color.Black }) {
        Panel panelColor = new Panel { Parent = panelColorsContainer, Size = new Size(32, 32), BackColor = color, Dock = DockStyle.Left };
        panelColor.Click += this.ChooseCurrentColor;
        panelColors.Add(panelColor);
      }

      panelPainting.MouseDown += delegate (object sender, MouseEventArgs e) {
        picture.SetPixel(e.X / zoom, e.Y / zoom, e.Button == MouseButtons.Left ? currentColor : Color.Empty);
        panelPainting.Invalidate(new Rectangle(e.X / zoom * zoom, e.Y / zoom * zoom, zoom, zoom), false);
      };

      panelPainting.MouseMove += delegate (object sender, MouseEventArgs e) {
        if (e.Button == MouseButtons.Left && e.X >= 0 && e.X < panelPainting.ClientSize.Width && e.Y >= 0 && e.Y < panelPainting.ClientSize.Height) {
          picture.SetPixel(e.X / zoom, e.Y / zoom, currentColor);
          panelPainting.Invalidate(new Rectangle(e.X / zoom * zoom, e.Y / zoom * zoom, zoom, zoom), false);
        }
      };

      panelPainting.Paint += delegate  (object sender, PaintEventArgs e) {
        for (int x = 0; x < panelPainting.ClientSize.Width; x += zoom) {
          for (int y = 0; y < panelPainting.ClientSize.Height; y += zoom) {
            if (!picture.GetPixel(x, y).IsEmpty) {
              SolidBrush solidBrush = new SolidBrush(picture.GetPixel(x / zoom, y / zoom));
              e.Graphics.FillRectangle(solidBrush, x, y, zoom, zoom);
              solidBrush.Dispose();
            }
          }
        }

        if (zoom > 3) {
          Pen pen = new Pen(Color.LightBlue, 1);
          for (int index = 0; index < panelPainting.ClientSize.Width; index += zoom)
            e.Graphics.DrawLine(pen, index, 0, index, panelPainting.ClientSize.Height);
          for (int index = 0; index < panelPainting.ClientSize.Height; index += zoom)
            e.Graphics.DrawLine(pen, 0, index, panelPainting.ClientSize.Width, index);
          pen.Dispose();
        }
      };
    }

    private void ChooseCurrentColor(object sender, EventArgs e) {
      foreach (var panel in panelColors)
        panel.BorderStyle = panel.Handle != (sender as Control).Handle? BorderStyle.None : BorderStyle.FixedSingle;
      currentColor = (sender as Control).BackColor;
    }

    private static int pictureWidth = 5000;
    private static int pictureHeight = 5000;
    private static int zoom = 20;
    private Color currentColor = Color.Black;
    private Bitmap picture = new Bitmap(pictureWidth, pictureHeight);

    private Panel panelColorsContainer = new Panel();
    private System.Collections.Generic.List<Panel> panelColors = new System.Collections.Generic.List<Panel>();
    private Button buttonClear = new Button();
    private TrackBar trackBarZoom = new TrackBar();
    private Panel panelPainting = new Panel();
  }
}
