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
            this.pnBody = new MusicOnline.APanel();
            this.pn = new MusicOnline.APanel();
            this.aPanel2 = new MusicOnline.APanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.aTextboxUC1 = new MusicOnline.ATextboxUC();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnMenu = new MusicOnline.APanel();
            this.pnDetailMusic = new MusicOnline.APanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pnOperator = new System.Windows.Forms.Panel();
            this.aButton3 = new MusicOnline.AButton();
            this.aButton2 = new MusicOnline.AButton();
            this.aButton1 = new MusicOnline.AButton();
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
            this.lbTitle = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pnListMusic = new MusicOnline.APanel();
            this.flpMusics = new System.Windows.Forms.FlowLayoutPanel();
            this.aPanel1 = new MusicOnline.APanel();
            this.pnTop = new MusicOnline.APanel();
            this.pnBottom = new MusicOnline.APanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.slider = new MusicOnline.APanel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.abtnRecently = new MusicOnline.AButton();
            this.abtnLikeSong = new MusicOnline.AButton();
            this.abtnListMusic = new MusicOnline.AButton();
            this.pibThumbnail = new System.Windows.Forms.PictureBox();
            this.pibClose = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pnBody.SuspendLayout();
            this.pn.SuspendLayout();
            this.aPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnMenu.SuspendLayout();
            this.pnDetailMusic.SuspendLayout();
            this.panel5.SuspendLayout();
            this.pnOperator.SuspendLayout();
            this.pnType.SuspendLayout();
            this.pnGenre.SuspendLayout();
            this.pnArtistsNames.SuspendLayout();
            this.pnTitle.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pnListMusic.SuspendLayout();
            this.pnTop.SuspendLayout();
            this.pnBottom.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibThumbnail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // timePlay
            // 
            this.timePlay.Enabled = true;
            this.timePlay.Tick += new System.EventHandler(this.timePlay_Tick);
            // 
            // pnBody
            // 
            this.pnBody.BackColor = System.Drawing.Color.Transparent;
            this.pnBody.BackgroundColor = System.Drawing.Color.Transparent;
            this.pnBody.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.pnBody.BorderRadius = 0;
            this.pnBody.BorderSize = 0;
            this.pnBody.Controls.Add(this.pn);
            this.pnBody.Controls.Add(this.pnDetailMusic);
            this.pnBody.Controls.Add(this.pnListMusic);
            this.pnBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBody.ForeColor = System.Drawing.Color.White;
            this.pnBody.Location = new System.Drawing.Point(0, 30);
            this.pnBody.Name = "pnBody";
            this.pnBody.RoundType = MusicOnline.APanel.RoundStyles.Full;
            this.pnBody.Size = new System.Drawing.Size(1500, 700);
            this.pnBody.TabIndex = 3;
            this.pnBody.TextColor = System.Drawing.Color.White;
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
            this.pn.Location = new System.Drawing.Point(26, 25);
            this.pn.Name = "pn";
            this.pn.RoundType = MusicOnline.APanel.RoundStyles.Full;
            this.pn.Size = new System.Drawing.Size(250, 640);
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
            this.aPanel2.Controls.Add(this.panel3);
            this.aPanel2.Controls.Add(this.panel2);
            this.aPanel2.Controls.Add(this.panel1);
            this.aPanel2.ForeColor = System.Drawing.Color.White;
            this.aPanel2.Location = new System.Drawing.Point(0, 246);
            this.aPanel2.Name = "aPanel2";
            this.aPanel2.RoundType = MusicOnline.APanel.RoundStyles.Full;
            this.aPanel2.Size = new System.Drawing.Size(250, 354);
            this.aPanel2.TabIndex = 6;
            this.aPanel2.TextColor = System.Drawing.Color.White;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 97);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 257);
            this.panel3.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.aTextboxUC1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 50);
            this.panel2.TabIndex = 3;
            // 
            // aTextboxUC1
            // 
            this.aTextboxUC1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.aTextboxUC1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.aTextboxUC1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.aTextboxUC1.BorderRadius = 0;
            this.aTextboxUC1.BorderSize = 2;
            this.aTextboxUC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.aTextboxUC1.ForeColor = System.Drawing.Color.White;
            this.aTextboxUC1.Location = new System.Drawing.Point(15, 15);
            this.aTextboxUC1.Margin = new System.Windows.Forms.Padding(4);
            this.aTextboxUC1.Multiline = false;
            this.aTextboxUC1.Name = "aTextboxUC1";
            this.aTextboxUC1.Padding = new System.Windows.Forms.Padding(7);
            this.aTextboxUC1.PasswordChar = false;
            this.aTextboxUC1.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.aTextboxUC1.PlaceholderText = "Tên danh sách";
            this.aTextboxUC1.RoundType = MusicOnline.ATextboxUC.RoundStyles.Full;
            this.aTextboxUC1.Size = new System.Drawing.Size(194, 35);
            this.aTextboxUC1.TabIndex = 2;
            this.aTextboxUC1.Texts = "";
            this.aTextboxUC1.UnderlinedStyle = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 47);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 15);
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
            this.pnMenu.Size = new System.Drawing.Size(250, 160);
            this.pnMenu.TabIndex = 5;
            this.pnMenu.TextColor = System.Drawing.Color.White;
            // 
            // pnDetailMusic
            // 
            this.pnDetailMusic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.pnDetailMusic.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.pnDetailMusic.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.pnDetailMusic.BorderRadius = 10;
            this.pnDetailMusic.BorderSize = 0;
            this.pnDetailMusic.Controls.Add(this.panel5);
            this.pnDetailMusic.Controls.Add(this.panel4);
            this.pnDetailMusic.ForeColor = System.Drawing.Color.White;
            this.pnDetailMusic.Location = new System.Drawing.Point(1110, 25);
            this.pnDetailMusic.Name = "pnDetailMusic";
            this.pnDetailMusic.RoundType = MusicOnline.APanel.RoundStyles.Full;
            this.pnDetailMusic.Size = new System.Drawing.Size(380, 666);
            this.pnDetailMusic.TabIndex = 3;
            this.pnDetailMusic.TextColor = System.Drawing.Color.White;
            // 
            // panel5
            // 
            this.panel5.AutoScroll = true;
            this.panel5.Controls.Add(this.pnOperator);
            this.panel5.Controls.Add(this.pnType);
            this.panel5.Controls.Add(this.pnGenre);
            this.panel5.Controls.Add(this.pnArtistsNames);
            this.panel5.Controls.Add(this.pnTitle);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 365);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(380, 301);
            this.panel5.TabIndex = 4;
            // 
            // pnOperator
            // 
            this.pnOperator.Controls.Add(this.aButton3);
            this.pnOperator.Controls.Add(this.aButton2);
            this.pnOperator.Controls.Add(this.aButton1);
            this.pnOperator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnOperator.Location = new System.Drawing.Point(0, 241);
            this.pnOperator.Name = "pnOperator";
            this.pnOperator.Size = new System.Drawing.Size(380, 60);
            this.pnOperator.TabIndex = 8;
            // 
            // aButton3
            // 
            this.aButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(155)))), ((int)(((byte)(70)))));
            this.aButton3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(155)))), ((int)(((byte)(70)))));
            this.aButton3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.aButton3.BorderRadius = 15;
            this.aButton3.BorderSize = 0;
            this.aButton3.FlatAppearance.BorderSize = 0;
            this.aButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aButton3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aButton3.ForeColor = System.Drawing.Color.White;
            this.aButton3.LineType = MusicOnline.AButton.LineStyles.None;
            this.aButton3.Location = new System.Drawing.Point(255, 10);
            this.aButton3.Name = "aButton3";
            this.aButton3.RoundType = MusicOnline.AButton.RoundStyles.Full;
            this.aButton3.Size = new System.Drawing.Size(100, 40);
            this.aButton3.TabIndex = 2;
            this.aButton3.Text = "Tải xuống";
            this.aButton3.TextColor = System.Drawing.Color.White;
            this.aButton3.ThinknessLine = 0;
            this.aButton3.UseVisualStyleBackColor = false;
            // 
            // aButton2
            // 
            this.aButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(155)))), ((int)(((byte)(70)))));
            this.aButton2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(155)))), ((int)(((byte)(70)))));
            this.aButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.aButton2.BorderRadius = 15;
            this.aButton2.BorderSize = 0;
            this.aButton2.FlatAppearance.BorderSize = 0;
            this.aButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aButton2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aButton2.ForeColor = System.Drawing.Color.White;
            this.aButton2.LineType = MusicOnline.AButton.LineStyles.None;
            this.aButton2.Location = new System.Drawing.Point(125, 10);
            this.aButton2.Name = "aButton2";
            this.aButton2.RoundType = MusicOnline.AButton.RoundStyles.Full;
            this.aButton2.Size = new System.Drawing.Size(100, 40);
            this.aButton2.TabIndex = 1;
            this.aButton2.Text = "Bình Luận";
            this.aButton2.TextColor = System.Drawing.Color.White;
            this.aButton2.ThinknessLine = 0;
            this.aButton2.UseVisualStyleBackColor = false;
            // 
            // aButton1
            // 
            this.aButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(155)))), ((int)(((byte)(70)))));
            this.aButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(155)))), ((int)(((byte)(70)))));
            this.aButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.aButton1.BorderRadius = 15;
            this.aButton1.BorderSize = 0;
            this.aButton1.FlatAppearance.BorderSize = 0;
            this.aButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aButton1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aButton1.ForeColor = System.Drawing.Color.White;
            this.aButton1.LineType = MusicOnline.AButton.LineStyles.None;
            this.aButton1.Location = new System.Drawing.Point(5, 10);
            this.aButton1.Name = "aButton1";
            this.aButton1.RoundType = MusicOnline.AButton.RoundStyles.Full;
            this.aButton1.Size = new System.Drawing.Size(110, 40);
            this.aButton1.TabIndex = 0;
            this.aButton1.Text = "Lời bài hát";
            this.aButton1.TextColor = System.Drawing.Color.White;
            this.aButton1.ThinknessLine = 0;
            this.aButton1.UseVisualStyleBackColor = false;
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
            this.lbType.MaximumSize = new System.Drawing.Size(255, 0);
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
            this.lbGenre.MaximumSize = new System.Drawing.Size(255, 0);
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
            this.lbArtistsNames.MaximumSize = new System.Drawing.Size(255, 0);
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
            this.pnTitle.Controls.Add(this.lbTitle);
            this.pnTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTitle.Location = new System.Drawing.Point(0, 0);
            this.pnTitle.Name = "pnTitle";
            this.pnTitle.Size = new System.Drawing.Size(380, 50);
            this.pnTitle.TabIndex = 5;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.White;
            this.lbTitle.Location = new System.Drawing.Point(15, 15);
            this.lbTitle.MaximumSize = new System.Drawing.Size(350, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(217, 25);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "Chúng ta của hiện tại";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pibThumbnail);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(380, 365);
            this.panel4.TabIndex = 0;
            // 
            // pnListMusic
            // 
            this.pnListMusic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.pnListMusic.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.pnListMusic.BorderColor = System.Drawing.Color.Black;
            this.pnListMusic.BorderRadius = 10;
            this.pnListMusic.BorderSize = 0;
            this.pnListMusic.Controls.Add(this.flpMusics);
            this.pnListMusic.Controls.Add(this.aPanel1);
            this.pnListMusic.ForeColor = System.Drawing.Color.White;
            this.pnListMusic.Location = new System.Drawing.Point(400, 25);
            this.pnListMusic.Name = "pnListMusic";
            this.pnListMusic.RoundType = MusicOnline.APanel.RoundStyles.Full;
            this.pnListMusic.Size = new System.Drawing.Size(700, 640);
            this.pnListMusic.TabIndex = 2;
            this.pnListMusic.TextColor = System.Drawing.Color.White;
            // 
            // flpMusics
            // 
            this.flpMusics.AutoScroll = true;
            this.flpMusics.Location = new System.Drawing.Point(40, 100);
            this.flpMusics.Name = "flpMusics";
            this.flpMusics.Size = new System.Drawing.Size(640, 500);
            this.flpMusics.TabIndex = 1;
            // 
            // aPanel1
            // 
            this.aPanel1.BackColor = System.Drawing.Color.Transparent;
            this.aPanel1.BackgroundColor = System.Drawing.Color.Transparent;
            this.aPanel1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.aPanel1.BorderRadius = 0;
            this.aPanel1.BorderSize = 0;
            this.aPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.aPanel1.ForeColor = System.Drawing.Color.White;
            this.aPanel1.Location = new System.Drawing.Point(0, 0);
            this.aPanel1.Name = "aPanel1";
            this.aPanel1.RoundType = MusicOnline.APanel.RoundStyles.Full;
            this.aPanel1.Size = new System.Drawing.Size(700, 70);
            this.aPanel1.TabIndex = 0;
            this.aPanel1.TextColor = System.Drawing.Color.White;
            // 
            // pnTop
            // 
            this.pnTop.BackColor = System.Drawing.Color.Black;
            this.pnTop.BackgroundColor = System.Drawing.Color.Black;
            this.pnTop.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.pnTop.BorderRadius = 0;
            this.pnTop.BorderSize = 0;
            this.pnTop.Controls.Add(this.pibClose);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.ForeColor = System.Drawing.Color.White;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.RoundType = MusicOnline.APanel.RoundStyles.Full;
            this.pnTop.Size = new System.Drawing.Size(1500, 30);
            this.pnTop.TabIndex = 2;
            this.pnTop.TextColor = System.Drawing.Color.White;
            // 
            // pnBottom
            // 
            this.pnBottom.BackColor = System.Drawing.Color.Transparent;
            this.pnBottom.BackgroundColor = System.Drawing.Color.Transparent;
            this.pnBottom.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.pnBottom.BorderRadius = 0;
            this.pnBottom.BorderSize = 0;
            this.pnBottom.Controls.Add(this.panel6);
            this.pnBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnBottom.ForeColor = System.Drawing.Color.White;
            this.pnBottom.Location = new System.Drawing.Point(0, 730);
            this.pnBottom.Name = "pnBottom";
            this.pnBottom.RoundType = MusicOnline.APanel.RoundStyles.Full;
            this.pnBottom.Size = new System.Drawing.Size(1500, 120);
            this.pnBottom.TabIndex = 1;
            this.pnBottom.TextColor = System.Drawing.Color.White;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.slider);
            this.panel6.Location = new System.Drawing.Point(400, 6);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(700, 114);
            this.panel6.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.label2.Location = new System.Drawing.Point(0, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "00:00";
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
            this.slider.Location = new System.Drawing.Point(48, 38);
            this.slider.Name = "slider";
            this.slider.RoundType = MusicOnline.APanel.RoundStyles.Full;
            this.slider.Size = new System.Drawing.Size(557, 40);
            this.slider.TabIndex = 0;
            this.slider.TextColor = System.Drawing.Color.White;
            this.slider.Paint += new System.Windows.Forms.PaintEventHandler(this.slider_Paint);
            this.slider.MouseDown += new System.Windows.Forms.MouseEventHandler(this.slider_MouseDown);
            this.slider.MouseMove += new System.Windows.Forms.MouseEventHandler(this.slider_MouseMove);
            this.slider.MouseUp += new System.Windows.Forms.MouseEventHandler(this.slider_MouseUp);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.pictureBox4);
            this.panel7.Controls.Add(this.pictureBox3);
            this.panel7.Controls.Add(this.pictureBox2);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(700, 40);
            this.panel7.TabIndex = 2;
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
            // abtnRecently
            // 
            this.abtnRecently.BackColor = System.Drawing.Color.Transparent;
            this.abtnRecently.BackgroundColor = System.Drawing.Color.Transparent;
            this.abtnRecently.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.abtnRecently.BorderRadius = 15;
            this.abtnRecently.BorderSize = 0;
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
            this.abtnRecently.Size = new System.Drawing.Size(216, 40);
            this.abtnRecently.TabIndex = 2;
            this.abtnRecently.Text = "Nhạc gần đây";
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
            this.abtnLikeSong.BorderRadius = 15;
            this.abtnLikeSong.BorderSize = 0;
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
            this.abtnLikeSong.Size = new System.Drawing.Size(225, 40);
            this.abtnLikeSong.TabIndex = 1;
            this.abtnLikeSong.Text = "Nhạc yêu thích";
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
            this.abtnListMusic.BorderRadius = 15;
            this.abtnListMusic.BorderSize = 0;
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
            this.abtnListMusic.Size = new System.Drawing.Size(234, 40);
            this.abtnListMusic.TabIndex = 0;
            this.abtnListMusic.Text = "Danh sách nhạc";
            this.abtnListMusic.TextColor = System.Drawing.Color.White;
            this.abtnListMusic.ThinknessLine = 0;
            this.abtnListMusic.UseVisualStyleBackColor = false;
            this.abtnListMusic.Click += new System.EventHandler(this.abtnListMusic_Click);
            this.abtnListMusic.MouseHover += new System.EventHandler(this.abtnHover_MouseHover);
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
            // pibClose
            // 
            this.pibClose.BackColor = System.Drawing.Color.Transparent;
            this.pibClose.BackgroundImage = global::MusicOnline.Properties.Resources.CloseIcon2;
            this.pibClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pibClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pibClose.Location = new System.Drawing.Point(1464, 10);
            this.pibClose.Name = "pibClose";
            this.pibClose.Size = new System.Drawing.Size(20, 20);
            this.pibClose.TabIndex = 0;
            this.pibClose.TabStop = false;
            this.pibClose.Click += new System.EventHandler(this.pibClose_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::MusicOnline.Properties.Resources.play_and_pause_button;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(390, 8);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 24);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::MusicOnline.Properties.Resources.play;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(330, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::MusicOnline.Properties.Resources.previous;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(286, 8);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(24, 24);
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1500, 850);
            this.Controls.Add(this.pnBody);
            this.Controls.Add(this.pnTop);
            this.Controls.Add(this.pnBottom);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmHome_Load);
            this.pnBody.ResumeLayout(false);
            this.pn.ResumeLayout(false);
            this.aPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnMenu.ResumeLayout(false);
            this.pnDetailMusic.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.pnOperator.ResumeLayout(false);
            this.pnType.ResumeLayout(false);
            this.pnType.PerformLayout();
            this.pnGenre.ResumeLayout(false);
            this.pnGenre.PerformLayout();
            this.pnArtistsNames.ResumeLayout(false);
            this.pnArtistsNames.PerformLayout();
            this.pnTitle.ResumeLayout(false);
            this.pnTitle.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.pnListMusic.ResumeLayout(false);
            this.pnTop.ResumeLayout(false);
            this.pnBottom.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibThumbnail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pibClose;
        private APanel pnBottom;
        private APanel slider;
        private System.Windows.Forms.Timer timePlay;
        private APanel pnTop;
        private APanel pnBody;
        private APanel pnListMusic;
        private APanel aPanel1;
        private System.Windows.Forms.FlowLayoutPanel flpMusics;
        private APanel pnDetailMusic;
        private System.Windows.Forms.PictureBox pibThumbnail;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Panel pnTitle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel pnArtistsNames;
        private System.Windows.Forms.Label lbArtistsNames;
        private System.Windows.Forms.Panel pnOperator;
        private System.Windows.Forms.Panel pnType;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pnGenre;
        private System.Windows.Forms.Label lbGenre;
        private System.Windows.Forms.Label label4;
        private AButton aButton1;
        private AButton aButton3;
        private AButton aButton2;
        private APanel pn;
        private APanel aPanel2;
        private APanel pnMenu;
        private AButton abtnListMusic;
        private AButton abtnLikeSong;
        private AButton abtnRecently;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private ATextboxUC aTextboxUC1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}

