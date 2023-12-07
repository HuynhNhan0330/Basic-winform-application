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

        public Notification() { }
        public Notification(string NotificationID, string CustomerID, int NotificationType, string Note)
        {
            this.NotificationID = NotificationID;
            this.CustomerID = CustomerID;   
            this.NotificationType = NotificationType;
            this.Note = Note;
        }

        public Notification(Notification notification)
        {
            this.NotificationID = notification.NotificationID;
            this.CustomerID = notification.CustomerID;
            this.NotificationType = notification.NotificationType;
            this.Note = notification.Note;
        }
        
    }
}
