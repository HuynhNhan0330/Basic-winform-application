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
    public class NotificationDAL
    {
        private static NotificationDAL _ins;
        public static NotificationDAL Ins
        {
            get
            {
                if (_ins == null)
                    _ins = new NotificationDAL();
                return _ins;
            }
            private set => _ins = value;
        }

        public ObservableCollection<Notification> getNotification()
        {
            return NotificationDB.Ins.getNotification();
        }
    }
}
