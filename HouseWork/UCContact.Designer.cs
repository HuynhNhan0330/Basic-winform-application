namespace HouseWork
{
    partial class UCContact
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCContact));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logoTikTok = new HouseWork.LogoContactUC();
            this.logoIns = new HouseWork.LogoContactUC();
            this.logoYTB = new HouseWork.LogoContactUC();
            this.label1 = new System.Windows.Forms.Label();
            this.ucChatBox1 = new HouseWork.UCChatBox();
            this.logoPhone = new HouseWork.LogoContactUC();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::HouseWork.Properties.Resources.botImg;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(100, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 500);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.logoPhone);
            this.panel1.Controls.Add(this.logoTikTok);
            this.panel1.Controls.Add(this.logoIns);
            this.panel1.Controls.Add(this.logoYTB);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1094, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 500);
            this.panel1.TabIndex = 2;
            // 
            // logoTikTok
            // 
            this.logoTikTok.img = ((System.Drawing.Image)(resources.GetObject("logoTikTok.img")));
            this.logoTikTok.Location = new System.Drawing.Point(12, 315);
            this.logoTikTok.Name = "logoTikTok";
            this.logoTikTok.Size = new System.Drawing.Size(282, 50);
            this.logoTikTok.TabIndex = 11;
            this.logoTikTok.text = "fb.com/huynhan03";
            // 
            // logoIns
            // 
            this.logoIns.img = ((System.Drawing.Image)(resources.GetObject("logoIns.img")));
            this.logoIns.Location = new System.Drawing.Point(12, 240);
            this.logoIns.Name = "logoIns";
            this.logoIns.Size = new System.Drawing.Size(282, 50);
            this.logoIns.TabIndex = 10;
            this.logoIns.text = "fb.com/huynhan03";
            // 
            // logoYTB
            // 
            this.logoYTB.img = ((System.Drawing.Image)(resources.GetObject("logoYTB.img")));
            this.logoYTB.Location = new System.Drawing.Point(12, 165);
            this.logoYTB.Name = "logoYTB";
            this.logoYTB.Size = new System.Drawing.Size(282, 50);
            this.logoYTB.TabIndex = 8;
            this.logoYTB.text = "fb.com/huynhan03";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thông tin liên hệ";
            // 
            // ucChatBox1
            // 
            this.ucChatBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(238)))), ((int)(((byte)(253)))));
            this.ucChatBox1.Location = new System.Drawing.Point(600, 50);
            this.ucChatBox1.Name = "ucChatBox1";
            this.ucChatBox1.Size = new System.Drawing.Size(420, 500);
            this.ucChatBox1.TabIndex = 1;
            // 
            // logoPhone
            // 
            this.logoPhone.img = ((System.Drawing.Image)(resources.GetObject("logoPhone.img")));
            this.logoPhone.Location = new System.Drawing.Point(12, 90);
            this.logoPhone.Name = "logoPhone";
            this.logoPhone.Size = new System.Drawing.Size(282, 50);
            this.logoPhone.TabIndex = 12;
            this.logoPhone.text = "fb.com/huynhan03";
            // 
            // UCContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(238)))), ((int)(((byte)(253)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ucChatBox1);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(31)))));
            this.Name = "UCContact";
            this.Size = new System.Drawing.Size(1500, 600);
            this.Load += new System.EventHandler(this.UCContact_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private UCChatBox ucChatBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private LogoContactUC logoYTB;
        private LogoContactUC logoTikTok;
        private LogoContactUC logoIns;
        private LogoContactUC logoPhone;
    }
}
