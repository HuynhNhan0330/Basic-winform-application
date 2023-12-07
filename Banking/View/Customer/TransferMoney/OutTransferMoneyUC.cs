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
        public OutTransferMoneyUC()
        {
            InitializeComponent();
        }

        private void pibReturn_Click(object sender, EventArgs e)
        {
            FormMainCustomerWindown form = Application.OpenForms.OfType<FormMainCustomerWindown>().FirstOrDefault();

            form.removeBody(this);
        }
    }
}
