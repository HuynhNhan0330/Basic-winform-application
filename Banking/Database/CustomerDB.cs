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
                currentMoney = 999999999999,
                Avatar = @"../../Image/Avatar.png",
                Gender = true,
                Created = DateTime.Now
            },
            new Customer()
            {
                CustomerID = "KH0002",
                CustomerName = "Huynh Mai Cao Nhan",
                PhoneNumber = "0123456789",
                Birthday = DateTime.Now,
                Email = "tinhoctrevnnhan@gmail.com",
                Password = "admin",
                accountNumber = "111111111",
                currentMoney = 10000000,
                Avatar = @"../../Image/Avatar.png",
                Gender = true,
                Created = DateTime.Now
            },
            new Customer()
            {
                CustomerID = "KH0003",
                CustomerName = "Huynh",
                PhoneNumber = "0123456788",
                Birthday = DateTime.Now,
                Email = "a@gmail.com",
                Password = "admin",
                accountNumber = "111111112",
                currentMoney = 10000000,
                Avatar = @"../../Image/Avatar.png",
                Gender = true,
                Created = DateTime.Now
            },
            new Customer()
            {
                CustomerID = "KH0004",
                CustomerName = "Mai",
                PhoneNumber = "0123456787",
                Birthday = DateTime.Now,
                Email = "b@gmail.com",
                Password = "admin",
                accountNumber = "111111113",
                currentMoney = 10000000,
                Avatar = @"../../Image/Avatar.png",
                Gender = true,
                Created = DateTime.Now
            },
            new Customer()
            {
                CustomerID = "KH0005",
                CustomerName = "Cao",
                PhoneNumber = "0123456786",
                Birthday = DateTime.Now,
                Email = "c@gmail.com",
                Password = "admin",
                accountNumber = "111111114",
                currentMoney = 10000000,
                Avatar = @"../../Image/Avatar.png",
                Gender = true,
                Created = DateTime.Now
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
            customers.Add(customer);
            return customer;
        }
    }
}
