using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicOnline
{
    public partial class FrmLyrics : Form
    {
        public FrmLyrics()
        {
            InitializeComponent();
        }

        public FrmLyrics(string lyrics)
        {
            InitializeComponent();
            
            Label lb = new Label();
            lb.Text = lyrics;
            lb.Font = new Font("Microsoft Sans Serif", 15);
            lb.ForeColor = Color.Black;
            lb.AutoSize = true;
            Size maximumSize = lb.MaximumSize;
            maximumSize.Width = pnLyrics.Width - 25;
            pnLyrics.Controls.Add(lb);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            GraphicsPath path = RoundedRectangle.Create(Width, Height, 10);
            Region = new Region(path);
        }

        private void pibClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
