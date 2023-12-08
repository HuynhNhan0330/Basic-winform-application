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
    public partial class HomeUC : UserControl
    {
        public HomeUC()
        {
            InitializeComponent();
        }

        private void HomeUC_Load(object sender, EventArgs e)
        {
            Customer customer = Helper.getCurrentCustomer();

            lbName.Text = customer.CustomerName;
            lbAccountName.Text = customer.accountNumber;
            lbMoney.Text = Helper.FormatVNMoney(customer.currentMoney);
            pibAvatar.Image = Helper.loadImagePath(customer.Avatar);

            loadPanelSaveBook();
        }

        private void loadPanelSaveBook()
        {
            ObservableCollection <SaveBook> saveBooks = SaveBookDAL.Ins.getSaveBook(Helper.getCurrentCustomer().CustomerID);

            pnSaveBook.Controls.Clear();

            foreach (SaveBook sb in saveBooks)
            {
                Panel pn = new Panel();
                pnSaveBook.Controls.Add(pn);
                pn.Height = 2;
                pn.BackColor = BaseColor.Xam;
                pn.Dock = DockStyle.Top;
                pn.SendToBack();

                SaveBookItemUC uc = new SaveBookItemUC();
                uc.saveBook = sb;
                pnSaveBook.Controls.Add(uc);
                uc.Dock = DockStyle.Top;
                uc.SendToBack();
            }
        }
    }
}
