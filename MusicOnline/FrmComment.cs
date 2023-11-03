using MusicOnline.Model;
using MusicOnline.Usercontrols;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicOnline
{
    public partial class FrmComment : Form
    {
        private int star = 0;

        public FrmComment()
        {
            InitializeComponent();
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

        private void pibSend_Click(object sender, EventArgs e)
        {
            sendMessage();
        }

        private void pibStar1_Click(object sender, EventArgs e)
        {
            pibStar1.BackgroundImage = Properties.Resources.StarActiveIcon1;
            pibStar2.BackgroundImage = Properties.Resources.StarDeactiveIcon;
            pibStar3.BackgroundImage = Properties.Resources.StarDeactiveIcon;
            pibStar4.BackgroundImage = Properties.Resources.StarDeactiveIcon;
            pibStar5.BackgroundImage = Properties.Resources.StarDeactiveIcon;
            star = 1;
        }

        private void pibStar2_Click(object sender, EventArgs e)
        {
            pibStar1.BackgroundImage = Properties.Resources.StarActiveIcon1;
            pibStar2.BackgroundImage = Properties.Resources.StarActiveIcon1;
            pibStar3.BackgroundImage = Properties.Resources.StarDeactiveIcon;
            pibStar4.BackgroundImage = Properties.Resources.StarDeactiveIcon;
            pibStar5.BackgroundImage = Properties.Resources.StarDeactiveIcon;
            star = 2;
        }

        private void pibStar3_Click(object sender, EventArgs e)
        {
            pibStar1.BackgroundImage = Properties.Resources.StarActiveIcon1;
            pibStar2.BackgroundImage = Properties.Resources.StarActiveIcon1;
            pibStar3.BackgroundImage = Properties.Resources.StarActiveIcon1;
            pibStar4.BackgroundImage = Properties.Resources.StarDeactiveIcon;
            pibStar5.BackgroundImage = Properties.Resources.StarDeactiveIcon;
            star = 3;
        }

        private void pibStar4_Click(object sender, EventArgs e)
        {
            pibStar1.BackgroundImage = Properties.Resources.StarActiveIcon1;
            pibStar2.BackgroundImage = Properties.Resources.StarActiveIcon1;
            pibStar3.BackgroundImage = Properties.Resources.StarActiveIcon1;
            pibStar4.BackgroundImage = Properties.Resources.StarActiveIcon1;
            pibStar5.BackgroundImage = Properties.Resources.StarDeactiveIcon;
            star = 4;
        }

        private void pibStar5_Click(object sender, EventArgs e)
        {
            pibStar1.BackgroundImage = Properties.Resources.StarActiveIcon1;
            pibStar2.BackgroundImage = Properties.Resources.StarActiveIcon1;
            pibStar3.BackgroundImage = Properties.Resources.StarActiveIcon1;
            pibStar4.BackgroundImage = Properties.Resources.StarActiveIcon1;
            pibStar5.BackgroundImage = Properties.Resources.StarActiveIcon1;
            star = 5;
        }

        private void atbText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                sendMessage();
        }

        private void loadMessage(string text, bool isBoy, int star)
        {
            Panel pn = new Panel();
            pn.BackColor = Color.FromArgb(166, 166, 166);
            pn.Dock = DockStyle.Top;
            pn.Height = 2;
            pnBody.Controls.Add(pn);

            MessageUC mess = new MessageUC(star);
            mess.Dock = DockStyle.Top;
            mess.Body = text.TrimEnd();
            if (isBoy)
                mess.Avatar = "boy";
            pnBody.Controls.Add(mess);
        }

        private void sendMessage()
        {
            if (string.IsNullOrEmpty(atbText.Texts))
                return;

            loadMessage(atbText.Texts.TrimEnd(), arbtnBoy.Checked, star);

            FrmHome currentForm = Application.OpenForms.OfType<FrmHome>().FirstOrDefault();
            Data.addDataComment(currentForm.currentMusicSelected, new Comment(arbtnBoy.Checked ? "boy" : "girl", atbText.Texts.TrimEnd(), star));
        }

        private void FrmComment_Load(object sender, EventArgs e)
        {
            FrmHome currentForm = Application.OpenForms.OfType<FrmHome>().FirstOrDefault();
            ArrayComment ac = Data.GetArrayComment(currentForm.currentMusicSelected);

            if (ac != null)
                foreach (Comment comment in ac.comments)
                    loadMessage(comment.comment, comment.gender == "boy", comment.start);
        }
    }
}
