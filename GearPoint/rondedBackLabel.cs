using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace GearPoint
{
    public class RoundedBackLabel : Label
    {
        // Property to set the corner radius, adjusts automatically with size
        private int cornerRadius = 20;
        public int CornerRadius
        {
            get { return cornerRadius; }
            set { cornerRadius = value; Invalidate(); } // Redraw when changed
        }

        // Property to set the background color
        private Color backColor = Color.LightSkyBlue;
        public new Color BackColor
        {
            get { return backColor; }
            set { backColor = value; Invalidate(); } // Redraw when changed
        }

        // Property to set the padding around the text
        private Padding textPadding = new Padding(5);
        public Padding TextPadding
        {
            get { return textPadding; }
            set { textPadding = value; Invalidate(); } // Redraw when changed
        }

        // Property to set the font size and style
        private Font textFont = new Font("Arial", 14, FontStyle.Bold);
        public new Font Font
        {
            get { return textFont; }
            set { textFont = value; Invalidate(); } // Redraw when changed
        }

        // Property to set the text color
        private Color textColor = Color.White;
        public new Color ForeColor
        {
            get { return textColor; }
            set { textColor = value; Invalidate(); } // Redraw when changed
        }

        // Constructor to initialize default label properties
        public RoundedBackLabel()
        {
            this.TextAlign = ContentAlignment.MiddleCenter;
            this.AutoSize = true; // Enable auto-size to adjust based on content
            this.Size = new Size(200, 50); // Default size
        }

        // Override the OnPaint method to custom draw the label
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Make sure the corner radius doesn't exceed half the height/width
            int radius = Math.Min(CornerRadius, Math.Min(Width, Height) / 2);

            // Create a rounded rectangle path for the label background
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddArc(0, 0, radius, radius, 180, 90);
                path.AddArc(Width - radius - 1, 0, radius, radius, 270, 90);
                path.AddArc(Width - radius - 1, Height - radius - 1, radius, radius, 0, 90);
                path.AddArc(0, Height - radius - 1, radius, radius, 90, 90);
                path.CloseFigure();

                // Fill the background with the desired color
                using (Brush backgroundBrush = new SolidBrush(BackColor))
                {
                    e.Graphics.FillPath(backgroundBrush, path);
                }

                // Optionally, draw the label's text on top of the background
                using (Brush textBrush = new SolidBrush(ForeColor))
                {
                    // Create a string format for text alignment
                    var format = new StringFormat
                    {
                        Alignment = StringAlignment.Center,
                        LineAlignment = StringAlignment.Center
                    };

                    // Adjust the rectangle for padding
                    Rectangle textRect = new Rectangle(
                        this.ClientRectangle.X + TextPadding.Left,
                        this.ClientRectangle.Y + TextPadding.Top,
                        this.ClientRectangle.Width - TextPadding.Left - TextPadding.Right,
                        this.ClientRectangle.Height - TextPadding.Top - TextPadding.Bottom
                    );

                    // Draw the text with padding
                    e.Graphics.DrawString(Text, Font, textBrush, textRect, format);
                }
            }
        }

        // Override the OnTextChanged method to handle resizing
        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);

            // If AutoSize is enabled, update the label size to fit the text
            if (AutoSize)
            {
                // Measure the size of the text with padding
                var textSize = TextRenderer.MeasureText(Text, Font);

                // Update the size of the label (text size with padding)
                this.Size = new Size(textSize.Width + TextPadding.Left + TextPadding.Right,
                                     textSize.Height + TextPadding.Top + TextPadding.Bottom);
            }
        }
    }
}
