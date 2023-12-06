using Banking.AControls;
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
    public partial class FormMainCustomerWindown : Form
    {
        private AButton currentButton = null;

        public FormMainCustomerWindown()
        {
            InitializeComponent();
        }



        #region Event form
        private void FormMainCustomerWindown_Load(object sender, EventArgs e)
        {
            currentButton = abtnHome;
        }
        #endregion

        #region Top
        private void pibClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Menu
        private void doActiveButton(AButton abtn)
        {
            abtn.BackColor = BaseColor.XanhLa;
            abtn.ForeColor = Color.White;

            switch (abtn.Name)
            {
                case "abtnHome":
                    abtn.Image = Properties.Resources.homeActive;
                    break;

                case "abtnTransferMoney":
                    abtn.Image = Properties.Resources.transfer;
                    break;

                case "abtnQRCode":
                    abtn.Image = Properties.Resources.qrCodeActive;
                    break;

                case "abtnSave":
                    abtn.Image = Properties.Resources.saveMoneyActive;
                    break;

                case "abtnStatement":
                    abtn.Image = Properties.Resources.fileActive;
                    break;
            }
        }

        private void doDeactiveButton(AButton abtn)
        {
            abtn.BackColor = Color.Transparent;
            abtn.ForeColor = BaseColor.Xam;

            switch (abtn.Name)
            {
                case "abtnHome":
                    abtn.Image = Properties.Resources.homDeactive;
                    break;

                case "abtnTransferMoney":
                    abtn.Image = Properties.Resources.transferDeactive;
                    break;

                case "abtnQRCode":
                    abtn.Image = Properties.Resources.qrCodeDeactive;
                    break;

                case "abtnSave":
                    abtn.Image = Properties.Resources.saveMoneyDeactive;
                    break;

                case "abtnStatement":
                    abtn.Image = Properties.Resources.fileDeactive;
                    break;
            }
        }

        private void abtnHome_Click(object sender, EventArgs e)
        {
            AButton abtnChoose = sender as AButton;

            if (abtnChoose != currentButton)
            {
                doDeactiveButton(currentButton);
                doActiveButton(abtnChoose);
                currentButton = abtnChoose;
            }
        }

        private void abtnTransferMoney_Click(object sender, EventArgs e)
        {
            AButton abtnChoose = sender as AButton;

            if (abtnChoose != currentButton)
            {
                doDeactiveButton(currentButton);
                doActiveButton(abtnChoose);
                currentButton = abtnChoose;
            }
        }

        private void abtnQRCode_Click(object sender, EventArgs e)
        {
            AButton abtnChoose = sender as AButton;

            if (abtnChoose != currentButton)
            {
                doDeactiveButton(currentButton);
                doActiveButton(abtnChoose);
                currentButton = abtnChoose;
            }
        }

        private void abtnSave_Click(object sender, EventArgs e)
        {
            AButton abtnChoose = sender as AButton;

            if (abtnChoose != currentButton)
            {
                doDeactiveButton(currentButton);
                doActiveButton(abtnChoose);
                currentButton = abtnChoose;
            }
        }

        private void abtnStatement_Click(object sender, EventArgs e)
        {
            AButton abtnChoose = sender as AButton;

            if (abtnChoose != currentButton)
            {
                doDeactiveButton(currentButton);
                doActiveButton(abtnChoose);
                currentButton = abtnChoose;
            }
        }
        #endregion

        
    }
}
