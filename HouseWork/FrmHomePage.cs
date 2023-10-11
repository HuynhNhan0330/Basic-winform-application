using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HouseWork
{
    public partial class FrmHomePage : Form
    {
        public bool isLogin {  get; set; }

        public FrmHomePage()
        {
            InitializeComponent();
            changePageMain(new UCHome());
            this.isLogin = false;

            btnrAccount.Visible = false;
            btnrLogout.Visible = false;
        }

        private void activeButton(UserControl UC)
        {
            UC.BackColor = Color.FromArgb(237, 238, 253);
            UC.ForeColor = Color.FromArgb(52, 53, 91);
        }

        private void deactivateButton(UserControl UC)
        {
            UC.BackColor = Color.Transparent;
            UC.ForeColor = Color.FromArgb(30, 30, 31);
        }

        private void deactivateAllButton()
        {
            foreach(UserControl uc in this.pnLeftMenu.Controls)
            {
                deactivateButton(uc);
            }

            foreach (UserControl uc in this.pnRightMenu.Controls)
            {
                deactivateButton(uc);
            }
        }

        private void changePageMain(UserControl UC)
        {
            pnMain.Controls.Clear();
            pnMain.Controls.Add(UC);
        }

        public void resetButtonOfRightMenu()
        {
            btnrAccount.Visible = !btnrAccount.Visible;
            btnrLogout.Visible = !btnrLogout.Visible;
            btnrLogin.Visible = !btnrLogin.Visible;
            btnrRegister.Visible = !btnrRegister.Visible;
        }

        private void IcClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmHomePage_Load(object sender, EventArgs e)
        {
            this.btnrHome.text = "Trang chủ";

            this.btnrService.img = Properties.Resources.NotifitionIcon;
            this.btnrService.text = "Dịch vụ";

            this.btnrContact.img = Properties.Resources.EmailMessageIcon;
            this.btnrContact.text = "Liên hệ";

            this.btnrDiscount.img = Properties.Resources.DiscountIcon;
            this.btnrDiscount.text = "Giảm giá";

            this.btnrAccount.img = Properties.Resources.AccountIcon;
            this.btnrAccount.text = "Tài khoản";

            this.btnrLogout.img = Properties.Resources.logoutIcon;
            this.btnrLogout.text = "Đăng xuất";

            this.btnrLogin.text = "Đăng nhập";

            this.btnrRegister.text = "Đăng ký";

            GraphicsPath path = RoundedRectangle.Create(this.Width, this.Height, 5);
            this.Region = new Region(path);
        }

        private void btnrHome_Click(object sender, EventArgs e)
        {
            deactivateAllButton();
            activeButton(this.btnrHome);
            changePageMain(new UCHome());
        }

        private void btnrService_Click(object sender, EventArgs e)
        {
            deactivateAllButton();
            activeButton(this.btnrService);
            changePageMain(new UCService());
        }

        private void btnrContact_Click(object sender, EventArgs e)
        {
            deactivateAllButton();
            activeButton(this.btnrContact);
            changePageMain(new UCContact());
        }

        private void btnrDiscount_Click(object sender, EventArgs e)
        {
            deactivateAllButton();
            activeButton(this.btnrDiscount);
            changePageMain(new UCDiscount());
        }

        public void btnrAccount_Click(object sender, EventArgs e)
        {
            deactivateAllButton();
            activeButton(this.btnrAccount);
            changePageMain(new UCAccount());
        }

        private void btnrLogout_Click(object sender, EventArgs e)
        {
            Form frmms = new FrmMessageBox("Bạn chắc chắn muốn đăng xuất?", "Đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (frmms.ShowDialog() == DialogResult.Yes)
            {
                resetButtonOfRightMenu();
                btnrLogin_Click(sender, e);
            }
        }

        private void btnrLogin_Click(object sender, EventArgs e)
        {
            deactivateAllButton();
            activeButton(this.btnrLogin);
            changePageMain(new UCLogin());
        }

        private void btnrRegister_Click(object sender, EventArgs e)
        {
            deactivateAllButton();
            activeButton(this.btnrRegister);
            changePageMain(new UCRegister());
        }
    }
}
