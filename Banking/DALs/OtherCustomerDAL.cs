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
    public class OtherCustomerDAL
    {
        private static OtherCustomerDAL _ins;
        public static OtherCustomerDAL Ins
        {
            get
            {
                if (_ins == null)
                    _ins = new OtherCustomerDAL();
                return _ins;
            }
            private set => _ins = value;
        }

        public OtherCustomer findOtherCustomer(string accountNumber, string bankName)
        {
            try
            {
                ObservableCollection<OtherCustomer> otherCustomers = OtherCustomerDB.Ins.getOtherCustomer();

                OtherCustomer otherCustomer = otherCustomers.FirstOrDefault(oc => oc.accountNumber == accountNumber && oc.BankName == bankName);

                return otherCustomer;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
