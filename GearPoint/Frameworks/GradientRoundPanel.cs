using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class GradientRoundPanel : Panel
{
    public int BorderRadius { get; set; } = 30; // Default radius
    public Color GradientStartColor { get; set; } = Color.LightBlue;
    public Color GradientEndColor { get; set; } = Color.DarkBlue;
    private float _gradientRatio = 0.5f; // Default 50/50 balance between start and end color

    public float GradientRatio
    {
        get { return _gradientRatio; }
        set
        {
            _gradientRatio = Math.Max(0, Math.Min(1, value)); // Ensure ratio is between 0 and 1
            Invalidate(); // Redraw panel when gradient ratio changes
        }
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        // Create a GraphicsPath to define the rounded rectangle
        GraphicsPath path = new GraphicsPath();
        path.AddArc(new Rectangle(0, 0, BorderRadius, BorderRadius), 180, 90); // Top-left corner
        path.AddArc(new Rectangle(Width - BorderRadius, 0, BorderRadius, BorderRadius), 270, 90); // Top-right corner
        path.AddArc(new Rectangle(Width - BorderRadius, Height - BorderRadius, BorderRadius, BorderRadius), 0, 90); // Bottom-right corner
        path.AddArc(new Rectangle(0, Height - BorderRadius, BorderRadius, BorderRadius), 90, 90); // Bottom-left corner
        path.CloseFigure();

        // Set the panel's region to this rounded path
        this.Region = new Region(path);

        // Set up the gradient brush with the `GradientEndColor` being more dominant
        using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, GradientStartColor, GradientEndColor, LinearGradientMode.Horizontal))
        {
            ColorBlend colorBlend = new ColorBlend();
            colorBlend.Colors = new[] { GradientStartColor, GradientEndColor, GradientEndColor };
            colorBlend.Positions = new[] { 0.0f, 1 - GradientRatio, 1.0f }; // Control end color dominance

            brush.InterpolationColors = colorBlend;

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.FillPath(brush, path); // Fill the rounded area with the gradient
        }

        // Optional: Paint border
        using (Pen pen = new Pen(Color.Black, 2))
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.DrawPath(pen, path);
        }
    }
}
