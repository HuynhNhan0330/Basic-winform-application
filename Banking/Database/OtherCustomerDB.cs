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
            new OtherCustomer()
            {
                OtherCustomerID = "OC0005",
                BankName = "MBbank",
                CustomerName = "Tri Pham",
                accountNumber = "127127127"
            },
            new OtherCustomer()
            {
                OtherCustomerID = "OC0006",
                BankName = "TPbank",
                CustomerName = "Tri Phy",
                accountNumber = "128128128"
            },
        };

        public ObservableCollection<OtherCustomer> getOtherCustomer()
        {
            return otherCustomers;
        }
    }
}
