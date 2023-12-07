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

namespace Banking.Usercontrols
{
    public partial class StatementItemUC : UserControl
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

        public StatementItemUC()
        {
            InitializeComponent();
        }

        private void render()
        {
            lbTime.Text = transactionDetail.Created.ToString("dd/MM/yyyy");
            lbNote.Text = transactionDetail.Note;
            
            string moneyString = Helper.FormatVNMoney(transactionDetail.Value);
            
            // 1: in
            // 2: out
            switch (transactionDetail.TransactionDetailType)
            {
                case 1:
                    moneyString = "+" + moneyString;
                    lbMoney.ForeColor = BaseColor.inMoney;
                    pibType.BackgroundImage = Properties.Resources.up_arrow;
                    break;

                case 2:
                    moneyString = "-" + moneyString;
                    lbMoney.ForeColor = BaseColor.outMoney;
                    pibType.BackgroundImage = Properties.Resources.down_arrow;
                    break;
            }

            lbMoney.Text = moneyString;
            lbMoney.Left = this.Width - lbMoney.Width - 25;

            this.Height = lbNote.Height + lbNote.Top + 15 + pnLine.Height;
        }
    }
}
