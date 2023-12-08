using Banking.Model;
using Banking.Utils;
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
    public partial class SaveBookItemUC : UserControl
    {
        private SaveBook _saveBook;
        public SaveBook saveBook
        {
            get { return _saveBook; }
            set
            {
                _saveBook = value;
                render();
            }
        }

        public SaveBookItemUC()
        {
            InitializeComponent();
        }

        private void render()
        {
            lbMoney.Text = Helper.FormatVNMoney(saveBook.Money);
            lbTern.Text = saveBook.Tern;
            lbType.Text = saveBook.Type;
            
            lbCreate.Text = saveBook.Created.ToString("dd/MM/yyyy");
            lbCreate.Left = this.Width - 50 - lbCreate.Width;

            pibLogo.Left = lbCreate.Left + lbCreate.Width / 2 - pibLogo.Width / 2;
        }
    }
}
