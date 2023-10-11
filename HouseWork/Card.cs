using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HouseWork
{
    public partial class Card : UserControl
    {
        public Card()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            GraphicsPath path = RoundedRectangle.Create(this.Width, this.Height, 10);
            this.Region = new Region(path);

            // Tạo một Pen mới với màu sắc và độ dày mong muốn
            Pen pen = new Pen(Color.FromArgb(63, 101, 174), 3);
            Graphics graphics = e.Graphics;
            // Vẽ đường viền bằng GraphicsPath và Pen
            graphics.DrawPath(pen, path);

            base.OnPaint(e);
        }
    }
}
