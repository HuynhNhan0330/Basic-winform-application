using Banking.AControls;
using Banking.DALs;
using Banking.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banking
{
    public partial class LoginUC : UserControl
    {
        public LoginUC()
        {
            InitializeComponent();
        }

        private void abtnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(atxbUsername.Texts.Trim()))
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("Không được để trống tài khoản", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
            else if (string.IsNullOrEmpty(atxbPassword.Texts.Trim()))
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("Không được để trống tài khoản", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
            else
            {
                Customer customer = CustomerDAL.Ins.checkLogin(atxbUsername.Texts.Trim(), atxbPassword.Texts.Trim());

                if (customer != null)
                {
                    var currentForm = FindForm();
                    currentForm.Hide();

                    FormMainCustomerWindown frmHome = new FormMainCustomerWindown();
                    frmHome.ShowDialog();

                    currentForm.Show();
                }
                else
                {
                    AMessageBoxFrm ms = new AMessageBoxFrm("Tài khoản hoặc mật khẩu không đúng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ms.ShowDialog();
                }
            }
        }

        private void lbRegister_Click(object sender, EventArgs e)
        {
            FormLogin currentForm = FindForm() as FormLogin;
            currentForm.loadBody(new RegisterUC());
        }

        private void pibHideViewPassword_Click(object sender, EventArgs e)
        {
            if (atxbPassword.PasswordChar)
            {
                atxbPassword.PasswordChar = false;
                pibHideViewPassword.BackgroundImage = Properties.Resources.hide;
            }
            else
            {
                atxbPassword.PasswordChar = true;
                pibHideViewPassword.BackgroundImage = Properties.Resources.view;
            }
        }
    }
}
