using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicOnline.Model
{
    public class ArrayComment
    {
        public Music music { get; set; }
        public ObservableCollection<Comment> comments { get; set; }

        public ArrayComment(Music music) 
        {
            this.music = music;
            comments = new ObservableCollection<Comment>();
        }
    }

    public class Comment
    {
        public string gender { get; set; }
        public string comment { get; set; }
        public int start { get; set; }

        public Comment(string gender, string comment, int start)
        {
            this.gender = gender;
            this.comment = comment;
            this.start = start;
        }
    }
}
