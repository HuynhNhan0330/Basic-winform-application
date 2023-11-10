using MusicOnline.Model;
using MusicOnline.Usercontrols;
using MusicOnline.Utils;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicOnline
{
    public partial class FrmpEditPlaylist : Form
    {
        private Playlist playlist { get; set; }
        private string namePlaylist { get; set; }
        
        public FrmpEditPlaylist()
        {
            InitializeComponent();
        }

        public FrmpEditPlaylist(Playlist playlist)
        {
            InitializeComponent();
            this.playlist = playlist;

            foreach (Music music in this.playlist.musics)
            {
                ItemMusicInPlaylistUC it = new ItemMusicInPlaylistUC(Helper.loadImagePath("../../CreateData/Image/" + music.Title + ".jpg"), music.Title, music.ArtistsNames);
                it.music = music;
                it.playlist = playlist;
                it.Dock = DockStyle.Top;
                pnBody.Controls.Add(it);
            }

            this.namePlaylist = playlist.name;
            atbNamePlaylist.Texts = this.namePlaylist;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            GraphicsPath path = RoundedRectangle.Create(Width, Height, 10);
            Region = new Region(path);

            Graphics g = e.Graphics;
            using (Pen pen = new Pen(BaseColor.XanhLa, 2))
                g.DrawPath(pen, path);
        }

        private void pibClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmComment_Load(object sender, EventArgs e)
        {

        }

        private void pibCancel_Click(object sender, EventArgs e)
        {
            atbNamePlaylist.Texts = this.namePlaylist;
        }

        private void pibAccept_Click(object sender, EventArgs e)
        {
            this.namePlaylist = atbNamePlaylist.Texts;

            playlist.name = namePlaylist;

            FrmHome frmhome = Application.OpenForms.OfType<FrmHome>().FirstOrDefault();

            frmhome.updateListPlaylist();
        }

        private void atbNamePlaylist__TextChanged(object sender, EventArgs e)
        {
            if (atbNamePlaylist.Texts.Length > 10)
            {
                atbNamePlaylist.Texts = atbNamePlaylist.Texts.Substring(0, 10);
                AMessageBoxFrm ms = new AMessageBoxFrm("Giới hạn tên 10 kí tự !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ms.ShowDialog();
            }
        }

        public void removeMusic(Music music)
        {
            ItemMusicInPlaylistUC icDelete = null;

            foreach (ItemMusicInPlaylistUC ic in pnBody.Controls)
                if (ic.music == music)
                    icDelete = ic;

            if (icDelete != null)
                pnBody.Controls.Remove(icDelete);
        }

        private void abtnDeleteAll_Click(object sender, EventArgs e)
        {
            AMessageBoxFrm ms = new AMessageBoxFrm("Xác nhận xoá tất cả", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ms.ShowDialog() == DialogResult.Yes)
            {
                playlist.musics.Clear();
                pnBody.Controls.Clear();

                FrmHome fr = Application.OpenForms.OfType<FrmHome>().FirstOrDefault();
                fr.loadPlaylist(playlist);

                AMessageBoxFrm ms1 = new AMessageBoxFrm("Xoá thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ms1.ShowDialog();  
            }
        }
    }
}
