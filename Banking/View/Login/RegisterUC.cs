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
    public partial class RegisterUC : UserControl
    {
        public RegisterUC()
        {
            InitializeComponent();
        }

        private void lbLogin_Click(object sender, EventArgs e)
        {
            FormLogin currentForm = FindForm() as FormLogin;
            currentForm.loadBody(new LoginUC());
        }

        private void pibHideViewPassword_Click(object sender, EventArgs e)
        {
            if(atxbPassword.PasswordChar)
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

        private void pibHideViewRePassword_Click(object sender, EventArgs e)
        {
            if (atxbRePassword.PasswordChar)
            {
                atxbRePassword.PasswordChar = false;
                pibHideViewRePassword.BackgroundImage = Properties.Resources.hide;
            }
            else
            {
                atxbRePassword.PasswordChar = true;
                pibHideViewRePassword.BackgroundImage = Properties.Resources.view;
            }
        }

        private void abtnRegsiter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(atxbName.Texts.Trim()))
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("Không được để trống tên", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
            else if (string.IsNullOrEmpty(atxbEmail.Texts.Trim()))
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("Không được để trống email", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
            else if (string.IsNullOrEmpty(atxbPhone.Texts.Trim()))
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("Không được để trống số điện thoại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
            else if (string.IsNullOrEmpty(atxbPassword.Texts.Trim()))
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("Không được để trống mật khẩu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
            else if (string.IsNullOrEmpty(atxbRePassword.Texts.Trim()))
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("Không được để trống nhập lại mật khẩu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
            else if (atxbPassword.Texts.Trim() != atxbRePassword.Texts.Trim())
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("Nhập lại mật khẩu không đúng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
            else
            {
                Customer customer = new Customer();
                customer.CustomerName = atxbName.Texts.Trim();
                customer.Email = atxbEmail.Texts.Trim();
                customer.PhoneNumber = atxbPhone.Texts.Trim();
                customer.Password = atxbPassword.Texts.Trim();

                bool isReg = CustomerDAL.Ins.register(customer);

                if (isReg)
                {
                    AMessageBoxFrm ms = new AMessageBoxFrm("Đăng ký tài khoản thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ms.ShowDialog();
                }
                else
                {
                    AMessageBoxFrm ms = new AMessageBoxFrm("Đăng ký tài khoản thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ms.ShowDialog();
                }
            }
        }
    }
}
