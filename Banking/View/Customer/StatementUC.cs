using Banking.AControls;
using Banking.DALs;
using Banking.Model;
using Banking.Usercontrols;
using Banking.Utils;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banking
{
    public partial class StatementUC : UserControl
    {
        private AButton currentButton = null;

        public StatementUC()
        {
            InitializeComponent();
        }


        #region menu
        private void doActiveButton(AButton abtn)
        {
            abtn.LineType = AButton.LineStyles.Bottom;
            abtn.ForeColor = BaseColor.XanhLa;
        }

        private void doDeactiveButton(AButton abtn)
        {
            abtn.LineType = AButton.LineStyles.None;
            abtn.ForeColor = BaseColor.Xam;
        }

        private void abtnAll_Click(object sender, EventArgs e)
        {
            AButton abtnChoose = sender as AButton;

            if (abtnChoose != currentButton)
            {
                doDeactiveButton(currentButton);
                doActiveButton(abtnChoose);
                currentButton = abtnChoose;
            }
        }

        private void abtnOut_Click(object sender, EventArgs e)
        {
            AButton abtnChoose = sender as AButton;

            if (abtnChoose != currentButton)
            {
                doDeactiveButton(currentButton);
                doActiveButton(abtnChoose);
                currentButton = abtnChoose;
            }
        }

        private void abtnIn_Click(object sender, EventArgs e)
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

        private void StatementUC_Load(object sender, EventArgs e)
        {
            currentButton = abtnAll;
            loadData();
        }

        private void loadData()
        {
            ObservableCollection<TransactionDetail> transactionDetails = TransactionDetailDAL.Ins.getTransactionDetails();

            foreach (TransactionDetail td in transactionDetails)
            {
                StatementItemUC uc = new StatementItemUC();
                uc.transactionDetail = td;
                pnMain.Controls.Add(uc);
                uc.Dock = DockStyle.Top;
                uc.SendToBack();
            }
        }
    }
}
