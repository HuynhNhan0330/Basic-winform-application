using Banking.AControls;
using Banking.DALs;
using Banking.Database;
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
using System.Windows.Forms.DataVisualization.Charting;

namespace Banking
{
    public partial class StatementUC : UserControl
    {
        private AButton currentButton = null;
        private ObservableCollection<TransactionDetail> __transactionDetails;
        private ObservableCollection<TransactionDetail> _transactionDetails;
        private ObservableCollection<TransactionDetail> transactionDetails;

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
                loadData(1);
                loadPanelData();
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
                loadData(2);
                loadPanelData();
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
                loadData(3);
                loadPanelData();
            }
        }
        #endregion

        private void StatementUC_Load(object sender, EventArgs e)
        {
            currentButton = abtnAll;
            loadData();
            loadPanelData();
            loadChart();
        }

        private void loadData(int type = 0)
        {
            switch (type)
            {
                case 0:
                    // Mình là người nhận (in): 1
                    // Mình là người chuyển (out): 2

                    ObservableCollection<TransactionDetail> transactionDetailsOut = TransactionDetailDAL.Ins.getTransactionDetailsByCustomer(Helper.getCurrentCustomer().CustomerID);
                    ObservableCollection<TransactionDetail> transactionDetailsIn = TransactionDetailDAL.Ins.getTransactionDetailsByReceiver(Helper.getCurrentCustomer().CustomerID);

                    __transactionDetails = new ObservableCollection<TransactionDetail>();
                    
                    foreach (TransactionDetail td in transactionDetailsOut)
                    {
                        td.TransactionDetailType = 2;
                        __transactionDetails.Add(td);
                    }

                    foreach (TransactionDetail td in transactionDetailsIn)
                    {
                        td.TransactionDetailType = 1;
                        __transactionDetails.Add(td);
                    }
                    __transactionDetails = new ObservableCollection<TransactionDetail>(__transactionDetails.OrderBy(td => td.TransactionDetailID));
                    _transactionDetails = new ObservableCollection<TransactionDetail>(__transactionDetails);
                    transactionDetails = new ObservableCollection<TransactionDetail>(_transactionDetails);
                    break;

                case 1:
                    transactionDetails = new ObservableCollection<TransactionDetail>(_transactionDetails);
                    break;
                case 2:
                    transactionDetails.Clear();

                    foreach (TransactionDetail td in _transactionDetails)
                        if (td.TransactionDetailType == 2) transactionDetails.Add(td);
                    break;

                case 3:
                    transactionDetails.Clear();

                    foreach (TransactionDetail td in _transactionDetails)
                        if (td.TransactionDetailType == 1) transactionDetails.Add(td);
                    break;
            }

        }

        private void loadPanelData()
        {
            pnMain.Controls.Clear();

            foreach (TransactionDetail td in transactionDetails)
            {
                StatementItemUC uc = new StatementItemUC();
                uc.transactionDetail = td;
                pnMain.Controls.Add(uc);
                uc.Dock = DockStyle.Top;
                uc.SendToBack();
            }
        }

        private void abtnSearch_Click(object sender, EventArgs e)
        {
            DateTime valueFrom = adpFrom.Value; 
            DateTime valueTo = adpTo.Value;
            
            if (valueFrom.Date > valueTo.Date)
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("Ngày trước phải nhỏ hơn ngày sau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
            else
            {
                _transactionDetails.Clear();

                foreach (TransactionDetail td in __transactionDetails)
                    if ((valueFrom.Date <= td.Created.Date && td.Created.Date <= valueTo.Date)) _transactionDetails.Add(td);

                transactionDetails = new ObservableCollection<TransactionDetail>(_transactionDetails);

                doDeactiveButton(currentButton);
                doActiveButton(abtnAll);
                currentButton = abtnAll;

                loadPanelData();
                loadChart();
            }
        }

        private void loadChart()
        {
            decimal inMoney = 0;
            decimal outMoney = 0;

            foreach (TransactionDetail td in transactionDetails)
            {
                if (td.TransactionDetailType == 1)
                    inMoney += td.Value;
                else
                    outMoney += td.Value;
            }

            KeyValuePair<string, decimal>[] data = new KeyValuePair<string, decimal>[]
            {
                new KeyValuePair<string, decimal>("Tiền vào", inMoney),
                new KeyValuePair<string, decimal>("Tiền ra", outMoney),
            };

            chart.DataSource = data;
            chart.Series[0].XValueMember = "Key";
            chart.Series[0].YValueMembers = "Value";
            chart.DataBind();
            chart.Update();
        }
    }
}
