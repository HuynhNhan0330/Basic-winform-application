using Banking.DALs;
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
        private ObservableCollection<Notification> notifications;

        public NotificationUC()
        {
            InitializeComponent();
        }

        private void NotificationUC_Load(object sender, EventArgs e)
        {
            loadData();
            loadPanelData();
        }

        private void abtnAll_Click(object sender, EventArgs e)
        {

        }

        private void abtnDontSeen_Click(object sender, EventArgs e)
        {

        }

        private void abtnSeen_Click(object sender, EventArgs e)
        {

        }

        private void loadData(int type = 0)
        {
            switch (type)
            {
                case 0:
                    notifications = new ObservableCollection<Notification>(NotificationDAL.Ins.getNotification(Helper.getCurrentCustomer().CustomerID));
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
