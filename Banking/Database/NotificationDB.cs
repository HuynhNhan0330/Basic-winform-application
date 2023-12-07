using Banking.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.Database
{
    public class NotificationDB
    {
        private static NotificationDB _ins;
        public static NotificationDB Ins
        {
            get
            {
                if (_ins == null)
                    _ins = new NotificationDB();
                return _ins;
            }
            private set => _ins = value;
        }

        private ObservableCollection<Notification> notifications = new ObservableCollection<Notification>
        {
            new Notification()
            {
                NotificationID = "NO0001",
                CustomerID = "KH0001",
                NotificationType = 1,
                Note = "Số dư tài khoản 123456789 +0 vnđ lúc 12/12/2012 12:12:12. Số dư 0 vnđ. Tiền khuyến mãi từ NBank."
            },
            new Notification()
            {
                NotificationID = "NO0002",
                CustomerID = "KH0001",
                NotificationType = 1,
                Note = "Số dư tài khoản 123456789 +0 vnđ lúc 12/12/2012 12:12:12. Số dư 0 vnđ. Tiền khuyến mãi từ NBank."
            },
            new Notification()
            {
                NotificationID = "NO0003",
                CustomerID = "KH0001",
                NotificationType = 1,
                Note = "Số dư tài khoản 123456789 +0 vnđ lúc 12/12/2012 12:12:12. Số dư 0 vnđ. Tiền khuyến mãi từ NBank."
            },
            new Notification()
            {
                NotificationID = "NO0004",
                CustomerID = "KH0001",
                NotificationType = 1,
                Note = "Số dư tài khoản 123456789 +0 vnđ lúc 12/12/2012 12:12:12. Số dư 0 vnđ. Tiền khuyến mãi từ NBank."
            },
        };

        public ObservableCollection<Notification> getNotification()
        {
            return notifications;
        }
    }
}
