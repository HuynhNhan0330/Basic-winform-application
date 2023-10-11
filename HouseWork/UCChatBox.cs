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
    public partial class UCChatBox : UserControl
    {
        public UCChatBox()
        {
            InitializeComponent();
            isVerticalScroll = false;
        }
        
        private bool isVerticalScroll { get; set; }

        private bool checkHeightControlsInChat()
        {
            int heightControl = 0;
            
            foreach (Control ctl in pnMainChat.Controls)
            {
                heightControl += ctl.Height;
            }

            return heightControl <= 300;
        }

        private void sendMessageUser()
        {
            UCMessageUser msUser = new UCMessageUser();
            pnMainChat.Controls.Add(msUser);
            msUser.BringToFront();
            msUser.Dock = DockStyle.Top;

            msUser.Body = txbType.Text;

            if (!(!isVerticalScroll && checkHeightControlsInChat()))
            {
                isVerticalScroll = true;
                msUser.updateLeftChat(3);
            }
            else msUser.updateLeftChat(20);
        }

        private void sendMessageBot()
        {
            UCMessageBot msBot = new UCMessageBot();
            pnMainChat.Controls.Add(msBot);
            msBot.BringToFront();
            msBot.Dock = DockStyle.Top;

            msBot.Body = "Tôi yêu bạn ❤️";
        }

        private void txbType_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                runChat();
                e.Handled = true; 
            }
        }

        private void pibSend_Click(object sender, EventArgs e)
        {
            runChat();
        }

        private void runChat()
        {
            if (!string.IsNullOrEmpty(txbType.Text))
            {
                sendMessageUser();
                sendMessageBot();
                pnMainChat.ScrollControlIntoView(pnMainChat.Controls[0]);
                txbType.Text = "";
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            GraphicsPath path = RoundedRectangle.Create(this.Width, this.Height, 10);
            this.Region = new Region(path);

            // Tạo một Pen mới với màu sắc và độ dày mong muốn
            Pen pen = new Pen(Color.FromArgb(0, 188, 215), 3);
            Graphics graphics = e.Graphics;
            // Vẽ đường viền bằng GraphicsPath và Pen
            graphics.DrawPath(pen, path);

            base.OnPaint(e);
        }
    }
}
