using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace GearPoint
{
    internal class RoundedPanel : Panel
    {
        public int BorderRadius { get; set; } = 20; // Default radius

        public RoundedPanel()
        {
            this.DoubleBuffered = true;
            this.Resize += (s, e) => this.Invalidate(); // Redraw when resized
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Define the rounded rectangle path
            GraphicsPath path = new GraphicsPath();
            int radius = BorderRadius * 2;

            path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90); // Top-left corner
            path.AddArc(new Rectangle(Width - radius, 0, radius, radius), 270, 90); // Top-right corner
            path.AddArc(new Rectangle(Width - radius, Height - radius, radius, radius), 0, 90); // Bottom-right corner
            path.AddArc(new Rectangle(0, Height - radius, radius, radius), 90, 90); // Bottom-left corner
            path.CloseFigure();

            // Set the panel's region to the rounded path
            this.Region = new Region(path);

            // Optionally, draw a border
            using (Pen pen = new Pen(Color.Black, 2))
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.DrawPath(pen, path);
            }
        }
    }
}
