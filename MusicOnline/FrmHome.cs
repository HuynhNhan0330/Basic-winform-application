using MusicOnline.Model;
using MusicOnline.Usercontrols;
using MusicOnline.Utils;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace MusicOnline
{
    public partial class FrmHome : Form
    {
        private WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
        private ObservableCollection<Music> musics = new ObservableCollection<Music>();

        public FrmHome()
        {
            InitializeComponent();
        }

        private void pibClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void runMp3(string path)
        {
            player.URL = path;
            player.controls.play();
        }

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
            }
        }

        #endregion

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
                                Lyrics = element.GetProperty("lyrics").GetString()
                            };

                            musics.Add(music);
                        }
                    }
                }
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

        private void loadMusics()
        {
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

        private void FrmHome_Load(object sender, EventArgs e)
        {
            LoadData();
            loadMusics();
        }
    }
}
