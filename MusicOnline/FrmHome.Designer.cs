namespace MusicOnline
{
    partial class FrmHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timePlay = new System.Windows.Forms.Timer(this.components);
            this.pnControlMusic = new System.Windows.Forms.Panel();
            this.lbEnd = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pibPrevious = new System.Windows.Forms.PictureBox();
            this.pibNext = new System.Windows.Forms.PictureBox();
            this.pibPlayOrPause = new System.Windows.Forms.PictureBox();
            this.lbStart = new System.Windows.Forms.Label();
            this.slider = new MusicOnline.APanel();
            this.pnTop = new System.Windows.Forms.Panel();
            this.pibClose = new System.Windows.Forms.PictureBox();
            this.pnBody = new System.Windows.Forms.Panel();
            this.aPanel1 = new MusicOnline.APanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.atbSearch = new MusicOnline.ATextboxUC();
            this.flpMusics = new System.Windows.Forms.FlowLayoutPanel();
            this.pnDetailMusic = new MusicOnline.APanel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.abtnComment = new MusicOnline.AButton();
            this.abtnLyrics = new MusicOnline.AButton();
            this.pnType = new System.Windows.Forms.Panel();
            this.lbType = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pnGenre = new System.Windows.Forms.Panel();
            this.lbGenre = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnArtistsNames = new System.Windows.Forms.Panel();
            this.lbArtistsNames = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnTitle = new System.Windows.Forms.Panel();
            this.pibLoveSong = new System.Windows.Forms.PictureBox();
            this.pibDownload = new System.Windows.Forms.PictureBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.pnThumbnail = new System.Windows.Forms.Panel();
            this.pnAddToPlaylist = new System.Windows.Forms.Panel();
            this.pibCancel = new System.Windows.Forms.PictureBox();
            this.pibAccept = new System.Windows.Forms.PictureBox();
            this.cbAddToPlaylist = new System.Windows.Forms.ComboBox();
            this.pibAddToPlaylist = new System.Windows.Forms.PictureBox();
            this.lbRating = new System.Windows.Forms.Label();
            this.pibStar = new System.Windows.Forms.PictureBox();
            this.pibThumbnail = new System.Windows.Forms.PictureBox();
            this.pn = new MusicOnline.APanel();
            this.aPanel2 = new MusicOnline.APanel();
            this.pnListPlaylist = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbAddPlaylist = new System.Windows.Forms.Label();
            this.atbNamePlaylist = new MusicOnline.ATextboxUC();
            this.pnPlaylist = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnMenu = new MusicOnline.APanel();
            this.abtnRecently = new MusicOnline.AButton();
            this.abtnLikeSong = new MusicOnline.AButton();
            this.abtnListMusic = new MusicOnline.AButton();
            this.pnBottom = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.pnControlMusic.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibPrevious)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibPlayOrPause)).BeginInit();
            this.pnTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibClose)).BeginInit();
            this.pnBody.SuspendLayout();
            this.aPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnDetailMusic.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.pnType.SuspendLayout();
            this.pnGenre.SuspendLayout();
            this.pnArtistsNames.SuspendLayout();
            this.pnTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibLoveSong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibDownload)).BeginInit();
            this.pnThumbnail.SuspendLayout();
            this.pnAddToPlaylist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibAccept)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibAddToPlaylist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibStar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibThumbnail)).BeginInit();
            this.pn.SuspendLayout();
            this.aPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnPlaylist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnMenu.SuspendLayout();
            this.pnBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // timePlay
            // 
            this.timePlay.Enabled = true;
            this.timePlay.Interval = 500;
            this.timePlay.Tick += new System.EventHandler(this.timePlay_Tick);
            // 
            // pnControlMusic
            // 
            this.pnControlMusic.Controls.Add(this.lbEnd);
            this.pnControlMusic.Controls.Add(this.panel7);
            this.pnControlMusic.Controls.Add(this.lbStart);
            this.pnControlMusic.Controls.Add(this.slider);
            this.pnControlMusic.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnControlMusic.Location = new System.Drawing.Point(380, 0);
            this.pnControlMusic.Name = "pnControlMusic";
            this.pnControlMusic.Size = new System.Drawing.Size(700, 100);
            this.pnControlMusic.TabIndex = 1;
            // 
            // lbEnd
            // 
            this.lbEnd.AutoSize = true;
            this.lbEnd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.lbEnd.Location = new System.Drawing.Point(660, 56);
            this.lbEnd.Name = "lbEnd";
            this.lbEnd.Size = new System.Drawing.Size(38, 16);
            this.lbEnd.TabIndex = 3;
            this.lbEnd.Text = "00:00";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.pibPrevious);
            this.panel7.Controls.Add(this.pibNext);
            this.panel7.Controls.Add(this.pibPlayOrPause);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(700, 40);
            this.panel7.TabIndex = 2;
            // 
            // pibPrevious
            // 
            this.pibPrevious.BackgroundImage = global::MusicOnline.Properties.Resources.previousIcon;
            this.pibPrevious.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pibPrevious.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pibPrevious.Location = new System.Drawing.Point(290, 10);
            this.pibPrevious.Name = "pibPrevious";
            this.pibPrevious.Size = new System.Drawing.Size(20, 20);
            this.pibPrevious.TabIndex = 4;
            this.pibPrevious.TabStop = false;
            this.pibPrevious.Click += new System.EventHandler(this.pibPrevious_Click);
            // 
            // pibNext
            // 
            this.pibNext.BackgroundImage = global::MusicOnline.Properties.Resources.play_and_pause_button;
            this.pibNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pibNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pibNext.Location = new System.Drawing.Point(390, 10);
            this.pibNext.Name = "pibNext";
            this.pibNext.Size = new System.Drawing.Size(20, 20);
            this.pibNext.TabIndex = 3;
            this.pibNext.TabStop = false;
            this.pibNext.Click += new System.EventHandler(this.pibNext_Click);
            // 
            // pibPlayOrPause
            // 
            this.pibPlayOrPause.BackgroundImage = global::MusicOnline.Properties.Resources._001_pause;
            this.pibPlayOrPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pibPlayOrPause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pibPlayOrPause.Location = new System.Drawing.Point(330, 0);
            this.pibPlayOrPause.Name = "pibPlayOrPause";
            this.pibPlayOrPause.Size = new System.Drawing.Size(40, 40);
            this.pibPlayOrPause.TabIndex = 2;
            this.pibPlayOrPause.TabStop = false;
            this.pibPlayOrPause.Click += new System.EventHandler(this.pibPlayOrPause_Click);
            // 
            // lbStart
            // 
            this.lbStart.AutoSize = true;
            this.lbStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.lbStart.Location = new System.Drawing.Point(0, 56);
            this.lbStart.Name = "lbStart";
            this.lbStart.Size = new System.Drawing.Size(38, 16);
            this.lbStart.TabIndex = 1;
            this.lbStart.Text = "00:00";
            // 
            // slider
            // 
            this.slider.BackColor = System.Drawing.Color.Transparent;
            this.slider.BackgroundColor = System.Drawing.Color.Transparent;
            this.slider.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.slider.BorderRadius = 0;
            this.slider.BorderSize = 0;
            this.slider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.slider.ForeColor = System.Drawing.Color.White;
            this.slider.Location = new System.Drawing.Point(50, 50);
            this.slider.Name = "slider";
            this.slider.RoundType = MusicOnline.APanel.RoundStyles.Full;
            this.slider.Size = new System.Drawing.Size(600, 45);
            this.slider.TabIndex = 0;
            this.slider.TextColor = System.Drawing.Color.White;
            this.slider.Paint += new System.Windows.Forms.PaintEventHandler(this.slider_Paint);
            this.slider.MouseDown += new System.Windows.Forms.MouseEventHandler(this.slider_MouseDown);
            this.slider.MouseMove += new System.Windows.Forms.MouseEventHandler(this.slider_MouseMove);
            this.slider.MouseUp += new System.Windows.Forms.MouseEventHandler(this.slider_MouseUp);
            // 
            // pnTop
            // 
            this.pnTop.Controls.Add(this.pibClose);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(1500, 30);
            this.pnTop.TabIndex = 4;
            // 
            // pibClose
            // 
            this.pibClose.BackgroundImage = global::MusicOnline.Properties.Resources.CloseIcon2;
            this.pibClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pibClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pibClose.Location = new System.Drawing.Point(1470, 10);
            this.pibClose.Name = "pibClose";
            this.pibClose.Size = new System.Drawing.Size(20, 20);
            this.pibClose.TabIndex = 0;
            this.pibClose.TabStop = false;
            this.pibClose.Click += new System.EventHandler(this.pibClose_Click);
            // 
            // pnBody
            // 
            this.pnBody.Controls.Add(this.aPanel1);
            this.pnBody.Controls.Add(this.pnDetailMusic);
            this.pnBody.Controls.Add(this.pn);
            this.pnBody.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnBody.Location = new System.Drawing.Point(0, 30);
            this.pnBody.Name = "pnBody";
            this.pnBody.Size = new System.Drawing.Size(1500, 720);
            this.pnBody.TabIndex = 5;
            // 
            // aPanel1
            // 
            this.aPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.aPanel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.aPanel1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.aPanel1.BorderRadius = 15;
            this.aPanel1.BorderSize = 0;
            this.aPanel1.Controls.Add(this.panel1);
            this.aPanel1.Controls.Add(this.flpMusics);
            this.aPanel1.ForeColor = System.Drawing.Color.White;
            this.aPanel1.Location = new System.Drawing.Point(380, 15);
            this.aPanel1.Name = "aPanel1";
            this.aPanel1.RoundType = MusicOnline.APanel.RoundStyles.Full;
            this.aPanel1.Size = new System.Drawing.Size(700, 690);
            this.aPanel1.TabIndex = 7;
            this.aPanel1.TextColor = System.Drawing.Color.White;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbType);
            this.panel1.Controls.Add(this.atbSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 50);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(304, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Thể loại:";
            // 
            // cbType
            // 
            this.cbType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.cbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbType.ForeColor = System.Drawing.Color.White;
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(390, 18);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(280, 28);
            this.cbType.TabIndex = 1;
            this.cbType.Text = "Toàn bộ";
            this.cbType.SelectedValueChanged += new System.EventHandler(this.cbType_SelectedValueChanged);
            // 
            // atbSearch
            // 
            this.atbSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.atbSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.atbSearch.BorderFocusColor = System.Drawing.Color.White;
            this.atbSearch.BorderRadius = 10;
            this.atbSearch.BorderSize = 2;
            this.atbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atbSearch.ForeColor = System.Drawing.Color.White;
            this.atbSearch.Location = new System.Drawing.Point(30, 15);
            this.atbSearch.Margin = new System.Windows.Forms.Padding(4);
            this.atbSearch.Multiline = false;
            this.atbSearch.Name = "atbSearch";
            this.atbSearch.Padding = new System.Windows.Forms.Padding(7);
            this.atbSearch.PasswordChar = false;
            this.atbSearch.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.atbSearch.PlaceholderText = " Tìm kiếm";
            this.atbSearch.RoundType = MusicOnline.ATextboxUC.RoundStyles.Full;
            this.atbSearch.Size = new System.Drawing.Size(250, 35);
            this.atbSearch.TabIndex = 0;
            this.atbSearch.Texts = "";
            this.atbSearch.UnderlinedStyle = false;
            this.atbSearch._TextChanged += new System.EventHandler(this.atbSearch__TextChanged);
            // 
            // flpMusics
            // 
            this.flpMusics.AutoScroll = true;
            this.flpMusics.Location = new System.Drawing.Point(30, 65);
            this.flpMusics.Name = "flpMusics";
            this.flpMusics.Size = new System.Drawing.Size(640, 610);
            this.flpMusics.TabIndex = 1;
            // 
            // pnDetailMusic
            // 
            this.pnDetailMusic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.pnDetailMusic.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.pnDetailMusic.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.pnDetailMusic.BorderRadius = 10;
            this.pnDetailMusic.BorderSize = 0;
            this.pnDetailMusic.Controls.Add(this.panel8);
            this.pnDetailMusic.Controls.Add(this.pnThumbnail);
            this.pnDetailMusic.ForeColor = System.Drawing.Color.White;
            this.pnDetailMusic.Location = new System.Drawing.Point(1100, 15);
            this.pnDetailMusic.Name = "pnDetailMusic";
            this.pnDetailMusic.RoundType = MusicOnline.APanel.RoundStyles.Full;
            this.pnDetailMusic.Size = new System.Drawing.Size(380, 690);
            this.pnDetailMusic.TabIndex = 6;
            this.pnDetailMusic.TextColor = System.Drawing.Color.White;
            // 
            // panel8
            // 
            this.panel8.AutoScroll = true;
            this.panel8.Controls.Add(this.panel9);
            this.panel8.Controls.Add(this.pnType);
            this.panel8.Controls.Add(this.pnGenre);
            this.panel8.Controls.Add(this.pnArtistsNames);
            this.panel8.Controls.Add(this.pnTitle);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(0, 410);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(380, 280);
            this.panel8.TabIndex = 5;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.abtnComment);
            this.panel9.Controls.Add(this.abtnLyrics);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel9.Location = new System.Drawing.Point(0, 220);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(380, 60);
            this.panel9.TabIndex = 8;
            // 
            // abtnComment
            // 
            this.abtnComment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(155)))), ((int)(((byte)(70)))));
            this.abtnComment.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(155)))), ((int)(((byte)(70)))));
            this.abtnComment.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.abtnComment.BorderRadius = 15;
            this.abtnComment.BorderSize = 0;
            this.abtnComment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.abtnComment.FlatAppearance.BorderSize = 0;
            this.abtnComment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.abtnComment.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abtnComment.ForeColor = System.Drawing.Color.White;
            this.abtnComment.LineType = MusicOnline.AButton.LineStyles.None;
            this.abtnComment.Location = new System.Drawing.Point(185, 10);
            this.abtnComment.Name = "abtnComment";
            this.abtnComment.RoundType = MusicOnline.AButton.RoundStyles.Full;
            this.abtnComment.Size = new System.Drawing.Size(160, 40);
            this.abtnComment.TabIndex = 1;
            this.abtnComment.Text = "Bình Luận";
            this.abtnComment.TextColor = System.Drawing.Color.White;
            this.abtnComment.ThinknessLine = 0;
            this.abtnComment.UseVisualStyleBackColor = false;
            this.abtnComment.Click += new System.EventHandler(this.abtnComment_Click);
            // 
            // abtnLyrics
            // 
            this.abtnLyrics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(155)))), ((int)(((byte)(70)))));
            this.abtnLyrics.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(155)))), ((int)(((byte)(70)))));
            this.abtnLyrics.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.abtnLyrics.BorderRadius = 15;
            this.abtnLyrics.BorderSize = 0;
            this.abtnLyrics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.abtnLyrics.FlatAppearance.BorderSize = 0;
            this.abtnLyrics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.abtnLyrics.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abtnLyrics.ForeColor = System.Drawing.Color.White;
            this.abtnLyrics.LineType = MusicOnline.AButton.LineStyles.None;
            this.abtnLyrics.Location = new System.Drawing.Point(15, 10);
            this.abtnLyrics.Name = "abtnLyrics";
            this.abtnLyrics.RoundType = MusicOnline.AButton.RoundStyles.Full;
            this.abtnLyrics.Size = new System.Drawing.Size(160, 40);
            this.abtnLyrics.TabIndex = 0;
            this.abtnLyrics.Text = "Lời bài hát";
            this.abtnLyrics.TextColor = System.Drawing.Color.White;
            this.abtnLyrics.ThinknessLine = 0;
            this.abtnLyrics.UseVisualStyleBackColor = false;
            this.abtnLyrics.Click += new System.EventHandler(this.abtnLyrics_Click);
            // 
            // pnType
            // 
            this.pnType.Controls.Add(this.lbType);
            this.pnType.Controls.Add(this.label7);
            this.pnType.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnType.Location = new System.Drawing.Point(0, 130);
            this.pnType.Name = "pnType";
            this.pnType.Size = new System.Drawing.Size(380, 40);
            this.pnType.TabIndex = 7;
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.lbType.Location = new System.Drawing.Point(110, 10);
            this.lbType.MaximumSize = new System.Drawing.Size(250, 0);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(38, 20);
            this.lbType.TabIndex = 1;
            this.lbType.Text = "Việt";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.label7.Location = new System.Drawing.Point(15, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Nhạc:";
            // 
            // pnGenre
            // 
            this.pnGenre.Controls.Add(this.lbGenre);
            this.pnGenre.Controls.Add(this.label4);
            this.pnGenre.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnGenre.Location = new System.Drawing.Point(0, 90);
            this.pnGenre.Name = "pnGenre";
            this.pnGenre.Size = new System.Drawing.Size(380, 40);
            this.pnGenre.TabIndex = 6;
            // 
            // lbGenre
            // 
            this.lbGenre.AutoSize = true;
            this.lbGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGenre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.lbGenre.Location = new System.Drawing.Point(110, 10);
            this.lbGenre.MaximumSize = new System.Drawing.Size(250, 0);
            this.lbGenre.Name = "lbGenre";
            this.lbGenre.Size = new System.Drawing.Size(55, 20);
            this.lbGenre.TabIndex = 1;
            this.lbGenre.Text = "V-Pop";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.label4.Location = new System.Drawing.Point(15, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Thể loại:";
            // 
            // pnArtistsNames
            // 
            this.pnArtistsNames.Controls.Add(this.lbArtistsNames);
            this.pnArtistsNames.Controls.Add(this.label5);
            this.pnArtistsNames.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnArtistsNames.Location = new System.Drawing.Point(0, 50);
            this.pnArtistsNames.Name = "pnArtistsNames";
            this.pnArtistsNames.Size = new System.Drawing.Size(380, 40);
            this.pnArtistsNames.TabIndex = 4;
            // 
            // lbArtistsNames
            // 
            this.lbArtistsNames.AutoSize = true;
            this.lbArtistsNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbArtistsNames.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.lbArtistsNames.Location = new System.Drawing.Point(110, 10);
            this.lbArtistsNames.MaximumSize = new System.Drawing.Size(250, 0);
            this.lbArtistsNames.Name = "lbArtistsNames";
            this.lbArtistsNames.Size = new System.Drawing.Size(75, 20);
            this.lbArtistsNames.TabIndex = 1;
            this.lbArtistsNames.Text = "Sơn tùng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.label5.Location = new System.Drawing.Point(15, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ca sĩ:";
            // 
            // pnTitle
            // 
            this.pnTitle.Controls.Add(this.pibLoveSong);
            this.pnTitle.Controls.Add(this.pibDownload);
            this.pnTitle.Controls.Add(this.lbTitle);
            this.pnTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTitle.Location = new System.Drawing.Point(0, 0);
            this.pnTitle.Name = "pnTitle";
            this.pnTitle.Size = new System.Drawing.Size(380, 50);
            this.pnTitle.TabIndex = 5;
            // 
            // pibLoveSong
            // 
            this.pibLoveSong.BackgroundImage = global::MusicOnline.Properties.Resources.heartDeactive;
            this.pibLoveSong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pibLoveSong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pibLoveSong.Location = new System.Drawing.Point(280, 17);
            this.pibLoveSong.Name = "pibLoveSong";
            this.pibLoveSong.Size = new System.Drawing.Size(25, 25);
            this.pibLoveSong.TabIndex = 3;
            this.pibLoveSong.TabStop = false;
            this.pibLoveSong.Click += new System.EventHandler(this.pibLoveSong_Click);
            // 
            // pibDownload
            // 
            this.pibDownload.BackgroundImage = global::MusicOnline.Properties.Resources.downloads;
            this.pibDownload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pibDownload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pibDownload.Location = new System.Drawing.Point(320, 15);
            this.pibDownload.Name = "pibDownload";
            this.pibDownload.Size = new System.Drawing.Size(25, 25);
            this.pibDownload.TabIndex = 2;
            this.pibDownload.TabStop = false;
            this.pibDownload.Click += new System.EventHandler(this.pibDownload_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.White;
            this.lbTitle.Location = new System.Drawing.Point(11, 15);
            this.lbTitle.MaximumSize = new System.Drawing.Size(250, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(217, 25);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "Chúng ta của hiện tại";
            // 
            // pnThumbnail
            // 
            this.pnThumbnail.Controls.Add(this.pnAddToPlaylist);
            this.pnThumbnail.Controls.Add(this.pibAddToPlaylist);
            this.pnThumbnail.Controls.Add(this.lbRating);
            this.pnThumbnail.Controls.Add(this.pibStar);
            this.pnThumbnail.Controls.Add(this.pibThumbnail);
            this.pnThumbnail.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnThumbnail.Location = new System.Drawing.Point(0, 0);
            this.pnThumbnail.Name = "pnThumbnail";
            this.pnThumbnail.Size = new System.Drawing.Size(380, 410);
            this.pnThumbnail.TabIndex = 1;
            // 
            // pnAddToPlaylist
            // 
            this.pnAddToPlaylist.Controls.Add(this.pibCancel);
            this.pnAddToPlaylist.Controls.Add(this.pibAccept);
            this.pnAddToPlaylist.Controls.Add(this.cbAddToPlaylist);
            this.pnAddToPlaylist.Location = new System.Drawing.Point(128, 380);
            this.pnAddToPlaylist.Name = "pnAddToPlaylist";
            this.pnAddToPlaylist.Size = new System.Drawing.Size(220, 30);
            this.pnAddToPlaylist.TabIndex = 7;
            // 
            // pibCancel
            // 
            this.pibCancel.BackgroundImage = global::MusicOnline.Properties.Resources.cancel;
            this.pibCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pibCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pibCancel.Location = new System.Drawing.Point(200, 5);
            this.pibCancel.Name = "pibCancel";
            this.pibCancel.Size = new System.Drawing.Size(15, 15);
            this.pibCancel.TabIndex = 8;
            this.pibCancel.TabStop = false;
            this.pibCancel.Click += new System.EventHandler(this.pibCancel_Click);
            // 
            // pibAccept
            // 
            this.pibAccept.BackgroundImage = global::MusicOnline.Properties.Resources.checkmarks;
            this.pibAccept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pibAccept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pibAccept.Location = new System.Drawing.Point(165, 0);
            this.pibAccept.Name = "pibAccept";
            this.pibAccept.Size = new System.Drawing.Size(25, 25);
            this.pibAccept.TabIndex = 7;
            this.pibAccept.TabStop = false;
            this.pibAccept.Click += new System.EventHandler(this.pibAccept_Click);
            // 
            // cbAddToPlaylist
            // 
            this.cbAddToPlaylist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.cbAddToPlaylist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAddToPlaylist.ForeColor = System.Drawing.Color.White;
            this.cbAddToPlaylist.FormattingEnabled = true;
            this.cbAddToPlaylist.Location = new System.Drawing.Point(0, 0);
            this.cbAddToPlaylist.Name = "cbAddToPlaylist";
            this.cbAddToPlaylist.Size = new System.Drawing.Size(150, 26);
            this.cbAddToPlaylist.TabIndex = 6;
            // 
            // pibAddToPlaylist
            // 
            this.pibAddToPlaylist.BackgroundImage = global::MusicOnline.Properties.Resources.add_to_playlist__1_;
            this.pibAddToPlaylist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pibAddToPlaylist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pibAddToPlaylist.Location = new System.Drawing.Point(320, 380);
            this.pibAddToPlaylist.Name = "pibAddToPlaylist";
            this.pibAddToPlaylist.Size = new System.Drawing.Size(25, 25);
            this.pibAddToPlaylist.TabIndex = 0;
            this.pibAddToPlaylist.TabStop = false;
            this.pibAddToPlaylist.Click += new System.EventHandler(this.pibAddToPlaylist_Click);
            // 
            // lbRating
            // 
            this.lbRating.AutoSize = true;
            this.lbRating.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRating.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(71)))));
            this.lbRating.Location = new System.Drawing.Point(45, 384);
            this.lbRating.Name = "lbRating";
            this.lbRating.Size = new System.Drawing.Size(35, 21);
            this.lbRating.TabIndex = 5;
            this.lbRating.Text = "0.0";
            // 
            // pibStar
            // 
            this.pibStar.BackgroundImage = global::MusicOnline.Properties.Resources.StarActiveIcon1;
            this.pibStar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pibStar.Location = new System.Drawing.Point(15, 380);
            this.pibStar.Name = "pibStar";
            this.pibStar.Size = new System.Drawing.Size(25, 25);
            this.pibStar.TabIndex = 4;
            this.pibStar.TabStop = false;
            // 
            // pibThumbnail
            // 
            this.pibThumbnail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pibThumbnail.Location = new System.Drawing.Point(15, 15);
            this.pibThumbnail.Name = "pibThumbnail";
            this.pibThumbnail.Size = new System.Drawing.Size(350, 350);
            this.pibThumbnail.TabIndex = 0;
            this.pibThumbnail.TabStop = false;
            // 
            // pn
            // 
            this.pn.BackColor = System.Drawing.Color.Transparent;
            this.pn.BackgroundColor = System.Drawing.Color.Transparent;
            this.pn.BorderColor = System.Drawing.Color.Black;
            this.pn.BorderRadius = 10;
            this.pn.BorderSize = 0;
            this.pn.Controls.Add(this.aPanel2);
            this.pn.Controls.Add(this.pnMenu);
            this.pn.ForeColor = System.Drawing.Color.White;
            this.pn.Location = new System.Drawing.Point(10, 15);
            this.pn.Name = "pn";
            this.pn.RoundType = MusicOnline.APanel.RoundStyles.Full;
            this.pn.Size = new System.Drawing.Size(350, 690);
            this.pn.TabIndex = 4;
            this.pn.TextColor = System.Drawing.Color.White;
            // 
            // aPanel2
            // 
            this.aPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.aPanel2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.aPanel2.BorderColor = System.Drawing.Color.Black;
            this.aPanel2.BorderRadius = 10;
            this.aPanel2.BorderSize = 0;
            this.aPanel2.Controls.Add(this.pnListPlaylist);
            this.aPanel2.Controls.Add(this.panel2);
            this.aPanel2.Controls.Add(this.pnPlaylist);
            this.aPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.aPanel2.ForeColor = System.Drawing.Color.White;
            this.aPanel2.Location = new System.Drawing.Point(0, 180);
            this.aPanel2.Name = "aPanel2";
            this.aPanel2.RoundType = MusicOnline.APanel.RoundStyles.Full;
            this.aPanel2.Size = new System.Drawing.Size(350, 510);
            this.aPanel2.TabIndex = 6;
            this.aPanel2.TextColor = System.Drawing.Color.White;
            // 
            // pnListPlaylist
            // 
            this.pnListPlaylist.AutoScroll = true;
            this.pnListPlaylist.Location = new System.Drawing.Point(10, 120);
            this.pnListPlaylist.Name = "pnListPlaylist";
            this.pnListPlaylist.Size = new System.Drawing.Size(330, 375);
            this.pnListPlaylist.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbAddPlaylist);
            this.panel2.Controls.Add(this.atbNamePlaylist);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(350, 50);
            this.panel2.TabIndex = 3;
            // 
            // lbAddPlaylist
            // 
            this.lbAddPlaylist.AutoSize = true;
            this.lbAddPlaylist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbAddPlaylist.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddPlaylist.Location = new System.Drawing.Point(307, 18);
            this.lbAddPlaylist.Name = "lbAddPlaylist";
            this.lbAddPlaylist.Size = new System.Drawing.Size(33, 35);
            this.lbAddPlaylist.TabIndex = 4;
            this.lbAddPlaylist.Text = "+";
            this.lbAddPlaylist.Click += new System.EventHandler(this.lbAddPlaylist_Click);
            // 
            // atbNamePlaylist
            // 
            this.atbNamePlaylist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.atbNamePlaylist.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.atbNamePlaylist.BorderFocusColor = System.Drawing.Color.White;
            this.atbNamePlaylist.BorderRadius = 0;
            this.atbNamePlaylist.BorderSize = 2;
            this.atbNamePlaylist.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.atbNamePlaylist.ForeColor = System.Drawing.Color.White;
            this.atbNamePlaylist.Location = new System.Drawing.Point(15, 15);
            this.atbNamePlaylist.Margin = new System.Windows.Forms.Padding(4);
            this.atbNamePlaylist.Multiline = false;
            this.atbNamePlaylist.Name = "atbNamePlaylist";
            this.atbNamePlaylist.Padding = new System.Windows.Forms.Padding(7);
            this.atbNamePlaylist.PasswordChar = false;
            this.atbNamePlaylist.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.atbNamePlaylist.PlaceholderText = "Tên danh sách";
            this.atbNamePlaylist.RoundType = MusicOnline.ATextboxUC.RoundStyles.Full;
            this.atbNamePlaylist.Size = new System.Drawing.Size(285, 35);
            this.atbNamePlaylist.TabIndex = 2;
            this.atbNamePlaylist.Texts = "";
            this.atbNamePlaylist.UnderlinedStyle = true;
            this.atbNamePlaylist._TextChanged += new System.EventHandler(this.atbNamePlaylist__TextChanged);
            // 
            // pnPlaylist
            // 
            this.pnPlaylist.Controls.Add(this.pictureBox1);
            this.pnPlaylist.Controls.Add(this.label1);
            this.pnPlaylist.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnPlaylist.Location = new System.Drawing.Point(0, 0);
            this.pnPlaylist.Name = "pnPlaylist";
            this.pnPlaylist.Size = new System.Drawing.Size(350, 47);
            this.pnPlaylist.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::MusicOnline.Properties.Resources.libraryIcon1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(15, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách phát";
            // 
            // pnMenu
            // 
            this.pnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.pnMenu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.pnMenu.BorderColor = System.Drawing.Color.Black;
            this.pnMenu.BorderRadius = 10;
            this.pnMenu.BorderSize = 0;
            this.pnMenu.Controls.Add(this.abtnRecently);
            this.pnMenu.Controls.Add(this.abtnLikeSong);
            this.pnMenu.Controls.Add(this.abtnListMusic);
            this.pnMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnMenu.ForeColor = System.Drawing.Color.White;
            this.pnMenu.Location = new System.Drawing.Point(0, 0);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.RoundType = MusicOnline.APanel.RoundStyles.Full;
            this.pnMenu.Size = new System.Drawing.Size(350, 160);
            this.pnMenu.TabIndex = 5;
            this.pnMenu.TextColor = System.Drawing.Color.White;
            // 
            // abtnRecently
            // 
            this.abtnRecently.BackColor = System.Drawing.Color.Transparent;
            this.abtnRecently.BackgroundColor = System.Drawing.Color.Transparent;
            this.abtnRecently.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.abtnRecently.BorderRadius = 0;
            this.abtnRecently.BorderSize = 0;
            this.abtnRecently.Cursor = System.Windows.Forms.Cursors.Hand;
            this.abtnRecently.FlatAppearance.BorderSize = 0;
            this.abtnRecently.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.abtnRecently.Font = new System.Drawing.Font("Arial", 10F);
            this.abtnRecently.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.abtnRecently.Image = global::MusicOnline.Properties.Resources.recentlyDeactiveIcon;
            this.abtnRecently.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.abtnRecently.LineType = MusicOnline.AButton.LineStyles.None;
            this.abtnRecently.Location = new System.Drawing.Point(15, 105);
            this.abtnRecently.Name = "abtnRecently";
            this.abtnRecently.RoundType = MusicOnline.AButton.RoundStyles.Full;
            this.abtnRecently.Size = new System.Drawing.Size(320, 40);
            this.abtnRecently.TabIndex = 2;
            this.abtnRecently.Text = "      Nhạc gần đây";
            this.abtnRecently.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.abtnRecently.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.abtnRecently.ThinknessLine = 0;
            this.abtnRecently.UseVisualStyleBackColor = false;
            this.abtnRecently.Click += new System.EventHandler(this.abtnRecently_Click);
            this.abtnRecently.MouseHover += new System.EventHandler(this.abtnHover_MouseHover);
            // 
            // abtnLikeSong
            // 
            this.abtnLikeSong.BackColor = System.Drawing.Color.Transparent;
            this.abtnLikeSong.BackgroundColor = System.Drawing.Color.Transparent;
            this.abtnLikeSong.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.abtnLikeSong.BorderRadius = 0;
            this.abtnLikeSong.BorderSize = 0;
            this.abtnLikeSong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.abtnLikeSong.FlatAppearance.BorderSize = 0;
            this.abtnLikeSong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.abtnLikeSong.Font = new System.Drawing.Font("Arial", 10F);
            this.abtnLikeSong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.abtnLikeSong.Image = global::MusicOnline.Properties.Resources.LikeSongDeActiveIcon;
            this.abtnLikeSong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.abtnLikeSong.LineType = MusicOnline.AButton.LineStyles.None;
            this.abtnLikeSong.Location = new System.Drawing.Point(15, 60);
            this.abtnLikeSong.Name = "abtnLikeSong";
            this.abtnLikeSong.RoundType = MusicOnline.AButton.RoundStyles.Full;
            this.abtnLikeSong.Size = new System.Drawing.Size(320, 40);
            this.abtnLikeSong.TabIndex = 1;
            this.abtnLikeSong.Text = "      Nhạc yêu thích";
            this.abtnLikeSong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.abtnLikeSong.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.abtnLikeSong.ThinknessLine = 0;
            this.abtnLikeSong.UseVisualStyleBackColor = false;
            this.abtnLikeSong.Click += new System.EventHandler(this.abtnLikeSong_Click);
            this.abtnLikeSong.MouseHover += new System.EventHandler(this.abtnHover_MouseHover);
            // 
            // abtnListMusic
            // 
            this.abtnListMusic.BackColor = System.Drawing.Color.Transparent;
            this.abtnListMusic.BackgroundColor = System.Drawing.Color.Transparent;
            this.abtnListMusic.BorderColor = System.Drawing.Color.Red;
            this.abtnListMusic.BorderRadius = 0;
            this.abtnListMusic.BorderSize = 0;
            this.abtnListMusic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.abtnListMusic.FlatAppearance.BorderSize = 0;
            this.abtnListMusic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.abtnListMusic.Font = new System.Drawing.Font("Arial", 10F);
            this.abtnListMusic.ForeColor = System.Drawing.Color.White;
            this.abtnListMusic.Image = global::MusicOnline.Properties.Resources.musicActiveIcon;
            this.abtnListMusic.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.abtnListMusic.LineType = MusicOnline.AButton.LineStyles.None;
            this.abtnListMusic.Location = new System.Drawing.Point(15, 15);
            this.abtnListMusic.Name = "abtnListMusic";
            this.abtnListMusic.RoundType = MusicOnline.AButton.RoundStyles.Full;
            this.abtnListMusic.Size = new System.Drawing.Size(320, 40);
            this.abtnListMusic.TabIndex = 0;
            this.abtnListMusic.Text = "      Danh sách nhạc";
            this.abtnListMusic.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.abtnListMusic.TextColor = System.Drawing.Color.White;
            this.abtnListMusic.ThinknessLine = 0;
            this.abtnListMusic.UseVisualStyleBackColor = false;
            this.abtnListMusic.Click += new System.EventHandler(this.abtnListMusic_Click);
            this.abtnListMusic.MouseHover += new System.EventHandler(this.abtnHover_MouseHover);
            // 
            // pnBottom
            // 
            this.pnBottom.Controls.Add(this.panel11);
            this.pnBottom.Controls.Add(this.pnControlMusic);
            this.pnBottom.Controls.Add(this.panel10);
            this.pnBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBottom.Location = new System.Drawing.Point(0, 750);
            this.pnBottom.Name = "pnBottom";
            this.pnBottom.Size = new System.Drawing.Size(1500, 100);
            this.pnBottom.TabIndex = 6;
            // 
            // panel11
            // 
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(1080, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(420, 100);
            this.panel11.TabIndex = 2;
            // 
            // panel10
            // 
            this.panel10.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(380, 100);
            this.panel10.TabIndex = 0;
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1500, 850);
            this.Controls.Add(this.pnBottom);
            this.Controls.Add(this.pnBody);
            this.Controls.Add(this.pnTop);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmHome_Load);
            this.pnControlMusic.ResumeLayout(false);
            this.pnControlMusic.PerformLayout();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pibPrevious)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibPlayOrPause)).EndInit();
            this.pnTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pibClose)).EndInit();
            this.pnBody.ResumeLayout(false);
            this.aPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnDetailMusic.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.pnType.ResumeLayout(false);
            this.pnType.PerformLayout();
            this.pnGenre.ResumeLayout(false);
            this.pnGenre.PerformLayout();
            this.pnArtistsNames.ResumeLayout(false);
            this.pnArtistsNames.PerformLayout();
            this.pnTitle.ResumeLayout(false);
            this.pnTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibLoveSong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibDownload)).EndInit();
            this.pnThumbnail.ResumeLayout(false);
            this.pnThumbnail.PerformLayout();
            this.pnAddToPlaylist.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pibCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibAccept)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibAddToPlaylist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibStar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibThumbnail)).EndInit();
            this.pn.ResumeLayout(false);
            this.aPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnPlaylist.ResumeLayout(false);
            this.pnPlaylist.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnMenu.ResumeLayout(false);
            this.pnBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timePlay;
        private System.Windows.Forms.Panel pnControlMusic;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.PictureBox pibPrevious;
        private System.Windows.Forms.PictureBox pibNext;
        private System.Windows.Forms.PictureBox pibPlayOrPause;
        private System.Windows.Forms.Label lbStart;
        private APanel slider;
        private System.Windows.Forms.FlowLayoutPanel flpMusics;
        private System.Windows.Forms.Panel pnType;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pnGenre;
        private System.Windows.Forms.Label lbGenre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnArtistsNames;
        private System.Windows.Forms.Label lbArtistsNames;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnTitle;
        private System.Windows.Forms.Label lbTitle;
        private APanel pn;
        private APanel aPanel2;
        private System.Windows.Forms.Panel panel2;
        private ATextboxUC atbNamePlaylist;
        private System.Windows.Forms.Panel pnPlaylist;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private APanel pnMenu;
        private AButton abtnRecently;
        private AButton abtnLikeSong;
        private AButton abtnListMusic;
        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.Panel pnBody;
        private System.Windows.Forms.PictureBox pibClose;
        private System.Windows.Forms.Panel pnBottom;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel10;
        private APanel pnDetailMusic;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private AButton abtnComment;
        private AButton abtnLyrics;
        private System.Windows.Forms.Panel pnThumbnail;
        private System.Windows.Forms.PictureBox pibThumbnail;
        private System.Windows.Forms.PictureBox pibDownload;
        private System.Windows.Forms.Label lbEnd;
        private APanel aPanel1;
        private System.Windows.Forms.Panel panel1;
        private ATextboxUC atbSearch;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pibLoveSong;
        private System.Windows.Forms.PictureBox pibStar;
        private System.Windows.Forms.Label lbRating;
        private System.Windows.Forms.Label lbAddPlaylist;
        private System.Windows.Forms.Panel pnListPlaylist;
        private System.Windows.Forms.ComboBox cbAddToPlaylist;
        private System.Windows.Forms.Panel pnAddToPlaylist;
        private System.Windows.Forms.PictureBox pibAccept;
        private System.Windows.Forms.PictureBox pibCancel;
        private System.Windows.Forms.PictureBox pibAddToPlaylist;
    }
}

