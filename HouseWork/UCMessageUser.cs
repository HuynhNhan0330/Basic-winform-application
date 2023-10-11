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
    public partial class UCMessageUser : UserControl
    {
        public UCMessageUser()
        {
            InitializeComponent();
        }

        public string Body
        {
            get { return lbText.Text; }
            set { lbText.Text = value; render(); }
        }

        public void render()
        {
            lbText.Height = Utils.GetTextHeight(lbText) + 10;
            
            this.Height = lbText.Top + lbText.Height;
        }

        public void updateLeftChat(int rightLabel)
        {
            lbText.Left = this.Width - lbText.Width - rightLabel;
        }

        private void lbText_Paint(object sender, PaintEventArgs e)
        {
            GraphicsPath path = RoundedRectangle.Create(this.lbText.Width, this.lbText.Height, 5);
            this.lbText.Region = new Region(path);
        }
    }
}
