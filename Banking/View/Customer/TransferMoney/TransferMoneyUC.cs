using Banking.Utils;
using QRCoder;
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

        private void TransferMoneyUC_Load(object sender, EventArgs e)
        {
            createQRcode();
        }

        private void createQRcode()
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCode qrCode = new QRCode(qrGenerator.CreateQrCode("NBank-" + Helper.getCurrentCustomer().accountNumber, QRCodeGenerator.ECCLevel.Q));
            pibQRcode.Image = qrCode.GetGraphic(2, Color.Black, Color.White, false);

            qrGenerator.Dispose();
            qrCode.Dispose();
        }
    }
}
