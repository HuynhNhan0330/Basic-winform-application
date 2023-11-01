using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicOnline.Usercontrols
{
    public partial class ItemMusic : UserControl
    {
        public ItemMusic(string title)
        {
            InitializeComponent();
        }

        public ItemMusic(string title, string artistsNames, Image thumbnail = null)
        {
            InitializeComponent();

            this.Title = title;
            this.ArtistsNames = artistsNames;
            this.Thumbnail = thumbnail;
            Render();
        }

        public Image Thumbnail
        {
            get { return pibThumbnail.BackgroundImage; }
            set { pibThumbnail.BackgroundImage = value; }
        }

        public string Title
        {
            get { return lbTitle.Text; }
            set { lbTitle.Text = value; Render(); }
        }

        public string ArtistsNames
        {
            get { return lbArtistsNames.Text; }
            set { lbArtistsNames.Text = value; Render(); }
        }

        private void Render()
        {
            pnTitle.Height = lbTitle.Top + lbTitle.Height;
            int pnArtistsNamesHeight = lbArtistsNames.Top + lbArtistsNames.Height + 10;
            this.Height = pnThum.Height + pnTitle.Height + pnArtistsNamesHeight;
        }

        public void setHeight(int hTitle, int hArtistsNames)
        {
            pnTitle.Height = hTitle;
            int pnArtistsNamesHeight = hArtistsNames;
            this.Height = pnThum.Height + pnTitle.Height + pnArtistsNamesHeight;
        }

        public int getHeightPanelTitle()
        {
            return pnTitle.Height;
        }

        public int getHeightPanelArtistsNames()
        {
            return pnArtistsNames.Height;
        }

        private void ItemMusic_Click(object sender, EventArgs e)
        {
            FrmHome currentFrm = this.ParentForm as FrmHome;
            currentFrm.runMp3(@"../../CreateData/Mp3/" + Title + ".mp3");
            currentFrm.setDetailMusic(Title);
        }

        private void ItemMusic_Load(object sender, EventArgs e)
        {
            setClickControls(this);
        }

        private void setClickControls(Control ctrParent)
        {
            foreach (Control ctr in ctrParent.Controls)
            {
                ctr.Click += ItemMusic_Click;
                setClickControls(ctr);
            }
        }
    }
}
