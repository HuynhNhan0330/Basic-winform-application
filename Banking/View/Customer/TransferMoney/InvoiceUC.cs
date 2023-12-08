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
    public partial class InvoiceUC : UserControl
    {
        private TransactionDetail _transactionDetail;
        public TransactionDetail transactionDetail
        {
            get { return _transactionDetail; }
            set
            {
                _transactionDetail = value;
                render();
            }
        }

        public InvoiceUC()
        {
            InitializeComponent();
        }

        private void pibHome_Click(object sender, EventArgs e)
        {
            FormMainCustomerWindown form = Application.OpenForms.OfType<FormMainCustomerWindown>().FirstOrDefault();
            form.loadHome();
        }

        private void render()
        {
            lbMoney.Text = Helper.FormatVNMoney(transactionDetail.Value);
            lbMoney.Left = (this.Width - lbMoney.Width) / 2;

            lbCreated.Text = transactionDetail.Created.ToString("HH:mm dd/MM/yyyy");
            lbCreated.Left = (this.Width - lbCreated.Width) / 2;

            lbName.Text = transactionDetail.receiverName;
            lbName.Left = this.Width - lbName.Width - 25;

            lbAccountNumber.Text = transactionDetail.receiverAccountNumber;
            lbAccountNumber.Left = this.Width - lbAccountNumber.Width - 25;

            lbBankName.Text = transactionDetail.receiverBankName;
            lbBankName.Left = this.Width - lbBankName.Width - 25;

            lbNote.Text = transactionDetail.Note;
            lbNote.Left = this.Width - lbNote.Width - 25;
        }
    }
}
