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
    public partial class UCLogin : UserControl
    {
        public UCLogin()
        {
            InitializeComponent();
        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txbPassword.UseSystemPasswordChar = !txbPassword.UseSystemPasswordChar;
        }

        private void UCLogin_Load(object sender, EventArgs e)
        {
            GraphicsPath path = RoundedRectangle.Create(this.pnLogin.Width, this.pnLogin.Height, 20);
            this.pnLogin.Region = new Region(path);

            path = RoundedRectangle.Create(this.pnAccount.Width, this.pnAccount.Height, 10);
            this.pnAccount.Region = new Region(path);

            path = RoundedRectangle.Create(this.pnPassword.Width, this.pnPassword.Height, 10);
            this.pnPassword.Region = new Region(path);

            path = RoundedRectangle.Create(this.btnLogin.Width, this.btnLogin.Height, 10);
            this.btnLogin.Region = new Region(path);

            path = RoundedRectangle.Create(this.pnAcountChild.Width, this.pnAcountChild.Height, 7);
            this.pnAcountChild.Region = new Region(path);

            using (Graphics graphics = this.pnAcountChild.CreateGraphics())
            {
                Pen pen = new Pen(Color.FromArgb(194, 247, 255), 3);
                graphics.DrawPath(pen, path);
            }

            path = RoundedRectangle.Create(this.pnPasswordChild.Width, this.pnPasswordChild.Height, 7);
            this.pnPasswordChild.Region = new Region(path);

            using (Graphics graphics = this.pnPasswordChild.CreateGraphics())
            {
                Pen pen = new Pen(Color.FromArgb(194, 247, 255), 3);
                graphics.DrawPath(pen, path);
            }

            path = RoundedRectangle.Create(this.btnGoogle.Width, this.btnGoogle.Height, 7);
            this.btnGoogle.Region = new Region(path);

            path = RoundedRectangle.Create(this.btnFacebook.Width, this.btnFacebook.Height, 7);
            this.btnFacebook.Region = new Region(path);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Form currentForm = this.ParentForm;
            ((FrmHomePage)currentForm).resetButtonOfRightMenu();
            ((FrmHomePage)currentForm).btnrAccount_Click(sender, e);
        }

        
    }
}
