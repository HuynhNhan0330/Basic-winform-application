using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HouseWork
{
    public partial class FrmHomePage : Form
    {
        public FrmHomePage()
        {
            InitializeComponent();
            changePageLeftMain(new UCHome());
            changePageRightMain(new UCAccount());
        }

        private void changeSelectedLeftMenu(object sender)
        {
            Control ctl = sender as Control;
            if (ctl.Parent.Name != "pnLeftMenu")
            {
                ctl = ctl.Parent;
            }

            pnSelectedLeftMenu.Width = ctl.Width;
            pnSelectedLeftMenu.Left = ctl.Left;
        }

        private void changeSelectedRightMenu(object sender)
        {
            Control ctl = sender as Control;
            if (ctl.Parent.Name != "pnRightMenu")
            {
                ctl = ctl.Parent;
            }

            pnSelectedRightMenu.Width = ctl.Width;
            pnSelectedRightMenu.Left = ctl.Left;
        }

        private void changePageLeftMain(UserControl UC)
        {
            pnLeftMain.Controls.Clear();
            pnLeftMain.Controls.Add(UC);
        }

        private void changePageRightMain(UserControl UC)
        {
            pnRightMain.Controls.Clear();
            pnRightMain.Controls.Add(UC);
        }

        private void IcClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnHome_Click(object sender, EventArgs e)
        {
            changeSelectedLeftMenu(sender);
            changePageLeftMain(new UCHome());
        }

        private void pnService_Click(object sender, EventArgs e)
        {
            changeSelectedLeftMenu(sender);
            changePageLeftMain(new UCService());
        }

        private void pnContact_Click(object sender, EventArgs e)
        {
            changeSelectedLeftMenu(sender);
            changePageLeftMain(new UCContact());
        }

        private void pnDiscount_Click(object sender, EventArgs e)
        {
            changeSelectedLeftMenu(sender);
            changePageLeftMain(new UCDiscount());
        }

        private void pnDonate_Click(object sender, EventArgs e)
        {
            changeSelectedLeftMenu(sender);
            changePageLeftMain(new UCDonate());
        }

        private void pnAccount_Click(object sender, EventArgs e)
        {
            changeSelectedRightMenu(sender);
            changePageRightMain(new UCAccount());
        }

        private void pnLogin_Click(object sender, EventArgs e)
        {
            changeSelectedRightMenu(sender);
            changePageRightMain(new UCLogin());
        }

        private void pnRegister_Click(object sender, EventArgs e)
        {
            changeSelectedRightMenu(sender);
            changePageRightMain(new UCRegister());
        }
    }
}
