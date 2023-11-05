namespace MusicOnline.Usercontrols
{
    partial class ItemMusicInPlaylistUC
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
            this.pibImage = new System.Windows.Forms.PictureBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.pibDelete = new System.Windows.Forms.PictureBox();
            this.lbArtistsNames = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pibImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // pibImage
            // 
            this.pibImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pibImage.Location = new System.Drawing.Point(30, 15);
            this.pibImage.Name = "pibImage";
            this.pibImage.Size = new System.Drawing.Size(50, 50);
            this.pibImage.TabIndex = 0;
            this.pibImage.TabStop = false;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.White;
            this.lbTitle.Location = new System.Drawing.Point(100, 15);
            this.lbTitle.MaximumSize = new System.Drawing.Size(530, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(188, 20);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "Chúng ta của hiện tại";
            // 
            // pibDelete
            // 
            this.pibDelete.BackgroundImage = global::MusicOnline.Properties.Resources.cancel;
            this.pibDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pibDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pibDelete.Location = new System.Drawing.Point(532, 24);
            this.pibDelete.Name = "pibDelete";
            this.pibDelete.Size = new System.Drawing.Size(20, 20);
            this.pibDelete.TabIndex = 2;
            this.pibDelete.TabStop = false;
            this.pibDelete.Click += new System.EventHandler(this.pibDelete_Click);
            // 
            // lbArtistsNames
            // 
            this.lbArtistsNames.AutoSize = true;
            this.lbArtistsNames.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.lbArtistsNames.Location = new System.Drawing.Point(101, 40);
            this.lbArtistsNames.MaximumSize = new System.Drawing.Size(530, 0);
            this.lbArtistsNames.Name = "lbArtistsNames";
            this.lbArtistsNames.Size = new System.Drawing.Size(98, 16);
            this.lbArtistsNames.TabIndex = 3;
            this.lbArtistsNames.Text = "Sơn tùng - MTP";
            // 
            // ItemMusicInPlaylistUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.Controls.Add(this.lbArtistsNames);
            this.Controls.Add(this.pibDelete);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.pibImage);
            this.Name = "ItemMusicInPlaylistUC";
            this.Size = new System.Drawing.Size(729, 98);
            ((System.ComponentModel.ISupportInitialize)(this.pibImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibDelete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pibImage;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.PictureBox pibDelete;
        private System.Windows.Forms.Label lbArtistsNames;
    }
}
