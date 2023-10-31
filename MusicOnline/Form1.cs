using MusicOnline.Usercontrols;
using MusicOnline.Utils;
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

namespace MusicOnline
{
    public partial class Form1 : Form
    {
        private WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();

        public Form1()
        {
            InitializeComponent();
            runMp3("D:\\Code\\DoAnC#\\Practical Exercise\\MusicOnline\\Mp3\\SimeImlangMemuoiPhaiLong.mp3");
        }

        private void pibClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void runMp3(string path)
        {
            player.URL = path;
            player.controls.play();
        }

        #region slider

        private float defaultValue = 0.1f, min = 0.0f, max = 1.0f;
        private bool isMouse = false;


        private float Bar(float value)
        {
            return (slider.Width - 24) * (value - min) / (float)(max - min);
        }

        private void thumb(float value)
        {
            if (value < min) value = min;
            if (value > max) value = max;
            defaultValue = value;
            slider.Refresh();
        }

        private float slider_width(int x)
        {
            return min + (max - min) * x / (float)(slider.Width);
        }

        private void slider_Paint(object sender, PaintEventArgs e)
        {
            float barSize = 0.25f;
            float x = Bar(defaultValue);
            int y = (int)(slider.Height * barSize);

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.FillRectangle(new SolidBrush(BaseColor.Xam), 0, y, slider.Width, y / 2);
            g.FillRectangle(new SolidBrush(BaseColor.XanhLa), 0, y, x, y / 2);

            using (Pen pen = new Pen(BaseColor.XanhLa, 6))
            {
                g.DrawEllipse(pen, x + 4, y - 6, slider.Height / 2, slider.Height / 2);
                g.FillEllipse(Brushes.White, x + 4, y - 6, slider.Height / 2, slider.Height / 2);
            }
        }

        private void slider_MouseDown(object sender, MouseEventArgs e)
        {
            isMouse = true;
            player.controls.pause();
            thumb(slider_width(e.X));
            player.controls.currentPosition = player.currentMedia.duration * e.X / slider.Width;
        }

        private void slider_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isMouse) return;
            thumb(slider_width(e.X));
            player.controls.currentPosition = player.currentMedia.duration * e.X / slider.Width;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 11; ++i)
            {
                flowLayoutPanel1.Controls.Add(new ItemMucic());
                
            }
        }

        private void slider_MouseUp(object sender, MouseEventArgs e)
        {
            isMouse = false;
            player.controls.play();
        }

        private void timePlay_Tick(object sender, EventArgs e)
        {
            if (player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                max = (int)player.controls.currentItem.duration;
                defaultValue = (int)player.controls.currentPosition;
                slider.Invalidate();
            }
        }

        #endregion
    }
}
