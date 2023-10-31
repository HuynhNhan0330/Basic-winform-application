using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicOnline.AControls
{
    public class AVScrollBar: VScrollBar
    {
        private Color _x1 = Color.LightGray;

        [Category("Extention")]
        public Color x1
        {
            get { return _x1; }
            set
            {
                _x1 = value;
                this.Invalidate();
            }
        }

        private Color _x2 = Color.DarkGray;

        [Category("Extention")]
        public Color x2
        {
            get { return _x2; }
            set
            {
                _x2 = value;
                this.Invalidate();
            }
        }

        public AVScrollBar()
        {
            this.Width = 20;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Vẽ phần background của thanh cuộn
            Rectangle backgroundRect = new Rectangle(0, 0, this.Width, this.Height);
            e.Graphics.FillRectangle(new SolidBrush(this.x1), backgroundRect);

            // Vẽ phần thumb của thanh cuộn
            int thumbHeight = CalculateThumbHeight();
            Rectangle thumbRect = new Rectangle(0, CalculateThumbPosition(), this.Width, thumbHeight);
            e.Graphics.FillRectangle(new SolidBrush(this.x2), thumbRect);

            // Vẽ phần track của thanh cuộn
            Rectangle trackRect = new Rectangle(0, 0, this.Width, this.Height);
            e.Graphics.DrawRectangle(new Pen(this.ForeColor), trackRect);
        }

        private int CalculateThumbHeight()
        {
            int totalHeight = this.Height - 2 * SystemInformation.VerticalScrollBarArrowHeight;
            int maxThumbHeight = (int)Math.Floor((double)totalHeight * (double)this.LargeChange / (double)(this.Maximum - this.Minimum + this.LargeChange));
            return Math.Max(maxThumbHeight, SystemInformation.VerticalScrollBarThumbHeight);
        }

        private int CalculateThumbPosition()
        {
            int totalHeight = this.Height - 2 * SystemInformation.VerticalScrollBarArrowHeight;
            int maxThumbHeight = (int)Math.Floor((double)totalHeight * (double)this.LargeChange / (double)(this.Maximum - this.Minimum + this.LargeChange));
            int totalThumbHeight = Math.Max(maxThumbHeight, SystemInformation.VerticalScrollBarThumbHeight);
            return SystemInformation.VerticalScrollBarArrowHeight + (int)Math.Floor((double)(totalHeight - totalThumbHeight) * (double)this.Value / (double)(this.Maximum - this.Minimum));
        }
    }
}
