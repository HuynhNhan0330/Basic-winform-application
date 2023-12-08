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
    public partial class InvoiceSaveBookUC : UserControl
    {
        private SaveBook _saveBook;
        public SaveBook saveBook
        {
            get { return _saveBook; }
            set
            {
                _saveBook = value;
                render();
            }
        }

        public InvoiceSaveBookUC()
        {
            InitializeComponent();
        }

        private void render()
        {
            lbMoney.Text = Helper.FormatVNMoney(saveBook.Money);
            lbMoney.Left = (this.Width - lbMoney.Width) / 2;

            lbCreated.Text = saveBook.Created.ToString("HH:mm dd/MM/yyyy");
            lbCreated.Left = (this.Width - lbCreated.Width) / 2;

            lbName.Text = saveBook.CustomerName;
            lbName.Left = this.Width - lbName.Width - 25;

            lbAccountNumber.Text = saveBook.CustomerAccountNumber;
            lbAccountNumber.Left = this.Width - lbAccountNumber.Width - 25;

            lbTern.Text = saveBook.Tern;
            lbTern.Left = this.Width - lbTern.Width - 25;

            lbType.Text = saveBook.Type;
            lbType.Left = this.Width - lbType.Width - 25;
        }

        private void pibHome_Click(object sender, EventArgs e)
        {
            FormMainCustomerWindown form = Application.OpenForms.OfType<FormMainCustomerWindown>().FirstOrDefault();
            form.loadHome();
        }
    }
}
