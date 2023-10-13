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
    public partial class UCCook : UserControl
    {
        public UCCook()
        {
            InitializeComponent();
        }

        private void card2_Click(object sender, EventArgs e)
        {
            rbtn1.Checked = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            card2_Click(sender, e);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            card2_Click(sender, e);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            card2_Click(sender, e);
        }

        private void card3_Click(object sender, EventArgs e)
        {
            rbtn2.Checked = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            card3_Click(sender, e);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            card3_Click(sender, e);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            card3_Click(sender, e);
        }

        private void card1_Click(object sender, EventArgs e)
        {
            rbtn3.Checked = true;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            card1_Click(sender, e);
        }

        private void label7_Click(object sender, EventArgs e)
        {
            card1_Click(sender, e);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            card1_Click(sender, e);
        }
    }
}
