using MusicOnline.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicOnline
{
    public static class Data
    {
        public static ObservableCollection<Music> a;
        public static ObservableCollection<ArrayComment> dataArrayComment = new ObservableCollection<ArrayComment>();
        public static ObservableCollection<Playlist> dataPlaylist= new ObservableCollection<Playlist>();

        public static void addDataComment(Music _music, Comment _comment)
        {
            ArrayComment _arraycomment = dataArrayComment.FirstOrDefault(ac => ac.music == _music);
            if (_arraycomment == null)
            {
                ArrayComment newArrayComment = new ArrayComment(_music);
                newArrayComment.comments.Add(_comment);
                dataArrayComment.Add(newArrayComment);
            }
            else
            {
                _arraycomment.comments.Add(_comment);
            }
        }

        public static ArrayComment GetArrayComment(Music _music)
        {
            return dataArrayComment.FirstOrDefault(ac => ac.music == _music);
        }

        public static bool addDataPlaylist(Playlist _playlist)
        {
            Playlist playlist = dataPlaylist.FirstOrDefault(pl => pl.name == _playlist.name);
            if (playlist == null)
            {
                dataPlaylist.Add(_playlist);
                return true;
            }
            else
            {
                // Tên trùng
                AMessageBoxFrm ms = new AMessageBoxFrm("Tên danh sách đã có", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ms.ShowDialog();
                return false;
            }
        }

        public static void removeDataPlaylist(Playlist _playlist)
        {
            dataPlaylist.Remove(_playlist);
        }

        public static void addMusicToPlayList(string _namePlaylist, Music music)
        {
            Playlist playlist = dataPlaylist.FirstOrDefault(pl => pl.name == _namePlaylist);
            
            try
            {
                Music currentMusic = playlist.musics.FirstOrDefault(mc => mc == music);
                if (currentMusic == null)
                {
                    playlist.musics.Add(music);
                    AMessageBoxFrm ms = new AMessageBoxFrm("Thêm vào danh sách thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ms.ShowDialog();
                }
                else
                {
                    AMessageBoxFrm ms = new AMessageBoxFrm("Thêm vào danh sách Thất bại\nBài hát đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ms.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                AMessageBoxFrm ms = new AMessageBoxFrm(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
        }

        public static void removeMusicToPlaylist(Playlist playlist, Music music)
        {
            Playlist currentPlaylist = dataPlaylist.FirstOrDefault(pl => pl == playlist);
            Music currentmusic = currentPlaylist.musics.FirstOrDefault(ms => ms == music);
            currentPlaylist.musics.Remove(music);
        }
    }
}
