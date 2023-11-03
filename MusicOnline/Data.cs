using MusicOnline.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

        public static void test()
        {
        }
    }
}
