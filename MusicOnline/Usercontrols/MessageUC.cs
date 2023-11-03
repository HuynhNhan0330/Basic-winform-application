using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using MusicOnline.Utils;

namespace MusicOnline.Usercontrols
{
    public partial class MessageUC : UserControl
    {
        public MessageUC()
        {
            InitializeComponent();
        }

        public MessageUC(int start)
        {
            InitializeComponent();

            switch (start)
            {
                case 1:
                    pibStar1.BackgroundImage = Properties.Resources.StarActiveIcon1;
                    pibStar2.BackgroundImage = Properties.Resources.StarDeactiveIcon;
                    pibStar3.BackgroundImage = Properties.Resources.StarDeactiveIcon;
                    pibStar4.BackgroundImage = Properties.Resources.StarDeactiveIcon;
                    pibStar5.BackgroundImage = Properties.Resources.StarDeactiveIcon;
                    break;
                case 2:
                    pibStar1.BackgroundImage = Properties.Resources.StarActiveIcon1;
                    pibStar2.BackgroundImage = Properties.Resources.StarActiveIcon1;
                    pibStar3.BackgroundImage = Properties.Resources.StarDeactiveIcon;
                    pibStar4.BackgroundImage = Properties.Resources.StarDeactiveIcon;
                    pibStar5.BackgroundImage = Properties.Resources.StarDeactiveIcon;
                    break;
                case 3:
                    pibStar1.BackgroundImage = Properties.Resources.StarActiveIcon1;
                    pibStar2.BackgroundImage = Properties.Resources.StarActiveIcon1;
                    pibStar3.BackgroundImage = Properties.Resources.StarActiveIcon1;
                    pibStar4.BackgroundImage = Properties.Resources.StarDeactiveIcon;
                    pibStar5.BackgroundImage = Properties.Resources.StarDeactiveIcon;
                    break;
                case 4:
                    pibStar1.BackgroundImage = Properties.Resources.StarActiveIcon1;
                    pibStar2.BackgroundImage = Properties.Resources.StarActiveIcon1;
                    pibStar3.BackgroundImage = Properties.Resources.StarActiveIcon1;
                    pibStar4.BackgroundImage = Properties.Resources.StarActiveIcon1;
                    pibStar5.BackgroundImage = Properties.Resources.StarDeactiveIcon;
                    break;
                case 5:
                    pibStar1.BackgroundImage = Properties.Resources.StarActiveIcon1;
                    pibStar2.BackgroundImage = Properties.Resources.StarActiveIcon1;
                    pibStar3.BackgroundImage = Properties.Resources.StarActiveIcon1;
                    pibStar4.BackgroundImage = Properties.Resources.StarActiveIcon1;
                    pibStar5.BackgroundImage = Properties.Resources.StarActiveIcon1;
                    break;
            }
        }

        public string Body
        {
            get { return lbText.Text; }
            set { lbText.Text = value; render(); }
        }

        public string Avatar
        {
            get { return pibAvatar.BackgroundImage.ToString(); }
            set
            {
                if (value == "boy")
                    pibAvatar.BackgroundImage = Properties.Resources.boy;
                else
                    pibAvatar.BackgroundImage = Properties.Resources.girl;
            }
        }

        public void render()
        {
            lbText.Height = Helper.GetTextHeight(lbText) + 10;
            
            if (lbText.Height >= pibAvatar.Height - 10)
                lbText.Top = pibAvatar.Top;

            this.Height = lbText.Top + Math.Max(lbText.Height, pibAvatar.Height) + 5;
        }

        private void lbText_Paint(object sender, PaintEventArgs e)
        {
            GraphicsPath path = RoundedRectangle.Create(this.lbText.Width, this.lbText.Height, 5);
            this.lbText.Region = new Region(path);
        }
    }
}
