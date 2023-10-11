namespace HouseWork
{
    partial class UCMessageBot
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
            this.pibAvatarBot = new System.Windows.Forms.PictureBox();
            this.lbText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pibAvatarBot)).BeginInit();
            this.SuspendLayout();
            // 
            // pibAvatarBot
            // 
            this.pibAvatarBot.BackgroundImage = global::HouseWork.Properties.Resources.ChatBotIcon;
            this.pibAvatarBot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pibAvatarBot.Location = new System.Drawing.Point(10, 10);
            this.pibAvatarBot.Name = "pibAvatarBot";
            this.pibAvatarBot.Size = new System.Drawing.Size(45, 45);
            this.pibAvatarBot.TabIndex = 0;
            this.pibAvatarBot.TabStop = false;
            // 
            // lbText
            // 
            this.lbText.AutoSize = true;
            this.lbText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(215)))));
            this.lbText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lbText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(31)))));
            this.lbText.Location = new System.Drawing.Point(65, 18);
            this.lbText.MaximumSize = new System.Drawing.Size(280, 0);
            this.lbText.Name = "lbText";
            this.lbText.Padding = new System.Windows.Forms.Padding(3);
            this.lbText.Size = new System.Drawing.Size(138, 28);
            this.lbText.TabIndex = 1;
            this.lbText.Text = "Tôi yêu bạn ❤️";
            this.lbText.Paint += new System.Windows.Forms.PaintEventHandler(this.lbText_Paint);
            // 
            // UCMessageBot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lbText);
            this.Controls.Add(this.pibAvatarBot);
            this.Name = "UCMessageBot";
            this.Size = new System.Drawing.Size(350, 75);
            ((System.ComponentModel.ISupportInitialize)(this.pibAvatarBot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pibAvatarBot;
        private System.Windows.Forms.Label lbText;
    }
}
