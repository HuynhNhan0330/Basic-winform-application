﻿using Banking.AControls;
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
    public partial class InTransferMoneyUC : UserControl
    {
        private Customer reCustomer = null;

        public InTransferMoneyUC()
        {
            InitializeComponent();
        }

        public InTransferMoneyUC(string accountNumber)
        {
            InitializeComponent();

            loadReAccount(accountNumber);
        }

        private void pibReturn_Click(object sender, EventArgs e)
        {
            FormMainCustomerWindown form = Application.OpenForms.OfType<FormMainCustomerWindown>().FirstOrDefault();
            form.removeBody(this);
        }

        private void InTransferMoneyUC_Load(object sender, EventArgs e)
        {
            atxbAccountNumber.Texts = Helper.getCurrentCustomer().accountNumber;
            atxbAccountNumber.Enabled = false;

            lbCurrentMoney.Text = Helper.FormatVNMoney(Helper.getCurrentCustomer().currentMoney);
            lbCurrentMoney.Left = this.Width - lbCurrentMoney.Width - 35;
            
            if (reCustomer == null) lbReName.Visible = false;
        }

        private void atxbReAccountNumber__TextChanged(object sender, EventArgs e)
        {
            reCustomer = CustomerDAL.Ins.findCustomerByAccountNumber(atxbReAccountNumber.Texts.Trim());

            if (reCustomer == null)
                lbReName.Visible = false;
            else
            {
                lbReName.Visible = true;
                lbReName.Text = reCustomer.CustomerName;
                lbReName.Left = this.Width - lbReName.Width - 35;
            }
        }

        private void abtnDone_Click(object sender, EventArgs e)
        {
            if (reCustomer == null)
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("Thông tin STK thụ hưởng chưa đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
            else if (string.IsNullOrEmpty(atxbMoney.Texts.Trim()))
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("Thông tin tiền giao dịch chưa có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
            else
            {
                TransactionDetail transactionDetail = new TransactionDetail();
                transactionDetail.CustomerID = Helper.getCurrentCustomer().CustomerID;
                transactionDetail.ReceiverID = reCustomer.CustomerID;
                transactionDetail.Note = atxbNote.Texts.Trim();
                transactionDetail.Created = DateTime.Now;
                transactionDetail.Value = int.Parse(atxbMoney.Texts.Trim());

                Customer customer = Helper.getCurrentCustomer();

                transactionDetail.CurrentMoney = customer.currentMoney - transactionDetail.Value;

                if (transactionDetail.CurrentMoney > 0)
                {
                    bool isCreate = TransactionDetailDAL.Ins.createTransactionDetail(transactionDetail);

                    if (isCreate)
                    {
                        customer.currentMoney = transactionDetail.CurrentMoney;
                        reCustomer.currentMoney = reCustomer.currentMoney + transactionDetail.Value;

                        FormMainCustomerWindown form = Application.OpenForms.OfType<FormMainCustomerWindown>().FirstOrDefault();

                        InvoiceUC ivUC = new InvoiceUC();
                        
                        transactionDetail.receiverName = reCustomer.CustomerName;
                        transactionDetail.receiverAccountNumber = reCustomer.accountNumber;
                        transactionDetail.receiverBankName = "NBank";
                        ivUC.transactionDetail = transactionDetail;

                        form.addBody(ivUC);

                        createNotification(transactionDetail);
                        form.checkNotifinotion();
                        
                    }
                    else
                    {
                        AMessageBoxFrm ms = new AMessageBoxFrm("Chuyển tiền thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ms.ShowDialog();
                    }
                }
                else
                {
                    AMessageBoxFrm ms = new AMessageBoxFrm("Số tiền hiện tại không đủ để chuyển", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ms.ShowDialog();
                }
            }
        }

        private void createNotification(TransactionDetail transactionDetail)
        {
            //customer
            Notification notificationCus = new Notification();
            Customer customer = Helper.getCurrentCustomer();
            notificationCus.CustomerID = customer.CustomerID;
            notificationCus.Note = "Số dư tài khoản " + customer.accountNumber + " -" + Helper.FormatVNMoney(transactionDetail.Value) 
                + " lúc " + transactionDetail.Created.ToString("dd/MM/yyyy hh:mm:ss") + ". Số dư " + Helper.FormatVNMoney(transactionDetail.CurrentMoney)
                + ". " + transactionDetail.Note + ".";
            notificationCus.NotificationType = 0;

            NotificationDAL.Ins.createNotification(notificationCus);

            //re
            Notification notificationRe = new Notification();
            notificationRe.CustomerID = reCustomer.CustomerID;
            notificationRe.Note = "Số dư tài khoản " + reCustomer.accountNumber + " +" + Helper.FormatVNMoney(transactionDetail.Value)
                + " lúc " + transactionDetail.Created.ToString("dd/MM/yyyy hh:mm:ss") + ". Số dư " + Helper.FormatVNMoney(reCustomer.currentMoney)
                + ". " + transactionDetail.Note + ".";
            notificationRe.NotificationType = 0;

            NotificationDAL.Ins.createNotification(notificationRe);
        }

        private void loadReAccount(string reAccountNumber)
        {
            atxbReAccountNumber.Texts = reAccountNumber;
            atxbReAccountNumber.isPlaceholder = false;
            atxbReAccountNumber.setForeColor();

            reCustomer = CustomerDAL.Ins.findCustomerByAccountNumber(reAccountNumber);

            if (reCustomer == null)
                lbReName.Visible = false;
            else
            {
                lbReName.Visible = true;
                lbReName.Text = reCustomer.CustomerName;
                lbReName.Left = this.Width - lbReName.Width - 35;
            }
        }
    }
}
