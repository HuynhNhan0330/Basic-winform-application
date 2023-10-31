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
    public partial class ItemMucic : UserControl
    {
        public ItemMucic()
        {
            InitializeComponent();
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
            pnArtistsNames.Height = lbArtistsNames.Top + lbArtistsNames.Height + 15;
        }
    }
}
