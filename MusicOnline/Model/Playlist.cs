using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicOnline.Model
{
    public class Playlist
    {
        public string name { get; set; }
        public ObservableCollection<Music> musics { get; set; }

        public Playlist(string name)
        {
            this.name = name;
            musics = new ObservableCollection<Music>();
        }
    }
}
