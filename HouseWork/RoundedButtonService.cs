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
    public partial class RoundedButtonService : UserControl
    {
        public RoundedButtonService()
        {
            InitializeComponent();
        }

        public Image img 
        {   
            get { return ptbIcon.BackgroundImage; } 
            set { ptbIcon.BackgroundImage = value;}
        }

        public string text
        {
            get { return lbText.Text; }
            set { lbText.Text = value; lbText.Left = (this.Width - lbText.Width) / 2; }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            GraphicsPath path = RoundedRectangle.Create(this.Width, this.Height, 10);
            this.Region = new Region(path);

            

            base.OnPaint(e);
        }

        private void ptbIcon_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        private void lbText_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }
    }
}
