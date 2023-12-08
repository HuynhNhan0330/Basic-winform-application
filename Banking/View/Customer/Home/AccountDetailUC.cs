using Banking.AControls;
using Banking.DALs;
using Banking.Model;
using Banking.Utils;
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
    public partial class AccountDetailUC : UserControl
    {
        public AccountDetailUC()
        {
            InitializeComponent();
        }

        private void pibReturn_Click(object sender, EventArgs e)
        {
            FormMainCustomerWindown form = Application.OpenForms.OfType<FormMainCustomerWindown>().FirstOrDefault();
            form.removeBody(this);
        }

        private void AccountDetailUC_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            Customer customer = Helper.getCurrentCustomer();

            pibAvatar.Image = Helper.loadImagePath(customer.Avatar);

            lbName.Text = customer.CustomerName;
            lbName.Left = this.Width - 30 - lbName.Width;

            lbGender.Text = customer.Gender ? "Nam" : "Nữ";
            lbGender.Left = this.Width - 30 - lbGender.Width;

            lbDate.Text = customer.Birthday.ToString("dd/MM/yyyy");
            lbDate.Left = this.Width - 30 - lbDate.Width;

            lbEmail.Text = customer.Email;
            lbEmail.Left = this.Width - 30 - lbEmail.Width;

            lbAccountNumber.Text = customer.accountNumber;
            lbAccountNumber.Left = this.Width - 30 - lbAccountNumber.Width;

            lbMoney.Text = Helper.FormatVNMoney(customer.currentMoney);
            lbMoney.Left = this.Width - 30 - lbMoney.Width;

            lbCreated.Text = customer.Created.ToString("dd/MM/yyyy");
            lbCreated.Left = this.Width - 30 - lbCreated.Width;
        }

        private void abtnSavePassword_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(atxbNewPassword.Texts.Trim()))
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("Dữ liệu mật khẩu không được trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
            else
            {
                CustomerDAL.Ins.changePassword(Helper.getCurrentCustomer().Email, atxbNewPassword.Texts.Trim());

                AMessageBoxFrm ms = new AMessageBoxFrm("Đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ms.ShowDialog();
            }
        }

        private void pibChangeAvatar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Multiselect = false; 
            openFileDialog.Filter = "Image Files (*.jpg, *.png)|*.jpg;*.png"; 

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Customer customer = Helper.getCurrentCustomer();
                customer.Avatar = openFileDialog.FileName;

                pibAvatar.Image = Helper.loadImagePath(openFileDialog.FileName);
            }
        }
    }
}
