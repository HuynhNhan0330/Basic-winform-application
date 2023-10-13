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
    public partial class UCClean : UserControl
    {
        public UCClean()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            rbtn1.Checked = true;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            rbtn2.Checked = true;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            rbtn3.Checked = true;
        }

        private void lb1_Click(object sender, EventArgs e)
        {
            btn1_Click(sender, e);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            btn1_Click(sender, e);
        }

        private void pcb1_Click(object sender, EventArgs e)
        {
            btn1_Click(sender, e);
        }

        private void lb2_Click(object sender, EventArgs e)
        {
            btn2_Click(sender, e);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            btn2_Click(sender, e);
        }

        private void pcb2_Click(object sender, EventArgs e)
        {
            btn2_Click(sender, e);
        }

        private void lb3_Click(object sender, EventArgs e)
        {
            btn3_Click(sender, e);
        }

        private void label7_Click(object sender, EventArgs e)
        {
            btn3_Click(sender, e);
        }

        private void pcb3_Click(object sender, EventArgs e)
        {
            btn3_Click(sender, e);
        }
    }
}
