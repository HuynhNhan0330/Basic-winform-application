using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.Model
{
    public class TransactionDetail
    {
        public string TransactionDetailID { get; set; } 
        public string CustomerID { get; set; } 
        public int TransactionDetailType { get; set; }
        public string Note { get; set; }
        public DateTime Created { get; set; }
        public decimal Value { get; set; }
        public decimal CurrentMoney { get; set; }
    }
}
