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
    public class CustomerDAL
    {
        private static CustomerDAL _ins;
        public static CustomerDAL Ins
        {
            get
            {
                if (_ins == null)
                    _ins = new CustomerDAL();
                return _ins;
            }
            private set => _ins = value;
        }

        public Customer checkLogin(string username, string password)
        {
            try
            {
                ObservableCollection<Customer> customers = CustomerDB.Ins.getCustomer();

                foreach (Customer customer in customers)
                {
                    if ((customer.PhoneNumber == username || customer.Email == username) && customer.Password == password)
                        return customer;
                }

                return null;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
