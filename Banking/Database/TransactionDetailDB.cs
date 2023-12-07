using Banking.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.Database
{
    public class TransactionDetailDB
    {
        private static TransactionDetailDB _ins;
        public static TransactionDetailDB Ins
        {
            get
            {
                if (_ins == null)
                    _ins = new TransactionDetailDB();
                return _ins;
            }
            private set => _ins = value;
        }

        private ObservableCollection<TransactionDetail> transactionDetails = new ObservableCollection<TransactionDetail>
        {
            new TransactionDetail()
            {
                TransactionDetailID = "TD0001",
                CustomerID = "KH0001",
                TransactionDetailType = 1,
                Note = "Tiền được cho từ nhà tài trợ hàng đầu Việt Nam - Ngân hàng hàng đầu thế giới - Ngân hàng bảo mật nhất thế giới - NBank",
                Created = DateTime.Now,
                Value = 10000000,
                CurrentMoney = 10000000,
            },
            new TransactionDetail()
            {
                TransactionDetailID = "TD0002",
                CustomerID = "KH0001",
                TransactionDetailType = 2,
                Note = "Tiền học bổng",
                Created = DateTime.Now,
                Value = 1000000,
                CurrentMoney = 9000000,
            },
            new TransactionDetail()
            {
                TransactionDetailID = "TD0003",
                CustomerID = "KH0001",
                TransactionDetailType = 1,
                Note = "Tiền học phí",
                Created = DateTime.Now,
                Value = 1000000,
                CurrentMoney = 10000000,
            },
            
            new TransactionDetail()
            {
                TransactionDetailID = "TD0004",
                CustomerID = "KH0001",
                TransactionDetailType = 1,
                Note = "Tiền được cho từ nhà tài trợ hàng đầu Việt Nam - Ngân hàng hàng đầu thế giới - Ngân hàng bảo mật nhất thế giới - NBank",
                Created = DateTime.Now,
                Value = 10000000,
                CurrentMoney = 20000000,
            },
        };

        public ObservableCollection<TransactionDetail> getTransactionDetails()
        {
            return transactionDetails;
        }
    }
}
