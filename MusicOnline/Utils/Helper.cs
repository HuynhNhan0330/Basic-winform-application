using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MusicOnline.Utils
{
    public class Helper
    {
        public static Image loadImagePath(string path)
        {
            try
            {
                Image img = Image.FromFile(path);
                return img;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Đã xảy ra lỗi: " + ex.Message);
                return null;
            }
        }

        public static int GetTextHeight(Label lbl)
        {
            using (Graphics g = lbl.CreateGraphics())
            {
                SizeF size = g.MeasureString(lbl.Text, lbl.Font, 350);
                return (int)Math.Ceiling(size.Height);
            }
        }
    }
}
