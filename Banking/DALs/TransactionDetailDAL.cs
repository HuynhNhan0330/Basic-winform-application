using Banking.Database;
using Banking.Model;
using Banking.Utils;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.DALs
{
    public class TransactionDetailDAL
    {
        private static TransactionDetailDAL _ins;
        public static TransactionDetailDAL Ins
        {
            get
            {
                if (_ins == null)
                    _ins = new TransactionDetailDAL();
                return _ins;
            }
            private set => _ins = value;
        }

        public ObservableCollection<TransactionDetail> getTransactionDetails()
        {
            return TransactionDetailDB.Ins.getTransactionDetails();
        }

        public ObservableCollection<TransactionDetail> getTransactionDetailsByCustomer(string customerID)
        {
            try
            {
                ObservableCollection<TransactionDetail> transactionDetails = TransactionDetailDB.Ins.getTransactionDetails();
                ObservableCollection<TransactionDetail> transactionDetailsNew = new ObservableCollection<TransactionDetail>(transactionDetails.Where(td => td.CustomerID == customerID));

                return transactionDetailsNew;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public ObservableCollection<TransactionDetail> getTransactionDetailsByReceiver(string customerID)
        {
            try
            {
                ObservableCollection<TransactionDetail> transactionDetails = TransactionDetailDB.Ins.getTransactionDetails();
                ObservableCollection<TransactionDetail> transactionDetailsNew = new ObservableCollection<TransactionDetail>(transactionDetails.Where(td => td.ReceiverID == customerID));

                return transactionDetailsNew;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public bool createTransactionDetail(TransactionDetail transactionDetail)
        {
            try
            {
                transactionDetail.TransactionDetailID = Helper.nextCode(TransactionDetailDB.Ins.getMaxId(), "TD");
                return TransactionDetailDB.Ins.createTransactionDetail(transactionDetail);
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
