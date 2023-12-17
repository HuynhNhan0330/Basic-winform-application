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
            
            lbCreate.Text = lbCreate.Text + saveBook.Created.ToString("dd/MM/yyyy");
            lbCreate.Left = this.Width - 20 - lbCreate.Width;

            string[] parts = saveBook.Tern.Split(new[] { " tháng - " }, StringSplitOptions.RemoveEmptyEntries);
            string monthString = parts[0];
            string percentageString = parts[1].TrimEnd('%');

            // Chuyển đổi giá trị thành số nguyên và số thập phân
            int month = int.Parse(monthString);
            decimal percentage = decimal.Parse(percentageString);

            lbDuKien.Text = lbDuKien.Text + saveBook.Created.AddMonths(month).ToString("dd/MM/yyyy");
            lbDuKien.Left = this.Width - 20 - lbDuKien.Width;

            lbNewMoney.Text = lbNewMoney.Text + Helper.FormatVNMoney(saveBook.Money * percentage / 12 / 100 + saveBook.Money);
            lbNewMoney.Left = this.Width - 20 - lbNewMoney.Width;
        }
    }
}
