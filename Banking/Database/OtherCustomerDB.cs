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
                CustomerName = "Tri Nguyen",
                accountNumber = "123123123"
            },
            new OtherCustomer()
            {
                OtherCustomerID = "OC0002",
                BankName = "Vietcomebank",
                CustomerName = "Tri Do",
                accountNumber = "124124124"
            },
            new OtherCustomer()
            {
                OtherCustomerID = "OC0003",
                BankName = "Viettinbank",
                CustomerName = "Tri Hay",
                accountNumber = "125125125"
            },
            new OtherCustomer()
            {
                OtherCustomerID = "OC0004",
                BankName = "Abbank",
                CustomerName = "Tri Huyen",
                accountNumber = "126126126"
            },
        };

        public ObservableCollection<OtherCustomer> getOtherCustomer()
        {
            return otherCustomers;
        }
    }
}
