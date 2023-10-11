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
    public partial class UCContact : UserControl
    {
        public UCContact()
        {
            InitializeComponent();
        }

        private void UCContact_Load(object sender, EventArgs e)
        {
            this.logoYTB.img = Properties.Resources.YTBlogo;
            this.logoYTB.text = "ytb.com/huynhan03";

            this.logoIns.img = Properties.Resources.InsLogo2;
            this.logoIns.text = "ins.com/huynhan03";

            this.logoTikTok.img = Properties.Resources.TiktokLogo;
            this.logoTikTok.text = "tiktok.com/nhan03";

            this.logoPhone.text = "fb.com/huynhan03";
        }
    }
}
