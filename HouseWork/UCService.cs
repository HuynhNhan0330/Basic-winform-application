using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HouseWork
{
    public partial class UCService : UserControl
    {
        public Button btnCurrent { get; set; }
        
        public UCService()
        {
            InitializeComponent();
        }

        private void ActiveButton(object sender, bool isSave = true)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.FromArgb(32, 164, 247);
            if (isSave) btnCurrent = btn;
        }

        private void DeactivateButton(object sender)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.LightSkyBlue;
        }

        private void DeactivateAllButton()
        {
            foreach (Control ctn in pnMenuService.Controls)
            {
                ctn.BackColor = Color.LightSkyBlue;
            }
        }

        private void changePageService(UserControl UC)
        {
            pnMainService.Controls.Clear();
            pnMainService.Controls.Add(UC);
        }


        private void btnClean_Click(object sender, EventArgs e)
        {
            DeactivateAllButton();
            ActiveButton(sender);
            changePageService(new UCClean());
        }

        private void btnCook_Click(object sender, EventArgs e)
        {
            DeactivateAllButton();
            ActiveButton(sender);
            changePageService(new UCCook());
        }

        private void btnLaundry_Click(object sender, EventArgs e)
        {
            DeactivateAllButton();
            ActiveButton(sender);
            changePageService(new UCLaundry());
        }

        private void btnMouseHover(object sender, EventArgs e)
        {
            ActiveButton(sender, false);
        }

        private void btnMouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != btnCurrent) DeactivateButton(sender);
        }

        
    }
}
