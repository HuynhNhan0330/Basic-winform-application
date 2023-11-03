namespace MusicOnline
{
    partial class FrmLyrics
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
            this.pnLyrics = new System.Windows.Forms.Panel();
            this.pibClose = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pibClose)).BeginInit();
            this.SuspendLayout();
            // 
            // pnLyrics
            // 
            this.pnLyrics.AutoScroll = true;
            this.pnLyrics.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnLyrics.Location = new System.Drawing.Point(50, 50);
            this.pnLyrics.Name = "pnLyrics";
            this.pnLyrics.Size = new System.Drawing.Size(600, 590);
            this.pnLyrics.TabIndex = 0;
            // 
            // pibClose
            // 
            this.pibClose.BackgroundImage = global::MusicOnline.Properties.Resources.CloseIcon2;
            this.pibClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pibClose.Location = new System.Drawing.Point(670, 10);
            this.pibClose.Name = "pibClose";
            this.pibClose.Size = new System.Drawing.Size(20, 20);
            this.pibClose.TabIndex = 1;
            this.pibClose.TabStop = false;
            this.pibClose.Click += new System.EventHandler(this.pibClose_Click);
            // 
            // frmLyrics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(119)))), ((int)(((byte)(127)))));
            this.ClientSize = new System.Drawing.Size(700, 690);
            this.Controls.Add(this.pibClose);
            this.Controls.Add(this.pnLyrics);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLyrics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLyrics";
            ((System.ComponentModel.ISupportInitialize)(this.pibClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnLyrics;
        private System.Windows.Forms.PictureBox pibClose;
    }
}