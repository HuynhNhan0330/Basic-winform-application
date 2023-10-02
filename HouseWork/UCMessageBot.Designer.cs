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
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pibAvatarBot)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.lbText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(134)))), ((int)(((byte)(222)))));
            this.lbText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lbText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbText.ForeColor = System.Drawing.Color.White;
            this.lbText.Location = new System.Drawing.Point(65, 22);
            this.lbText.MaximumSize = new System.Drawing.Size(280, 0);
            this.lbText.Name = "lbText";
            this.lbText.Size = new System.Drawing.Size(132, 22);
            this.lbText.TabIndex = 1;
            this.lbText.Text = "Tôi yêu bạn ❤️";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pibAvatarBot);
            this.panel1.Controls.Add(this.lbText);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 75);
            this.panel1.TabIndex = 2;
            // 
            // UCMessageBot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel1);
            this.Name = "UCMessageBot";
            this.Size = new System.Drawing.Size(350, 75);
            ((System.ComponentModel.ISupportInitialize)(this.pibAvatarBot)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pibAvatarBot;
        private System.Windows.Forms.Label lbText;
        private System.Windows.Forms.Panel panel1;
    }
}
