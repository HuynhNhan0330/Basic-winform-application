namespace MusicOnline.Usercontrols
{
    partial class PlaylistItemUC
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
            this.lbText = new System.Windows.Forms.Label();
            this.pibDelete = new System.Windows.Forms.PictureBox();
            this.pibEdit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pibDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // lbText
            // 
            this.lbText.AutoSize = true;
            this.lbText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbText.ForeColor = System.Drawing.Color.White;
            this.lbText.Location = new System.Drawing.Point(15, 15);
            this.lbText.MaximumSize = new System.Drawing.Size(220, 0);
            this.lbText.Name = "lbText";
            this.lbText.Size = new System.Drawing.Size(62, 20);
            this.lbText.TabIndex = 0;
            this.lbText.Text = "Nhạc 1";
            this.lbText.Click += new System.EventHandler(this.PlaylistItemUC_Click);
            // 
            // pibDelete
            // 
            this.pibDelete.BackgroundImage = global::MusicOnline.Properties.Resources.close_button;
            this.pibDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pibDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pibDelete.Location = new System.Drawing.Point(274, 17);
            this.pibDelete.Name = "pibDelete";
            this.pibDelete.Size = new System.Drawing.Size(16, 16);
            this.pibDelete.TabIndex = 2;
            this.pibDelete.TabStop = false;
            this.pibDelete.Click += new System.EventHandler(this.pibDelete_Click);
            // 
            // pibEdit
            // 
            this.pibEdit.BackgroundImage = global::MusicOnline.Properties.Resources.pencil;
            this.pibEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pibEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pibEdit.Location = new System.Drawing.Point(240, 17);
            this.pibEdit.Name = "pibEdit";
            this.pibEdit.Size = new System.Drawing.Size(16, 16);
            this.pibEdit.TabIndex = 1;
            this.pibEdit.TabStop = false;
            this.pibEdit.Click += new System.EventHandler(this.pibEdit_Click);
            // 
            // PlaylistItemUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.Controls.Add(this.pibDelete);
            this.Controls.Add(this.pibEdit);
            this.Controls.Add(this.lbText);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "PlaylistItemUC";
            this.Size = new System.Drawing.Size(350, 45);
            this.Load += new System.EventHandler(this.PlaylistItemUC_Load);
            this.Click += new System.EventHandler(this.PlaylistItemUC_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pibDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibEdit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbText;
        private System.Windows.Forms.PictureBox pibEdit;
        private System.Windows.Forms.PictureBox pibDelete;
    }
}
