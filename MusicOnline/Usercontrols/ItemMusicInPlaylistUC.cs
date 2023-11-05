using MusicOnline.Model;
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
    public partial class ItemMusicInPlaylistUC : UserControl
    {
        private Playlist _playlist;
        public Playlist playlist
        {
            get { return _playlist; }
            set { _playlist = value; }
        }

        private Music _music;
        public Music music
        {
            get { return _music; }
            set { _music = value; }
        }
        public ItemMusicInPlaylistUC()
        {
            InitializeComponent();
        }

        public ItemMusicInPlaylistUC(Image img, string title, string artistsNames)
        {
            InitializeComponent();

            pibImage.BackgroundImage = img;
            lbTitle.Text = title;
            lbArtistsNames.Text = artistsNames;

            lbArtistsNames.Top = lbTitle.Top + lbTitle.Height + 5;
            this.Height = lbArtistsNames.Top + lbArtistsNames.Height + 10;
        }

        private void pibDelete_Click(object sender, EventArgs e)
        {
            AMessageBoxFrm ms = new AMessageBoxFrm("Xác nhận xoá bài này khỏi danh sách phát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ms.ShowDialog() == DialogResult.Yes)
            {
                FrmpEditPlaylist frm = Application.OpenForms.OfType<FrmpEditPlaylist>().FirstOrDefault();
                frm.removeMusic(music);

                Data.removeMusicToPlaylist(playlist, music);
            }
        }
    }
}
