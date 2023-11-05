using MusicOnline.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicOnline.Usercontrols
{
    public partial class PlaylistItemUC : UserControl
    {
        private Playlist _playlist;
        public Playlist playlist 
        { 
            get { return _playlist; } 
            set
            {
                _playlist = value;
                lbText.Text = _playlist.name;
            } 
        }
        
        public PlaylistItemUC()
        {
            InitializeComponent();
        }

        public PlaylistItemUC(Playlist _playlist)
        {
            InitializeComponent();
            
            playlist = _playlist;
            render();
        }

        private void render()
        {
            this.Height = lbText.Height + lbText.Top + 15;
        }

        private void pibDelete_Click(object sender, EventArgs e)
        {
            AMessageBoxFrm ms = new AMessageBoxFrm("Bạn muốn xoá playlist này", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (ms.ShowDialog() == DialogResult.Yes)
            {
                Data.removeDataPlaylist(playlist);

                FrmHome formHome = Application.OpenForms.OfType<FrmHome>().FirstOrDefault();
                formHome.removePlaylist(playlist.name);
            }
        }

        private void pibEdit_Click(object sender, EventArgs e)
        {
            FrmpEditPlaylist frmEdit = new FrmpEditPlaylist(this.playlist);
            frmEdit.ShowDialog();
        }

        private void PlaylistItemUC_Load(object sender, EventArgs e)
        {
            
        }

        private void PlaylistItemUC_Click(object sender, EventArgs e)
        {
            FrmHome frm = Application.OpenForms.OfType<FrmHome>().FirstOrDefault();
            frm.loadPlaylist(playlist);
        }
    }
}
