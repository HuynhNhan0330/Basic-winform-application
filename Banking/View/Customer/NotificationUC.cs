using Banking.AControls;
using Banking.DALs;
using Banking.Database;
using Banking.Model;
using Banking.Usercontrols;
using Banking.Utils;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banking
{
    public partial class NotificationUC : UserControl
    {
        private List<Notification> _notifications = new List<Notification>();
        private List<Notification> notifications = new List<Notification>();
        private AButton currentButton = null;

        public NotificationUC()
        {
            InitializeComponent();
        }

        private void NotificationUC_Load(object sender, EventArgs e)
        {
            currentButton = abtnAll;
            loadData();
            loadPanelData();
        }

        private void doActiveButton(AButton abtn)
        {
            abtn.LineType = AButton.LineStyles.Bottom;
            abtn.ForeColor = BaseColor.XanhLa;
        }

        private void doDeactiveButton(AButton abtn)
        {
            abtn.LineType = AButton.LineStyles.None;
            abtn.ForeColor = BaseColor.Xam;
        }

        private void abtnAll_Click(object sender, EventArgs e)
        {
            AButton abtnChoose = sender as AButton;

            if (abtnChoose != currentButton)
            {
                doDeactiveButton(currentButton);
                doActiveButton(abtnChoose);
                currentButton = abtnChoose;
                loadData(1);
                loadPanelData();
            }
        }

        private void abtnDontSeen_Click(object sender, EventArgs e)
        {
            AButton abtnChoose = sender as AButton;

            if (abtnChoose != currentButton)
            {
                doDeactiveButton(currentButton);
                doActiveButton(abtnChoose);
                currentButton = abtnChoose;
                loadData(2);
                loadPanelData();
            }
        }

        private void abtnSeen_Click(object sender, EventArgs e)
        {
            AButton abtnChoose = sender as AButton;

            if (abtnChoose != currentButton)
            {
                doDeactiveButton(currentButton);
                doActiveButton(abtnChoose);
                currentButton = abtnChoose;
                loadData(3);
                loadPanelData();
            }
        }

        private void loadData(int type = 0)
        {
            switch (type)
            {
                case 0:
                    List <Notification> currentNotifications = new List<Notification>(NotificationDAL.Ins.getNotification(Helper.getCurrentCustomer().CustomerID));

                    foreach (Notification no in currentNotifications)
                        _notifications.Add(new Notification(no));

                    notifications = new List<Notification>(_notifications);

                    NotificationDAL.Ins.seenNotification(Helper.getCurrentCustomer().CustomerID);
                    break;
                
                case 1:
                    notifications = new List<Notification>(_notifications);
                    loadPanelData();
                    break;

                case 2:
                    notifications.Clear();
                    foreach (Notification no in _notifications)
                        if (no.NotificationType == 0) notifications.Add(no);
                    loadPanelData();
                    break;

                case 3:
                    notifications.Clear();
                    foreach (Notification no in _notifications)
                        if (no.NotificationType == 1) notifications.Add(no);
                    loadPanelData();
                    break;
            }
        }

        private void loadPanelData()
        {
            pnMain.Controls.Clear();

            foreach (Notification no in notifications)
            {
                Panel pn = new Panel();
                pnMain.Controls.Add(pn);
                pn.Height = 5;
                pn.Dock = DockStyle.Top;
                pn.SendToBack();
                
                NotificationItemUC uc = new NotificationItemUC();
                uc.notification = no;
                pnMain.Controls.Add(uc);
                uc.Dock = DockStyle.Top;
                uc.SendToBack();
            }
        }
    }
}
