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
            
            if (lbText.Height <= pcbAvatar.Height - 10)
            {
                lbText.Top = (pcbAvatar.Height - 10) / 2 + pcbAvatar.Top - 6;
            }

            if (lbText.Height <= pcbAvatar.Height - 10)
            {
                this.Height = pcbAvatar.Height;
            }
            else
            {
                this.Height = lbText.Top + lbText.Height + 2;
            }
        }

        public void updateLeftControl(int rightLabel)
        {
            pcbAvatar.Left = this.Width - pcbAvatar.Width - rightLabel + 5;
            lbText.Left = this.Width - lbText.Width - rightLabel - pcbAvatar.Width + 2;
        }

        private void lbText_Paint(object sender, PaintEventArgs e)
        {
            GraphicsPath path = RoundedRectangle.Create(this.lbText.Width, this.lbText.Height, 5);
            this.lbText.Region = new Region(path);
        }
    }
}
