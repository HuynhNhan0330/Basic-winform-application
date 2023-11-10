namespace MusicOnline
{
    partial class FrmpEditPlaylist
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
            this.pibClose = new System.Windows.Forms.PictureBox();
            this.aPanel1 = new MusicOnline.APanel();
            this.abtnDeleteAll = new MusicOnline.AButton();
            this.pnBody = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pibCancel = new System.Windows.Forms.PictureBox();
            this.pibAccept = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.atbNamePlaylist = new MusicOnline.ATextboxUC();
            ((System.ComponentModel.ISupportInitialize)(this.pibClose)).BeginInit();
            this.aPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibAccept)).BeginInit();
            this.SuspendLayout();
            // 
            // pibClose
            // 
            this.pibClose.BackgroundImage = global::MusicOnline.Properties.Resources.CloseIcon2;
            this.pibClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pibClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pibClose.Location = new System.Drawing.Point(670, 10);
            this.pibClose.Name = "pibClose";
            this.pibClose.Size = new System.Drawing.Size(20, 20);
            this.pibClose.TabIndex = 1;
            this.pibClose.TabStop = false;
            this.pibClose.Click += new System.EventHandler(this.pibClose_Click);
            // 
            // aPanel1
            // 
            this.aPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.aPanel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.aPanel1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.aPanel1.BorderRadius = 20;
            this.aPanel1.BorderSize = 0;
            this.aPanel1.Controls.Add(this.abtnDeleteAll);
            this.aPanel1.Controls.Add(this.pnBody);
            this.aPanel1.Controls.Add(this.panel1);
            this.aPanel1.ForeColor = System.Drawing.Color.White;
            this.aPanel1.Location = new System.Drawing.Point(50, 50);
            this.aPanel1.Name = "aPanel1";
            this.aPanel1.RoundType = MusicOnline.APanel.RoundStyles.Full;
            this.aPanel1.Size = new System.Drawing.Size(600, 590);
            this.aPanel1.TabIndex = 2;
            this.aPanel1.TextColor = System.Drawing.Color.White;
            // 
            // abtnDeleteAll
            // 
            this.abtnDeleteAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(155)))), ((int)(((byte)(70)))));
            this.abtnDeleteAll.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(155)))), ((int)(((byte)(70)))));
            this.abtnDeleteAll.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.abtnDeleteAll.BorderRadius = 15;
            this.abtnDeleteAll.BorderSize = 0;
            this.abtnDeleteAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.abtnDeleteAll.FlatAppearance.BorderSize = 0;
            this.abtnDeleteAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.abtnDeleteAll.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abtnDeleteAll.ForeColor = System.Drawing.Color.White;
            this.abtnDeleteAll.LineType = MusicOnline.AButton.LineStyles.None;
            this.abtnDeleteAll.Location = new System.Drawing.Point(440, 95);
            this.abtnDeleteAll.Name = "abtnDeleteAll";
            this.abtnDeleteAll.RoundType = MusicOnline.AButton.RoundStyles.Full;
            this.abtnDeleteAll.Size = new System.Drawing.Size(150, 40);
            this.abtnDeleteAll.TabIndex = 2;
            this.abtnDeleteAll.Text = "Xoá tất cả";
            this.abtnDeleteAll.TextColor = System.Drawing.Color.White;
            this.abtnDeleteAll.ThinknessLine = 0;
            this.abtnDeleteAll.UseVisualStyleBackColor = false;
            this.abtnDeleteAll.Click += new System.EventHandler(this.abtnDeleteAll_Click);
            // 
            // pnBody
            // 
            this.pnBody.AutoScroll = true;
            this.pnBody.Location = new System.Drawing.Point(0, 150);
            this.pnBody.Name = "pnBody";
            this.pnBody.Size = new System.Drawing.Size(590, 400);
            this.pnBody.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pibCancel);
            this.panel1.Controls.Add(this.pibAccept);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.atbNamePlaylist);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 80);
            this.panel1.TabIndex = 0;
            // 
            // pibCancel
            // 
            this.pibCancel.BackgroundImage = global::MusicOnline.Properties.Resources.cancel;
            this.pibCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pibCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pibCancel.Location = new System.Drawing.Point(550, 49);
            this.pibCancel.Name = "pibCancel";
            this.pibCancel.Size = new System.Drawing.Size(16, 16);
            this.pibCancel.TabIndex = 3;
            this.pibCancel.TabStop = false;
            this.pibCancel.Click += new System.EventHandler(this.pibCancel_Click);
            // 
            // pibAccept
            // 
            this.pibAccept.BackgroundImage = global::MusicOnline.Properties.Resources.checkmarks;
            this.pibAccept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pibAccept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pibAccept.Location = new System.Drawing.Point(513, 45);
            this.pibAccept.Name = "pibAccept";
            this.pibAccept.Size = new System.Drawing.Size(25, 25);
            this.pibAccept.TabIndex = 2;
            this.pibAccept.TabStop = false;
            this.pibAccept.Click += new System.EventHandler(this.pibAccept_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên danh sách";
            // 
            // atbNamePlaylist
            // 
            this.atbNamePlaylist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.atbNamePlaylist.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.atbNamePlaylist.BorderFocusColor = System.Drawing.Color.White;
            this.atbNamePlaylist.BorderRadius = 5;
            this.atbNamePlaylist.BorderSize = 2;
            this.atbNamePlaylist.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.atbNamePlaylist.ForeColor = System.Drawing.Color.White;
            this.atbNamePlaylist.Location = new System.Drawing.Point(30, 40);
            this.atbNamePlaylist.Margin = new System.Windows.Forms.Padding(4);
            this.atbNamePlaylist.Multiline = false;
            this.atbNamePlaylist.Name = "atbNamePlaylist";
            this.atbNamePlaylist.Padding = new System.Windows.Forms.Padding(7);
            this.atbNamePlaylist.PasswordChar = false;
            this.atbNamePlaylist.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.atbNamePlaylist.PlaceholderText = "";
            this.atbNamePlaylist.RoundType = MusicOnline.ATextboxUC.RoundStyles.Full;
            this.atbNamePlaylist.Size = new System.Drawing.Size(465, 35);
            this.atbNamePlaylist.TabIndex = 0;
            this.atbNamePlaylist.Texts = "";
            this.atbNamePlaylist.UnderlinedStyle = false;
            this.atbNamePlaylist._TextChanged += new System.EventHandler(this.atbNamePlaylist__TextChanged);
            // 
            // FrmpEditPlaylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(700, 690);
            this.Controls.Add(this.aPanel1);
            this.Controls.Add(this.pibClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmpEditPlaylist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLyrics";
            this.Load += new System.EventHandler(this.FrmComment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pibClose)).EndInit();
            this.aPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibAccept)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pibClose;
        private APanel aPanel1;
        private System.Windows.Forms.Panel panel1;
        private ATextboxUC atbNamePlaylist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pibAccept;
        private System.Windows.Forms.PictureBox pibCancel;
        private System.Windows.Forms.Panel pnBody;
        private AButton abtnDeleteAll;
    }
}