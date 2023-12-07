using Banking.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banking.Usercontrols
{
    public partial class NotificationItemUC : UserControl
    {
        private Notification _notification;
        public Notification notification
        {
            get { return _notification; }
            set
            {
                _notification = value;
                render();
            }
        }

        public NotificationItemUC()
        {
            InitializeComponent();
        }

        public void render()
        {
            lbNote.Text = notification.Note;
            this.Height = lbNote.Top + lbNote.Height + 15;

            if (notification.NotificationType == 0)
            {
                this.BackColor = Color.Gray;
                lbNote.ForeColor = Color.White;
            }
        }
    }
}
