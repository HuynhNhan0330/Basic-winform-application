using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.Model
{
    public class Notification
    {
        public string NotificationID { get; set; }
        public string CustomerID { get; set; }
        public int NotificationType { get; set; }
        public string Note { get; set; }
    }
}
