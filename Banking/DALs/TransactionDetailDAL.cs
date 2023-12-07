using Banking.Database;
using Banking.Model;
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
    }
}
