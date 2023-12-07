using Banking.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.Database
{
    public class OtherCustomerDB
    {
        private static OtherCustomerDB _ins;
        public static OtherCustomerDB Ins
        {
            get
            {
                if (_ins == null)
                    _ins = new OtherCustomerDB();
                return _ins;
            }
            private set => _ins = value;
        }

        private ObservableCollection<OtherCustomer> otherCustomers = new ObservableCollection<OtherCustomer>
        {
            new OtherCustomer()
            {
                OtherCustomerID = "OC0001",
                BankName = "Vietcomebank",
                accountNumber = "123123123"
            },
            new OtherCustomer()
            {
                OtherCustomerID = "OC0002",
                BankName = "Vietcomebank",
                accountNumber = "124124124"
            },
            new OtherCustomer()
            {
                OtherCustomerID = "OC0003",
                BankName = "Viettinbank",
                accountNumber = "125125125"
            },
            new OtherCustomer()
            {
                OtherCustomerID = "OC0004",
                BankName = "Abbank",
                accountNumber = "126126126"
            },
        };

        public ObservableCollection<OtherCustomer> getOtherCustomer()
        {
            return otherCustomers;
        }
    }
}
