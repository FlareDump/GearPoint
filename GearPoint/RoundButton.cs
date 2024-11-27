using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class RoundButton : Button
{
    public int BorderRadius { get; set; } = 30; // Default radius

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        // Create a GraphicsPath to define rounded rectangle
        GraphicsPath path = new GraphicsPath();
        path.AddArc(new Rectangle(0, 0, BorderRadius, BorderRadius), 180, 90); // Top-left corner
        path.AddArc(new Rectangle(Width - BorderRadius, 0, BorderRadius, BorderRadius), 270, 90); // Top-right corner
        path.AddArc(new Rectangle(Width - BorderRadius, Height - BorderRadius, BorderRadius, BorderRadius), 0, 90); // Bottom-right corner
        path.AddArc(new Rectangle(0, Height - BorderRadius, BorderRadius, BorderRadius), 90, 90); // Bottom-left corner
        path.CloseFigure();

        // Set the button's region to this rounded path
        this.Region = new Region(path);

        // Optional: Paint border
        using (Pen pen = new Pen(Color.Black, 2))
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.DrawPath(pen, path);
        }
    }
}
