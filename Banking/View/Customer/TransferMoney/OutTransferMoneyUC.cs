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
    public partial class OutTransferMoneyUC : UserControl
    {
        private OtherCustomer reCustomer = null;

        public OutTransferMoneyUC()
        {
            InitializeComponent();
        }

        private void pibReturn_Click(object sender, EventArgs e)
        {
            FormMainCustomerWindown form = Application.OpenForms.OfType<FormMainCustomerWindown>().FirstOrDefault();

            form.removeBody(this);
        }

        private void OutTransferMoneyUC_Load(object sender, EventArgs e)
        {
            atxbAccountNumber.Texts = Helper.getCurrentCustomer().accountNumber;
            atxbAccountNumber.Enabled = false;

            lbCurrentMoney.Text = Helper.FormatVNMoney(Helper.getCurrentCustomer().currentMoney);
            lbCurrentMoney.Left = this.Width - lbCurrentMoney.Width - 35;

            lbReName.Visible = false;
        }

        private void abtnDone_Click(object sender, EventArgs e)
        {
            if (reCustomer == null)
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("Thông tin STK thụ hưởng chưa đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
            else if (string.IsNullOrEmpty(atxbMoney.Texts.Trim()))
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("Thông tin tiền giao dịch chưa có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
            else
            {
                TransactionDetail transactionDetail = new TransactionDetail();
                transactionDetail.CustomerID = Helper.getCurrentCustomer().CustomerID;
                transactionDetail.ReceiverID = reCustomer.OtherCustomerID;
                transactionDetail.Note = atxbNote.Texts.Trim();
                transactionDetail.Created = DateTime.Now;
                transactionDetail.Value = long.Parse(atxbMoney.Texts.Trim());

                Customer customer = Helper.getCurrentCustomer();

                transactionDetail.CurrentMoney = customer.currentMoney - transactionDetail.Value;

                if (transactionDetail.CurrentMoney > 0)
                {
                    bool isCreate = TransactionDetailDAL.Ins.createTransactionDetail(transactionDetail);

                    if (isCreate)
                    {
                        customer.currentMoney = transactionDetail.CurrentMoney;

                        lbCurrentMoney.Text = Helper.FormatVNMoney(Helper.getCurrentCustomer().currentMoney);
                        lbCurrentMoney.Left = this.Width - lbCurrentMoney.Width - 35;

                        AMessageBoxFrm ms = new AMessageBoxFrm("Chuyển tiền thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ms.ShowDialog();
                    }
                    else
                    {
                        AMessageBoxFrm ms = new AMessageBoxFrm("Chuyển tiền thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ms.ShowDialog();
                    }
                }
                else
                {
                    AMessageBoxFrm ms = new AMessageBoxFrm("Số tiền hiện tại không đủ để chuyển", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ms.ShowDialog();
                }
            }
        }

        private void atxbReAccountNumber__TextChanged(object sender, EventArgs e)
        {
            reCustomer = OtherCustomerDAL.Ins.findOtherCustomer(atxbReAccountNumber.Texts.Trim(), cbBankName.Text);

            if (reCustomer == null)
                lbReName.Visible = false;
            else
            {
                lbReName.Visible = true;
                lbReName.Text = reCustomer.CustomerName;
                lbReName.Left = this.Width - lbReName.Width - 35;
            }
        }
    }
}
