using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseWork
{
    public static class RoundedRectangle
    {
        public static GraphicsPath Create(int width, int height, int cornerRadius)
        {
            GraphicsPath path = new GraphicsPath();
            RectangleF rect = new RectangleF(0, 0, width, height);
            int diameter = cornerRadius * 2;

            // Vẽ góc bo tròn trên góc trái trên
            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
            // Vẽ góc bo tròn trên góc phải trên
            path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
            // Vẽ góc bo tròn trên góc phải dưới
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
            // Vẽ góc bo tròn trên góc trái dưới
            path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);
            // Đóng đường dẫn
            path.CloseFigure();

            return path;
        }

        public static GraphicsPath CreateRoundedTop(int width, int height, int cornerRadius)
        {
            GraphicsPath path = new GraphicsPath();
            RectangleF rect = new RectangleF(0, 0, width, height);
            int diameter = cornerRadius * 2;

            // Vẽ góc bo tròn trên góc trái trên
            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
            // Vẽ đường thẳng từ góc trái trên đến góc phải trên (không vẽ góc bo tròn)
            path.AddLine(rect.X + cornerRadius, rect.Y, rect.Right - cornerRadius, rect.Y);
            // Vẽ góc bo tròn trên góc phải trên
            path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
            // Vẽ đường thẳng từ góc phải trên đến góc phải dưới (không vẽ góc bo tròn)
            path.AddLine(rect.Right, rect.Y + cornerRadius, rect.Right, rect.Bottom);
            // Vẽ đường thẳng từ góc phải dưới đến góc trái dưới (không vẽ góc bo tròn)
            path.AddLine(rect.Right, rect.Bottom, rect.X, rect.Bottom);
            // Vẽ đường thẳng từ góc trái dưới đến góc trái trên (không vẽ góc bo tròn)
            path.AddLine(rect.X, rect.Bottom, rect.X, rect.Y + cornerRadius);
            // Đóng đường dẫn
            path.CloseFigure();

            return path;
        }

        public static GraphicsPath CreateRoundedRight(int width, int height, int cornerRadius)
        {
            GraphicsPath path = new GraphicsPath();
            RectangleF rect = new RectangleF(0, 0, width, height);
            int diameter = cornerRadius * 2;

            // Vẽ đường thẳng từ góc trái trên đến góc phải trên (không vẽ góc bo tròn)
            path.AddLine(rect.X, rect.Y, rect.Right - cornerRadius, rect.Y);
            // Vẽ góc bo tròn trên góc phải trên
            path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
            // Vẽ đường thẳng từ góc phải trên đến góc phải dưới (không vẽ góc bo tròn)
            path.AddLine(rect.Right, rect.Y + cornerRadius, rect.Right, rect.Bottom);
            // Vẽ góc bo tròn trên góc phải dưới
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
            // Vẽ đường thẳng từ góc phải dưới đến góc trái dưới (không vẽ góc bo tròn)
            path.AddLine(rect.Right, rect.Bottom, rect.X, rect.Bottom);
            // Vẽ đường thẳng từ góc trái dưới đến góc trái trên (không vẽ góc bo tròn)
            path.AddLine(rect.X, rect.Bottom, rect.X, rect.Y + cornerRadius);
            // Đóng đường dẫn
            path.CloseFigure();

            return path;
        }
    }
}
