namespace HouseWork
{
    partial class LogoContactUC
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
            this.pibIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pibIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // lbText
            // 
            this.lbText.AutoSize = true;
            this.lbText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbText.Location = new System.Drawing.Point(84, 12);
            this.lbText.Name = "lbText";
            this.lbText.Size = new System.Drawing.Size(174, 25);
            this.lbText.TabIndex = 0;
            this.lbText.Text = "fb.com/huynhan03";
            // 
            // pibIcon
            // 
            this.pibIcon.BackColor = System.Drawing.Color.Transparent;
            this.pibIcon.BackgroundImage = global::HouseWork.Properties.Resources.FBIcon;
            this.pibIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pibIcon.Location = new System.Drawing.Point(10, 0);
            this.pibIcon.Name = "pibIcon";
            this.pibIcon.Size = new System.Drawing.Size(50, 50);
            this.pibIcon.TabIndex = 1;
            this.pibIcon.TabStop = false;
            // 
            // LogoContactUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pibIcon);
            this.Controls.Add(this.lbText);
            this.Name = "LogoContactUC";
            this.Size = new System.Drawing.Size(282, 50);
            ((System.ComponentModel.ISupportInitialize)(this.pibIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbText;
        private System.Windows.Forms.PictureBox pibIcon;
    }
}
