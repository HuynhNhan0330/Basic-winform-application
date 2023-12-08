using Banking.AControls;
using Banking.DALs;
using Banking.Database;
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
    public partial class SaveUC : UserControl
    {
        public SaveUC()
        {
            InitializeComponent();
        }

        private void saveUC_Load(object sender, EventArgs e)
        {
            cbTern.SelectedIndex = 0;
            cbType.SelectedIndex = 0;

            atxbAccountNumber.Texts = Helper.getCurrentCustomer().accountNumber;
            atxbAccountNumber.Enabled = false;

            lbCurrentMoney.Text = Helper.FormatVNMoney(Helper.getCurrentCustomer().currentMoney);
            lbCurrentMoney.Left = this.Width - lbCurrentMoney.Width - 35;
        }

        private void abtnDone_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(atxbMoney.Texts.Trim()))
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("Dữ liệu tiền không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
            else if (decimal.Parse(atxbMoney.Texts.Trim()) > Helper.getCurrentCustomer().currentMoney || decimal.Parse(atxbMoney.Texts.Trim()) < 0)
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("Số tiền không phù hợp", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
            else
            {
                SaveBook saveBook = new SaveBook();
                saveBook.CustomerID = Helper.getCurrentCustomer().CustomerID;
                saveBook.Money = decimal.Parse(atxbMoney.Texts.Trim());
                saveBook.Tern = cbTern.Text;
                saveBook.Type = cbType.Text;
                saveBook.Created = DateTime.Now;

                saveBook = SaveBookDAL.Ins.createSaveBook(saveBook);

                if (saveBook != null)
                {
                    Customer customer = Helper.getCurrentCustomer();
                    customer.currentMoney -= saveBook.Money;

                    saveBook.CustomerName = customer.CustomerName;
                    saveBook.CustomerAccountNumber = customer.accountNumber;

                    FormMainCustomerWindown form = Application.OpenForms.OfType<FormMainCustomerWindown>().FirstOrDefault();
                    
                    InvoiceSaveBookUC insbUC = new InvoiceSaveBookUC();
                    insbUC.saveBook = saveBook;

                    form.addBody(insbUC);

                    createNotification(saveBook);
                    form.checkNotifinotion();

                    createTransactionDetail(saveBook);
                }
            }
        }

        private void createNotification(SaveBook saveBook)
        {
            Notification notificationCus = new Notification();
            Customer customer = Helper.getCurrentCustomer();
            notificationCus.CustomerID = customer.CustomerID;
            notificationCus.Note = "Số dư tài khoản " + customer.accountNumber + " -" + Helper.FormatVNMoney(saveBook.Money)
            + " lúc " + saveBook.Created.ToString("dd/MM/yyyy hh:mm:ss") + ". Số dư " + Helper.FormatVNMoney(customer.currentMoney)
            + ". Tạo sổ tiết kiệm mới - " + saveBook.Tern + " - " + saveBook.Type + ".";
            notificationCus.NotificationType = 0;

            NotificationDAL.Ins.createNotification(notificationCus);
        }

        private void createTransactionDetail(SaveBook saveBook)
        {
            TransactionDetail transactionDetail = new TransactionDetail();
            transactionDetail.CustomerID = Helper.getCurrentCustomer().CustomerID;
            transactionDetail.Note = "Tạo ví tiết kiệm";
            transactionDetail.Created = DateTime.Now;
            transactionDetail.Value = saveBook.Money;
            transactionDetail.CurrentMoney = Helper.getCurrentCustomer().currentMoney;

            TransactionDetailDAL.Ins.createTransactionDetail(transactionDetail);
        }
    }
}
