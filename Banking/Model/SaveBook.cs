using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.Model
{
    public class SaveBook
    {
        public string SaveBookID {  get; set; }
        public string CustomerID { get; set; }
        public decimal Money { get; set; }
        public string Tern {  get; set; }
        public string Type {  get; set; }
        public DateTime Created { get; set; }
    }
}
