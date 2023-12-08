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

        public bool register(Customer customer)
        {
            try
            {
                customer.CustomerID = Helper.nextCode(CustomerDB.Ins.getMaxId(), "KH");
                customer.Avatar = @"../../Image/Avatar.png";
                Customer customerNew = CustomerDB.Ins.createCustomer(customer);
                if (customerNew != null)
                    return true;
                
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public Customer findCustomerByAccountNumber(string accountNumber)
        {
            try
            {
                ObservableCollection<Customer> customers = CustomerDB.Ins.getCustomer();

                string currentID = Helper.getCurrentCustomer().CustomerID;

                Customer customer = customers.FirstOrDefault(kh => kh.accountNumber == accountNumber && kh.CustomerID != currentID);

                return customer;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public void changePassword(string email, string password)
        {
            try
            {
                ObservableCollection<Customer> customers = CustomerDB.Ins.getCustomer();

                Customer customer = customers.FirstOrDefault(kh => kh.Email == email);
                customer.Password = password;
            }
            catch (Exception ex)
            {
            }
        }
    }
}
