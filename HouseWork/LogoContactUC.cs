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
    public partial class LogoContactUC : UserControl
    {
        public Image img
        {
            get { return pibIcon.BackgroundImage; }
            set { pibIcon.BackgroundImage = value; }
        }

        public string text
        {
            get { return lbText.Text; }
            set
            {
                lbText.Text = value;
                lbText.Left = (this.Width - lbText.Width - 60) / 2 + 60;
            }
        }

        public LogoContactUC()
        {
            InitializeComponent();
        }
    }
}
