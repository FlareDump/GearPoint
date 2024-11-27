using System;
using System.Drawing;
using System.Windows.Forms;

public class TransparentPanel : Panel
{
    // Property to set opacity, range 0.0 (fully transparent) to 1.0 (fully opaque)
    private float _opacity = 0.5f;
    public float Opacity
    {
        get { return _opacity; }
        set
        {
            _opacity = value;
            this.Invalidate(); // Redraw the panel when opacity changes
        }
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        // Create a semi-transparent brush using the panel's background color
        Color bgColor = Color.FromArgb((int)(Opacity * 255), this.BackColor);
        using (SolidBrush brush = new SolidBrush(bgColor))
        {
            e.Graphics.FillRectangle(brush, this.ClientRectangle);
        }
    }
}
