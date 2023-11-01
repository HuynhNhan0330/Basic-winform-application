using System;
using System.Drawing;
using System.IO;

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
    }
}
