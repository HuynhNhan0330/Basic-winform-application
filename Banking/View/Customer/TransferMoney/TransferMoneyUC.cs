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
    public partial class TransferMoneyUC : UserControl
    {
        public TransferMoneyUC()
        {
            InitializeComponent();
        }

        private void abtnOut_Click(object sender, EventArgs e)
        {
            FormMainCustomerWindown form = Application.OpenForms.OfType<FormMainCustomerWindown>().FirstOrDefault();

            form.addBody(new OutTransferMoneyUC());
        }

        private void aButton1_Click(object sender, EventArgs e)
        {
            FormMainCustomerWindown form = Application.OpenForms.OfType<FormMainCustomerWindown>().FirstOrDefault();

            form.addBody(new InTransferMoneyUC());
        }
    }
}
