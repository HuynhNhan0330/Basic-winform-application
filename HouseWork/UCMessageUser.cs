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
    public partial class UCMessageUser : UserControl
    {
        public UCMessageUser()
        {
            InitializeComponent();
        }

        public string Body
        {
            get { return lbText.Text; }
            set { lbText.Text = value; render(); }
        }

        public void render()
        {
            lbText.Height = Utils.GetTextHeight(lbText) + 10;
            
            this.Height = lbText.Top + lbText.Height;
        }

        public void updateLeftChat(int rightLabel)
        {
            lbText.Left = this.Width - lbText.Width - rightLabel;
        }
    }
}
