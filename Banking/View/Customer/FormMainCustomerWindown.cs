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
    public partial class FormMainCustomerWindown : Form
    {
        private AButton currentButton = null;
        private Customer _customer;
        public Customer customer
        {
            get { return _customer; }
            set { _customer = value; }
        }

        public FormMainCustomerWindown()
        {
            InitializeComponent();
        }

        public void checkNotifinotion()
        {
            bool isCheck = NotificationDAL.Ins.checkNotification(customer.CustomerID);

            if (isCheck)
                piNotification.BackgroundImage = Properties.Resources.notification;
            else
                piNotification.BackgroundImage = Properties.Resources.notification_bell;
        }

        #region Event form
        private void FormMainCustomerWindown_Load(object sender, EventArgs e)
        {
            currentButton = abtnHome;
            loadBody(new HomeUC());
            checkNotifinotion();
        }
        #endregion

        #region Top
        private void pibClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void piNotification_Click(object sender, EventArgs e)
        {
            if (currentButton != null)
            {
                doDeactiveButton(currentButton);
                currentButton = null;
            }

            piNotification.BackgroundImage = Properties.Resources.notification_bell;

            loadBody(new NotificationUC());
        }

        #endregion

        #region Menu
        private void loadBody(UserControl uc)
        {
            pnMain.Controls.Clear();
            pnMain.Controls.Add(uc);
        }

        public void addBody(UserControl uc)
        {
            pnMain.Controls.Add(uc);
            uc.BringToFront();
        }

        public void removeBody(UserControl uc)
        {
            pnMain.Controls.Remove(uc);
        }

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
                if (currentButton != null) doDeactiveButton(currentButton);
                doActiveButton(abtnChoose);
                currentButton = abtnChoose;

                loadBody(new HomeUC());
            }
        }

        private void abtnTransferMoney_Click(object sender, EventArgs e)
        {
            AButton abtnChoose = sender as AButton;

            if (abtnChoose != currentButton)
            {
                if (currentButton != null) doDeactiveButton(currentButton);
                doActiveButton(abtnChoose);
                currentButton = abtnChoose;

                loadBody(new TransferMoneyUC());
            }
        }

        private void abtnQRCode_Click(object sender, EventArgs e)
        {
            AButton abtnChoose = sender as AButton;

            if (abtnChoose != currentButton)
            {
                if (currentButton != null) doDeactiveButton(currentButton);
                doActiveButton(abtnChoose);
                currentButton = abtnChoose;

                loadBody(new QRcodeUC());
            }
        }

        private void abtnSave_Click(object sender, EventArgs e)
        {
            AButton abtnChoose = sender as AButton;

            if (abtnChoose != currentButton)
            {
                if (currentButton != null) doDeactiveButton(currentButton);
                doActiveButton(abtnChoose);
                currentButton = abtnChoose;

                loadBody(new SaveUC());
            }
        }

        private void abtnStatement_Click(object sender, EventArgs e)
        {
            AButton abtnChoose = sender as AButton;

            if (abtnChoose != currentButton)
            {
                if (currentButton != null) doDeactiveButton(currentButton);
                doActiveButton(abtnChoose);
                currentButton = abtnChoose;

                loadBody(new StatementUC());
            }
        }

        #endregion

        
    }
}
