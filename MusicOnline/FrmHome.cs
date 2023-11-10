using MusicOnline.Model;
using MusicOnline.Usercontrols;
using MusicOnline.Utils;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace MusicOnline
{
    public partial class FrmHome : Form
    {
        #region Thuộc tính
        private WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
        private ObservableCollection<Music> __musics = new ObservableCollection<Music>();
        private ObservableCollection<Music> _musics = new ObservableCollection<Music>();
        private ObservableCollection<Music> musics = new ObservableCollection<Music>();
        private ObservableCollection<Music> musicRecently = new ObservableCollection<Music>();
        private ObservableCollection<Music> musicLove = new ObservableCollection<Music>();
        private HashSet<String> genres = new HashSet<string>();
        private HashSet<String> types = new HashSet<string>();
        private Playlist currentPlaylist;

        private Music _currentMusicSelected = null;
        public Music currentMusicSelected
        {
            get { return _currentMusicSelected; }
            set 
            { 
                _currentMusicSelected = value;
                onMp3();
                runMp3(@"../../CreateData/Mp3/" + currentMusicSelected.Title + ".mp3");
                renderDetailMusic();
                saveRecently();
            }
        }

        private string typeMusicSelected = "Toàn bộ";
        private string textSearch = "";

        #endregion

        #region Phương thức chung

        private void LoadData()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            string filePath = "../../CreateData/musics.json";

            try
            {
                using (FileStream fs = File.OpenRead(filePath))
                {
                    JsonDocument jsonDocument = JsonDocument.Parse(fs);

                    if (jsonDocument.RootElement.ValueKind == JsonValueKind.Array)
                    {
                        foreach (JsonElement element in jsonDocument.RootElement.EnumerateArray())
                        {
                            Music music = new Music
                            {
                                Title = element.GetProperty("title").GetString(),
                                ArtistsNames = element.GetProperty("artistsNames").GetString(),
                                Genre = element.GetProperty("genre").GetString(),
                                Type = element.GetProperty("type").GetString(),
                                Lyrics = element.GetProperty("lyrics").GetString()
                            };

                            genres.Add(music.Genre);
                            types.Add(music.Type);

                            __musics.Add(music);
                        }
                    }
                }

                __musics = new ObservableCollection<Music>(__musics.OrderBy(music => music.Title));
                _musics = new ObservableCollection<Music>(__musics);
                musics = new ObservableCollection<Music>(__musics);
            }
            catch (FileNotFoundException)
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("Đường dẫn không phù hợp: " + filePath, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
            catch (Exception ex)
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("Không thể đọc file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
        }

        private void HVControl(Control ctr)
        {
            foreach (Control ctrChil in ctr.Controls)
                ctrChil.Visible = !ctrChil.Visible;
        }

        public Music getMusicByTitle(string _title)
        {
            foreach (Music music in musics)
            {
                if (music.Title == _title)
                    return music;
            }

            return null;
        }

        private void saveRecently()
        {
            if (musicRecently.Contains(currentMusicSelected))
                musicRecently.Remove(currentMusicSelected);

            musicRecently.Insert(0, currentMusicSelected);
        }

        #endregion

        #region control form
        public FrmHome()
        {
            InitializeComponent();
        }

        private void pibClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmHome_Load(object sender, EventArgs e)
        {
            HVControl(pnControlMusic);
            HVControl(pnDetailMusic);

            LoadData();
            loadDataCombobox();
            loadMusics();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            GraphicsPath path = RoundedRectangle.Create(Width, Height, 15);
            Region = new Region(path);
        }

        #endregion

        #region Menu
        private void activeButton(AButton abtn)
        {
            abtn.ForeColor = BaseColor.Trang;

            atbSearch.Texts = "";
            cbType.SelectedIndex = 0;
        }

        private void deactiveButton(AButton abtn)
        {
            abtn.ForeColor = BaseColor.Xam;
        }

        private void deactiveAllButton()
        {
            abtnListMusic.Image = Properties.Resources.musicDeactiveIcon;
            abtnLikeSong.Image = Properties.Resources.LikeSongDeActiveIcon;
            abtnRecently.Image = Properties.Resources.recentlyDeactiveIcon;

            foreach (AButton abtn in pnMenu.Controls)
                deactiveButton(abtn);
        }

        private void abtnHover_MouseHover(object sender, EventArgs e)
        {
            (sender as AButton).BackgroundColor = BaseColor.DenNhat;
        }

        private void abtnListMusic_Click(object sender, EventArgs e)
        {
            deactiveAllButton();
            AButton currentAbtn = (AButton)sender;
            activeButton(currentAbtn);
            currentAbtn.Image = Properties.Resources.musicActiveIcon;

            _musics = new ObservableCollection<Music>(__musics);
            musics = new ObservableCollection<Music>(_musics);
            loadMusics();
        }

        private void abtnLikeSong_Click(object sender, EventArgs e)
        {
            deactiveAllButton();
            AButton currentAbtn = (AButton)sender;
            activeButton(currentAbtn);
            currentAbtn.Image = Properties.Resources.LikeSongActiveIcon;

            _musics = new ObservableCollection<Music>(musicLove);
            musics = new ObservableCollection<Music>(_musics);
            loadMusics();
        }

        private void abtnRecently_Click(object sender, EventArgs e)
        {
            deactiveAllButton();
            AButton currentAbtn = (AButton)sender;
            activeButton(currentAbtn);
            currentAbtn.Image = Properties.Resources.recentlyActiveIcon;
            _musics = new ObservableCollection<Music>(musicRecently);
            musics = new ObservableCollection<Music>(_musics);
            loadMusics();
        }

        #endregion

        #region slider

        private float defaultValue = 0.1f, min = 0.0f, max = 1.0f;
        private bool isMouse = false;


        private float Bar(float value)
        {
            return (slider.Width - 24) * (value - min) / (float)(max - min);
        }

        private void thumb(float value)
        {
            if (value < min) value = min;
            if (value > max) value = max;
            defaultValue = value;
            slider.Refresh();
        }

        private float slider_width(int x)
        {
            return min + (max - min) * x / (float)(slider.Width);
        }

        private void slider_Paint(object sender, PaintEventArgs e)
        {
            float barSize = 0.25f;
            float x = Bar(defaultValue);
            int y = (int)(slider.Height * barSize);

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.FillRectangle(new SolidBrush(BaseColor.Xam), 0, y, slider.Width, y / 2);
            g.FillRectangle(new SolidBrush(BaseColor.XanhLa), 0, y, x, y / 2);

            using (Pen pen = new Pen(BaseColor.XanhLa, 6))
            {
                g.DrawEllipse(pen, x + 4, y - 6, slider.Height / 2, slider.Height / 2);
                g.FillEllipse(Brushes.White, x + 4, y - 6, slider.Height / 2, slider.Height / 2);
            }
        }

        private void slider_MouseDown(object sender, MouseEventArgs e)
        {
            isMouse = true;
            player.controls.pause();
            thumb(slider_width(e.X));
            player.controls.currentPosition = player.currentMedia.duration * e.X / slider.Width;
        }

        private void slider_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isMouse) return;
            thumb(slider_width(e.X));
            player.controls.currentPosition = player.currentMedia.duration * e.X / slider.Width;
        }

        private void slider_MouseUp(object sender, MouseEventArgs e)
        {
            isMouse = false;
            player.controls.play();
        }

        private void timePlay_Tick(object sender, EventArgs e)
        {
            if (player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                max = (int)player.controls.currentItem.duration;
                defaultValue = (int)player.controls.currentPosition;
                slider.Invalidate();

                lbStart.Text = player.controls.currentPositionString;
                lbEnd.Text = player.currentMedia.durationString;
            }

            if (player.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                lbStart.Text = player.currentMedia.durationString;
            }
        }

        #endregion

        #region control music
        private void onMp3()
        {
            if (string.IsNullOrEmpty(player.URL))
            {
                HVControl(pnControlMusic);
                HVControl(pnDetailMusic);
            }
        }

        private void runMp3(string path)
        {
            player.URL = Path.GetFullPath(path);
            player.controls.play();
            pibPlayOrPause.BackgroundImage = Properties.Resources.pause;
        }

        private void pibNext_Click(object sender, EventArgs e)
        {
            if (musics.Count <= 1)
                player.controls.stop();
            else
            {
                int indexMusic = musics.IndexOf(currentMusicSelected);

                if (indexMusic == -1)
                    currentMusicSelected = musics[0];
                else
                {
                    if (indexMusic + 1 < musics.Count)
                        currentMusicSelected = musics[indexMusic + 1];
                    else
                        currentMusicSelected = musics[0];
                }
            }
        }

        private void pibPrevious_Click(object sender, EventArgs e)
        {
            if (musics.Count <= 1)
                player.controls.stop();
            else
            {
                int indexMusic = musics.IndexOf(currentMusicSelected);

                if (indexMusic == -1)
                    currentMusicSelected = musics[0];
                else
                {
                    if (indexMusic - 1 >= 0)
                        currentMusicSelected = musics[indexMusic - 1];
                    else
                        currentMusicSelected = musics[musics.Count - 1];
                }
            }
        }

        private void pibPlayOrPause_Click(object sender, EventArgs e)
        {
            switch (player.playState)
            {
                case WMPLib.WMPPlayState.wmppsPaused:
                    player.controls.play();
                    pibPlayOrPause.BackgroundImage = Properties.Resources._001_pause;
                    break;

                case WMPLib.WMPPlayState.wmppsPlaying:
                    player.controls.pause();
                    pibPlayOrPause.BackgroundImage = Properties.Resources.play;
                    break;
            }
        }

        #endregion

        #region body music
        private void loadMusics()
        {
            flpMusics.Controls.Clear();

            for (int i = 0; i < musics.Count; ++i)
            {
                Music music = musics[i];
                ItemMusic im = new ItemMusic(music.Title, music.ArtistsNames, Helper.loadImagePath("../../CreateData/Image/" + music.Title + ".jpg"));
                flpMusics.Controls.Add(im);

                int cnt = i + 1;
                if (cnt % 3 == 0)
                {
                    int hTitle = 0;
                    int hArtistsNames = 0;

                    for (int j = 1; j <= 3; ++j)
                    {
                        ItemMusic currentItemMu = flpMusics.Controls[cnt - j] as ItemMusic;
                        hTitle = Math.Max(hTitle, currentItemMu.getHeightPanelTitle());
                        hArtistsNames = Math.Max(hArtistsNames, currentItemMu.getHeightPanelArtistsNames());
                    }

                    for (int j = 1; j <= 3; ++j)
                        (flpMusics.Controls[cnt - j] as ItemMusic).setHeight(hTitle, hArtistsNames);
                }
                else if (cnt == musics.Count && cnt % 3 == 2)
                {
                    int hTitle = 0;
                    int hArtistsNames = 0;

                    for (int j = 1; j <= 2; ++j)
                    {
                        ItemMusic currentItemMu = flpMusics.Controls[cnt - j] as ItemMusic;
                        hTitle = Math.Max(hTitle, currentItemMu.getHeightPanelTitle());
                        hArtistsNames = Math.Max(hArtistsNames, currentItemMu.getHeightPanelArtistsNames());
                    }

                    for (int j = 1; j <= 2; ++j)
                        (flpMusics.Controls[cnt - j] as ItemMusic).setHeight(hTitle, hArtistsNames);

                }
            }
        }

        private void loadDataCombobox()
        {
            cbType.Items.Insert(0, "Toàn bộ");
            string[] dataCombobox = genres.Concat(types).ToArray().Distinct().ToArray();
            Array.Sort(dataCombobox, (x, y) => string.Compare(x, y));
            cbType.Items.AddRange(dataCombobox);
        }

        private void atbSearch__TextChanged(object sender, EventArgs e)
        {
            if (textSearch != atbSearch.Texts)
            {
                textSearch = atbSearch.Texts;
                filterMusic();
            }
        }

        private void cbType_SelectedValueChanged(object sender, EventArgs e)
        {
            if (typeMusicSelected != cbType.Text)
            {
                typeMusicSelected = cbType.Text;
                filterMusic();
            }
        }

        private void filterMusic()
        {
            if (string.IsNullOrEmpty(textSearch)) musics = new ObservableCollection<Music>(_musics);
            else musics = new ObservableCollection<Music>(_musics.Where(music => music.Title.ToLower().Contains(atbSearch.Texts.ToLower()) || music.ArtistsNames.ToLower().Contains(atbSearch.Texts.ToLower())).ToList());

            if (!(string.IsNullOrEmpty(typeMusicSelected) || typeMusicSelected == "Toàn bộ"))
                musics = new ObservableCollection<Music>(musics.Where((music) => music.Type == typeMusicSelected || music.Genre == typeMusicSelected));

            loadMusics();
        }

        #endregion

        #region detail music
        private void pibLoveSong_Click(object sender, EventArgs e)
        {
            if (musicLove.Contains(currentMusicSelected))
            {
                pibLoveSong.BackgroundImage = Properties.Resources.heartDeactive;
                musicLove.Remove(currentMusicSelected);
            }
            else // Chưa có
            {
                pibLoveSong.BackgroundImage = Properties.Resources.heartActive;
                musicLove.Insert(0, currentMusicSelected);
            }
        }

        private void pibDownload_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.Description = "Chọn vị trí lưu nhạc";

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFolderPath = folderBrowserDialog.SelectedPath;

                try
                {
                    string sourceFilePath = "../../CreateData/Mp3/" + currentMusicSelected.Title + ".mp3";
                    string destinationFilePath = Path.Combine(selectedFolderPath, currentMusicSelected.Title + " (MusicOnline).mp3");
                    bool isSave = true;

                    if (File.Exists(destinationFilePath))
                    {
                        AMessageBoxFrm ms = new AMessageBoxFrm("Bạn có muốn lưu đè lên tệp cũ không?", "Tệp đã tồn tại!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        
                        if (ms.ShowDialog() == DialogResult.Yes)
                            File.Copy(sourceFilePath, destinationFilePath, true);
                        else isSave = false;
                    }
                    else File.Copy(sourceFilePath, destinationFilePath);
                    
                    if (isSave)
                    {
                        AMessageBoxFrm ms = new AMessageBoxFrm("Tải xuống thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ms.ShowDialog();
                    }
                }
                catch(Exception ex)
                {
                    AMessageBoxFrm ms = new AMessageBoxFrm(ex.Message, "lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ms.ShowDialog();
                }
            }
        }

        private void abtnComment_Click(object sender, EventArgs e)
        {
            FrmComment _formComment = new FrmComment();
            _formComment.ShowDialog();
        }

        private void abtnLyrics_Click(object sender, EventArgs e)
        {
            FrmLyrics _formLyrics = new FrmLyrics(currentMusicSelected.Lyrics);
            _formLyrics.ShowDialog();
        }

        private void renderDetailMusic()
        {
            pibThumbnail.BackgroundImage = Helper.loadImagePath("../../CreateData/Image/" + currentMusicSelected.Title + ".jpg");

            pnAddToPlaylist.Visible = false;
            pibAddToPlaylist.Visible = true;

            if (musicLove.Contains(currentMusicSelected))
                pibLoveSong.BackgroundImage = Properties.Resources.heartActive;
            else
                pibLoveSong.BackgroundImage = Properties.Resources.heartDeactive;

            lbTitle.Text = currentMusicSelected.Title;
            pnTitle.Height = lbTitle.Height + 15;

            lbArtistsNames.Text = currentMusicSelected.ArtistsNames;
            pnArtistsNames.Height = lbArtistsNames.Height + 10;

            lbGenre.Text = currentMusicSelected.Genre;
            pnGenre.Height = lbGenre.Height + 10;

            lbType.Text = currentMusicSelected.Type;
            pnType.Height = lbType.Height + 10;

            try
            {
                ObservableCollection<Comment> commnets = Data.GetArrayComment(currentMusicSelected).comments;
                double rating = 0;

                foreach (Comment comment in commnets)
                    rating += comment.start;

                rating /= commnets.Count();
                rating = Math.Round(rating, 1);
                lbRating.Text = rating.ToString("0.0");
            }
            catch (Exception ex)
            {
                lbRating.Text = "0.0";
            }
        }

        private void pibCancel_Click(object sender, EventArgs e)
        {
            pnAddToPlaylist.Visible = false;
            pibAddToPlaylist.Visible = true;
        }

        private void pibAddToPlaylist_Click(object sender, EventArgs e)
        {
            pnAddToPlaylist.Visible = true;
            pibAddToPlaylist.Visible = false;
        }

        private void pibAccept_Click(object sender, EventArgs e)
        {
            Data.addMusicToPlayList(cbAddToPlaylist.Text, currentMusicSelected);
        }

        #endregion

        #region playlist
        private void lbAddPlaylist_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(atbNamePlaylist.Texts))
            {
                Playlist pl = new Playlist(atbNamePlaylist.Texts);

                if (Data.addDataPlaylist(pl))
                {
                    PlaylistItemUC newPlaylist = new PlaylistItemUC(pl);
                    newPlaylist.Dock = DockStyle.Top;
                    pnListPlaylist.Controls.Add(newPlaylist);
                
                    cbAddToPlaylist.Items.Add(atbNamePlaylist.Texts);
                }
            }
            else
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("Không được để trống giá trị", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ms.ShowDialog();
            }
        }

        public void removePlaylist(string name)
        {
            PlaylistItemUC pl = null;

            foreach(PlaylistItemUC _pl  in pnListPlaylist.Controls)
            {
                if (_pl.playlist.name == name)
                {
                    pl = _pl;
                }
            }

            pnListPlaylist.Controls.Remove(pl);

            cbAddToPlaylist.Items.Remove(name);
            if (currentPlaylist.name == name)
                abtnListMusic_Click(abtnListMusic, EventArgs.Empty);
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

        public void updateListPlaylist()
        {
            cbAddToPlaylist.Items.Clear();
            foreach(PlaylistItemUC playlistItem in pnListPlaylist.Controls)
            {
                playlistItem.playlist = playlistItem.playlist;
                cbAddToPlaylist.Items.Add(playlistItem.playlist.name);
            }
        }

        public void loadPlaylist(Playlist playlist)
        {
            _musics = new ObservableCollection<Music>(playlist.musics);
            musics = new ObservableCollection<Music>(playlist.musics);
            loadMusics();
            
            // Lưu lại
            currentPlaylist = playlist;
            deactiveAllButton();
        }
        #endregion
    }
}
