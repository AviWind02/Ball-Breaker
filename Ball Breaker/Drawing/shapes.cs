using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ball_Breaker.Drawing
{
    internal class shapes
    {

        public void DrawCircle(Graphics g, Pen pen, float centerX, float centerY, float radius)
        {
            g.DrawEllipse(pen, centerX - radius, centerY - radius, radius + radius, radius + radius);
        }

        public void FillCircle(Graphics g, Brush brush, float centerX, float centerY, float radius)
        {
            g.FillEllipse(brush, centerX - radius, centerY - radius, radius + radius, radius + radius);
        }
        public void DrawRectangle(Graphics g, Pen pen, int X, int Y, int W, int H)
        {
            g.DrawRectangle(pen, X, Y, W, H);
        }
        public void FillRectangle(Graphics g, Brush brush, int X, int Y, int W, int H)
        {
            g.FillRectangle(brush, X, Y, W, H);
        }
    }
}
