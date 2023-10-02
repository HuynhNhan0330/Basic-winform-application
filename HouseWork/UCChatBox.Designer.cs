namespace HouseWork
{
    partial class UCChatBox
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pibSend = new System.Windows.Forms.PictureBox();
            this.txbType = new System.Windows.Forms.TextBox();
            this.pnMain = new System.Windows.Forms.Panel();
            this.pnMainChat = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibSend)).BeginInit();
            this.pnMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(161)))), ((int)(((byte)(216)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 70);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(110, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bot hỗ trợ khách hàng";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::HouseWork.Properties.Resources.ChatBotIcon;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(20, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pibSend);
            this.panel3.Controls.Add(this.txbType);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 401);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(420, 49);
            this.panel3.TabIndex = 2;
            // 
            // pibSend
            // 
            this.pibSend.BackgroundImage = global::HouseWork.Properties.Resources.SendIcon1;
            this.pibSend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pibSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pibSend.Location = new System.Drawing.Point(375, 10);
            this.pibSend.Name = "pibSend";
            this.pibSend.Size = new System.Drawing.Size(28, 28);
            this.pibSend.TabIndex = 1;
            this.pibSend.TabStop = false;
            this.pibSend.Click += new System.EventHandler(this.pibSend_Click);
            // 
            // txbType
            // 
            this.txbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbType.Location = new System.Drawing.Point(10, 10);
            this.txbType.Name = "txbType";
            this.txbType.Size = new System.Drawing.Size(350, 28);
            this.txbType.TabIndex = 0;
            this.txbType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbType_KeyDown);
            // 
            // pnMain
            // 
            this.pnMain.Controls.Add(this.pnMainChat);
            this.pnMain.Controls.Add(this.panel1);
            this.pnMain.Controls.Add(this.panel3);
            this.pnMain.Location = new System.Drawing.Point(0, 0);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(420, 450);
            this.pnMain.TabIndex = 4;
            // 
            // pnMainChat
            // 
            this.pnMainChat.AutoScroll = true;
            this.pnMainChat.Location = new System.Drawing.Point(0, 70);
            this.pnMainChat.Name = "pnMainChat";
            this.pnMainChat.Size = new System.Drawing.Size(420, 320);
            this.pnMainChat.TabIndex = 3;
            // 
            // UCChatBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.Controls.Add(this.pnMain);
            this.Name = "UCChatBox";
            this.Size = new System.Drawing.Size(420, 450);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibSend)).EndInit();
            this.pnMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txbType;
        private System.Windows.Forms.PictureBox pibSend;
        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.Panel pnMainChat;
    }
}
