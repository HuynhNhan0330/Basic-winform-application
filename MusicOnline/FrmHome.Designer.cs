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
            this.aPanel2 = new MusicOnline.APanel();
            this.pnBody2 = new MusicOnline.APanel();
            this.flpMusics = new System.Windows.Forms.FlowLayoutPanel();
            this.aPanel1 = new MusicOnline.APanel();
            this.pnBody1 = new MusicOnline.APanel();
            this.pnBody1_Top = new MusicOnline.APanel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnTop = new MusicOnline.APanel();
            this.pibClose = new System.Windows.Forms.PictureBox();
            this.pnBottom = new MusicOnline.APanel();
            this.slider = new MusicOnline.APanel();
            this.pnBody.SuspendLayout();
            this.pnBody2.SuspendLayout();
            this.pnBody1.SuspendLayout();
            this.pnBody1_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibClose)).BeginInit();
            this.pnBottom.SuspendLayout();
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
            this.pnBody.Controls.Add(this.aPanel2);
            this.pnBody.Controls.Add(this.pnBody2);
            this.pnBody.Controls.Add(this.pnBody1);
            this.pnBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBody.ForeColor = System.Drawing.Color.White;
            this.pnBody.Location = new System.Drawing.Point(0, 30);
            this.pnBody.Name = "pnBody";
            this.pnBody.RoundType = MusicOnline.APanel.RoundStyles.Full;
            this.pnBody.Size = new System.Drawing.Size(1500, 720);
            this.pnBody.TabIndex = 3;
            this.pnBody.TextColor = System.Drawing.Color.White;
            // 
            // aPanel2
            // 
            this.aPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.aPanel2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.aPanel2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.aPanel2.BorderRadius = 10;
            this.aPanel2.BorderSize = 0;
            this.aPanel2.ForeColor = System.Drawing.Color.White;
            this.aPanel2.Location = new System.Drawing.Point(1150, 25);
            this.aPanel2.Name = "aPanel2";
            this.aPanel2.RoundType = MusicOnline.APanel.RoundStyles.Full;
            this.aPanel2.Size = new System.Drawing.Size(300, 640);
            this.aPanel2.TabIndex = 3;
            this.aPanel2.TextColor = System.Drawing.Color.White;
            // 
            // pnBody2
            // 
            this.pnBody2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.pnBody2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.pnBody2.BorderColor = System.Drawing.Color.Black;
            this.pnBody2.BorderRadius = 10;
            this.pnBody2.BorderSize = 0;
            this.pnBody2.Controls.Add(this.flpMusics);
            this.pnBody2.Controls.Add(this.aPanel1);
            this.pnBody2.ForeColor = System.Drawing.Color.White;
            this.pnBody2.Location = new System.Drawing.Point(400, 25);
            this.pnBody2.Name = "pnBody2";
            this.pnBody2.RoundType = MusicOnline.APanel.RoundStyles.Full;
            this.pnBody2.Size = new System.Drawing.Size(700, 640);
            this.pnBody2.TabIndex = 2;
            this.pnBody2.TextColor = System.Drawing.Color.White;
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
            // pnBody1
            // 
            this.pnBody1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.pnBody1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.pnBody1.BorderColor = System.Drawing.Color.Black;
            this.pnBody1.BorderRadius = 10;
            this.pnBody1.BorderSize = 2;
            this.pnBody1.Controls.Add(this.pnBody1_Top);
            this.pnBody1.ForeColor = System.Drawing.Color.White;
            this.pnBody1.Location = new System.Drawing.Point(50, 25);
            this.pnBody1.Name = "pnBody1";
            this.pnBody1.RoundType = MusicOnline.APanel.RoundStyles.Full;
            this.pnBody1.Size = new System.Drawing.Size(300, 640);
            this.pnBody1.TabIndex = 0;
            this.pnBody1.TextColor = System.Drawing.Color.White;
            // 
            // pnBody1_Top
            // 
            this.pnBody1_Top.BackColor = System.Drawing.Color.Transparent;
            this.pnBody1_Top.BackgroundColor = System.Drawing.Color.Transparent;
            this.pnBody1_Top.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.pnBody1_Top.BorderRadius = 0;
            this.pnBody1_Top.BorderSize = 0;
            this.pnBody1_Top.Controls.Add(this.label2);
            this.pnBody1_Top.Controls.Add(this.pictureBox1);
            this.pnBody1_Top.Controls.Add(this.label1);
            this.pnBody1_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnBody1_Top.ForeColor = System.Drawing.Color.White;
            this.pnBody1_Top.Location = new System.Drawing.Point(0, 0);
            this.pnBody1_Top.Name = "pnBody1_Top";
            this.pnBody1_Top.RoundType = MusicOnline.APanel.RoundStyles.Full;
            this.pnBody1_Top.Size = new System.Drawing.Size(300, 57);
            this.pnBody1_Top.TabIndex = 0;
            this.pnBody1_Top.TextColor = System.Drawing.Color.White;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(257, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "+";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::MusicOnline.Properties.Resources.libraryIcon;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(25, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách phát";
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
            // pnBottom
            // 
            this.pnBottom.BackColor = System.Drawing.Color.Transparent;
            this.pnBottom.BackgroundColor = System.Drawing.Color.Transparent;
            this.pnBottom.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.pnBottom.BorderRadius = 0;
            this.pnBottom.BorderSize = 0;
            this.pnBottom.Controls.Add(this.slider);
            this.pnBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnBottom.ForeColor = System.Drawing.Color.White;
            this.pnBottom.Location = new System.Drawing.Point(0, 750);
            this.pnBottom.Name = "pnBottom";
            this.pnBottom.RoundType = MusicOnline.APanel.RoundStyles.Full;
            this.pnBottom.Size = new System.Drawing.Size(1500, 100);
            this.pnBottom.TabIndex = 1;
            this.pnBottom.TextColor = System.Drawing.Color.White;
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
            this.slider.Location = new System.Drawing.Point(300, 25);
            this.slider.Name = "slider";
            this.slider.RoundType = MusicOnline.APanel.RoundStyles.Full;
            this.slider.Size = new System.Drawing.Size(1000, 40);
            this.slider.TabIndex = 0;
            this.slider.TextColor = System.Drawing.Color.White;
            this.slider.Paint += new System.Windows.Forms.PaintEventHandler(this.slider_Paint);
            this.slider.MouseDown += new System.Windows.Forms.MouseEventHandler(this.slider_MouseDown);
            this.slider.MouseMove += new System.Windows.Forms.MouseEventHandler(this.slider_MouseMove);
            this.slider.MouseUp += new System.Windows.Forms.MouseEventHandler(this.slider_MouseUp);
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
            this.pnBody2.ResumeLayout(false);
            this.pnBody1.ResumeLayout(false);
            this.pnBody1_Top.ResumeLayout(false);
            this.pnBody1_Top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pibClose)).EndInit();
            this.pnBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pibClose;
        private APanel pnBottom;
        private APanel slider;
        private System.Windows.Forms.Timer timePlay;
        private APanel pnTop;
        private APanel pnBody;
        private APanel pnBody1;
        private APanel pnBody1_Top;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private APanel pnBody2;
        private APanel aPanel1;
        private System.Windows.Forms.FlowLayoutPanel flpMusics;
        private APanel aPanel2;
    }
}

