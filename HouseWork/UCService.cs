using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HouseWork
{
    public partial class UCService : UserControl
    {
        public UCService()
        {
            InitializeComponent();
            changePageService(new UCClean());
        }

        private void ActiveButton(object sender)
        {
            UserControl btn = sender as UserControl;
            btn.BackColor = Color.FromArgb(63, 101, 174);
            btn.ForeColor = Color.White;
        }

        private void DeactivateButton(object sender)
        {
            UserControl btn = sender as UserControl;
            btn.BackColor = Color.FromArgb(0, 188, 215);
            btn.ForeColor = Color.FromArgb(30, 30, 31);
        }

        private void DeactivateAllButton()
        {
            foreach (UserControl ctn in pnMenuService.Controls)
            {
                DeactivateButton(ctn);
            }
        }

        private void changePageService(UserControl UC)
        {
            pnMainService.Controls.Clear();
            pnMainService.Controls.Add(UC);
        }

        private void btnrClean_Click(object sender, EventArgs e)
        {
            DeactivateAllButton();
            ActiveButton(sender);
            changePageService(new UCClean());
        }

        private void btnrCook_Click(object sender, EventArgs e)
        {
            DeactivateAllButton();
            ActiveButton(sender);
            changePageService(new UCCook());
        }

        private void btnrWash_Click(object sender, EventArgs e)
        {
            DeactivateAllButton();
            ActiveButton(sender);
            changePageService(new UCLaundry());
        }

        private void UCService_Load(object sender, EventArgs e)
        {
            this.btnrClean.text = "Dọn vệ sinh";

            this.btnrCook.img = Properties.Resources.cooking;
            this.btnrCook.text = "Nấu ăn";

            this.btnrWash.img = Properties.Resources.laundry_machine;
            this.btnrWash.text = "Giặt ủi";
        }

        private void btnCal_Paint(object sender, PaintEventArgs e)
        {
            GraphicsPath path = RoundedRectangle.Create(this.btnCal.Width, this.btnCal.Height, 10);
            this.btnCal.Region = new Region(path);
        }
    }
}
