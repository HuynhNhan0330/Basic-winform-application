﻿using Banking.AControls;
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
        }

        private void loadData(int type = 0)
        {
            

            switch (type)
            {
                case 0:
                    __transactionDetails = TransactionDetailDAL.Ins.getTransactionDetails();
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
            }
        }
    }
}
