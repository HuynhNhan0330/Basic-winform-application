namespace MusicOnline.Usercontrols
{
    partial class ItemMucic
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
            this.pnThum = new System.Windows.Forms.Panel();
            this.pibThumbnail = new System.Windows.Forms.PictureBox();
            this.pnTitle = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.pnArtistsNames = new System.Windows.Forms.Panel();
            this.lbArtistsNames = new System.Windows.Forms.Label();
            this.pnThum.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibThumbnail)).BeginInit();
            this.pnTitle.SuspendLayout();
            this.pnArtistsNames.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnThum
            // 
            this.pnThum.Controls.Add(this.pibThumbnail);
            this.pnThum.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnThum.Location = new System.Drawing.Point(0, 0);
            this.pnThum.Name = "pnThum";
            this.pnThum.Size = new System.Drawing.Size(200, 185);
            this.pnThum.TabIndex = 1;
            // 
            // pibThumbnail
            // 
            this.pibThumbnail.Location = new System.Drawing.Point(15, 15);
            this.pibThumbnail.Name = "pibThumbnail";
            this.pibThumbnail.Size = new System.Drawing.Size(170, 170);
            this.pibThumbnail.TabIndex = 0;
            this.pibThumbnail.TabStop = false;
            // 
            // pnTitle
            // 
            this.pnTitle.Controls.Add(this.lbTitle);
            this.pnTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTitle.Location = new System.Drawing.Point(0, 185);
            this.pnTitle.Name = "pnTitle";
            this.pnTitle.Size = new System.Drawing.Size(200, 57);
            this.pnTitle.TabIndex = 2;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(15, 20);
            this.lbTitle.MaximumSize = new System.Drawing.Size(170, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(166, 18);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Chúng ta của hiện tại";
            // 
            // pnArtistsNames
            // 
            this.pnArtistsNames.Controls.Add(this.lbArtistsNames);
            this.pnArtistsNames.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnArtistsNames.Location = new System.Drawing.Point(0, 242);
            this.pnArtistsNames.Name = "pnArtistsNames";
            this.pnArtistsNames.Size = new System.Drawing.Size(200, 58);
            this.pnArtistsNames.TabIndex = 3;
            // 
            // lbArtistsNames
            // 
            this.lbArtistsNames.AutoSize = true;
            this.lbArtistsNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbArtistsNames.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.lbArtistsNames.Location = new System.Drawing.Point(15, 15);
            this.lbArtistsNames.MaximumSize = new System.Drawing.Size(170, 0);
            this.lbArtistsNames.Name = "lbArtistsNames";
            this.lbArtistsNames.Size = new System.Drawing.Size(97, 15);
            this.lbArtistsNames.TabIndex = 1;
            this.lbArtistsNames.Text = "Sơn tùng MTP";
            // 
            // ItemMucic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.Controls.Add(this.pnArtistsNames);
            this.Controls.Add(this.pnTitle);
            this.Controls.Add(this.pnThum);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "ItemMucic";
            this.Size = new System.Drawing.Size(200, 300);
            this.pnThum.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pibThumbnail)).EndInit();
            this.pnTitle.ResumeLayout(false);
            this.pnTitle.PerformLayout();
            this.pnArtistsNames.ResumeLayout(false);
            this.pnArtistsNames.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnThum;
        private System.Windows.Forms.PictureBox pibThumbnail;
        private System.Windows.Forms.Panel pnTitle;
        private System.Windows.Forms.Panel pnArtistsNames;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbArtistsNames;
    }
}
