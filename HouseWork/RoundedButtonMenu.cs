using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HouseWork
{
    public partial class RoundedButtonMenu : UserControl
    {
        public RoundedButtonMenu()
        {
            InitializeComponent();
        }

        public Image img
        {
            get { return this.pibIcon.BackgroundImage; }
            set { this.pibIcon.BackgroundImage = value; }
        }

        public string text
        {
            get { return this.lbText.Text; }
            set 
            { 
                this.lbText.Text = value;
                this.lbText.Left = (this.Width - this.lbText.Width) / 2;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            GraphicsPath path = RoundedRectangle.CreateRoundedTop(this.Width, this.Height, 10);
            this.Region = new Region(path);
            base.OnPaint(e);
        }

        private void pibIcon_Click(object sender, EventArgs e)
        {
            base.OnClick(e);
        }

        private void lbText_Click(object sender, EventArgs e)
        {
            base.OnClick(e);
        }
    }
}
