using Banking.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.Database
{
    public class CustomerDB
    {
        private static CustomerDB _ins;
        public static CustomerDB Ins
        {
            get
            {
                if (_ins == null)
                    _ins = new CustomerDB();
                return _ins;
            }
            private set => _ins = value;
        }

        private ObservableCollection<Customer> customers = new ObservableCollection<Customer>
        {
            new Customer()
            {
                CustomerID = "KH0001",
                CustomerName = "admin",
                PhoneNumber = "0123456789",
                Birthday = DateTime.Now,
                Email = "admin",
                Password = "admin",
                accountNumber = "123456789",
                currentMoney = 999999999999
            }
        };

        public ObservableCollection<Customer> getCustomer()
        {
            return customers;
        }

        public string getMaxId()
        {
            return customers.Max(kh => kh.CustomerID);
        }

        public Customer createCustomer(Customer customer)
        {
            try
            {
                customers.Add(customer);
                return customer;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
