using System;
using System.CodeDom;
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
    public partial class UCAccount : UserControl
    {
        public UCAccount()
        {
            InitializeComponent();
        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txbPassword.UseSystemPasswordChar = !txbPassword.UseSystemPasswordChar;
        }

        private void UCAccount_Load(object sender, EventArgs e)
        {
            GraphicsPath path = RoundedRectangle.Create(this.pnLogin.Width, this.pnLogin.Height, 20);
            this.pnLogin.Region = new Region(path);

            foreach (Control ctr in this.pnLogin.Controls)
            {
                if (ctr is Panel || ctr is Button)
                {
                    path = RoundedRectangle.Create(ctr.Width, ctr.Height, 10);
                    ctr.Region = new Region(path);

                    if (ctr is Panel)
                    {
                        foreach (Control ctrc in ctr.Controls)
                        {
                            if (ctrc is Panel)
                            {
                                path = RoundedRectangle.Create(ctrc.Width, ctrc.Height, 7);
                                ctrc.Region = new Region(path);

                                // Tạo một Pen mới với màu sắc và độ dày mong muốn
                                Pen pen = new Pen(Color.FromArgb(194, 247, 255), 3);
                                using (Graphics graphics = ctrc.CreateGraphics())
                                {
                                    graphics.DrawPath(pen, path);
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
