using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace GearPoint
{
    class RoundedPictureBox : PictureBox
    {
        public int CornerRadius { get; set; } = 20; // You can adjust the default radius

        protected override void OnPaint(PaintEventArgs pe)
        {
            // Create a GraphicsPath for a rounded rectangle
            GraphicsPath graphicsPath = new GraphicsPath();
            Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);
            int radius = CornerRadius;

            // Add rounded rectangle to path
            graphicsPath.AddArc(rect.X, rect.Y, radius, radius, 180, 90); // Top-left corner
            graphicsPath.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90); // Top-right corner
            graphicsPath.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90); // Bottom-right corner
            graphicsPath.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90); // Bottom-left corner
            graphicsPath.CloseFigure();

            // Set the region of the PictureBox to the rounded rectangle
            this.Region = new Region(graphicsPath);

            // Call the base class OnPaint to draw the content inside the PictureBox
            base.OnPaint(pe);
        }
    }
}
