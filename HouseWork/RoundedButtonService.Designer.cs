namespace HouseWork
{
    partial class RoundedButtonService
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
            this.ptbIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // lbText
            // 
            this.lbText.AutoSize = true;
            this.lbText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbText.Location = new System.Drawing.Point(17, 85);
            this.lbText.Name = "lbText";
            this.lbText.Size = new System.Drawing.Size(115, 25);
            this.lbText.TabIndex = 1;
            this.lbText.Text = "Dọn vệ sinh";
            this.lbText.Click += new System.EventHandler(this.lbText_Click);
            // 
            // ptbIcon
            // 
            this.ptbIcon.BackColor = System.Drawing.Color.Transparent;
            this.ptbIcon.BackgroundImage = global::HouseWork.Properties.Resources.cleaning;
            this.ptbIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbIcon.Location = new System.Drawing.Point(50, 23);
            this.ptbIcon.Name = "ptbIcon";
            this.ptbIcon.Size = new System.Drawing.Size(50, 50);
            this.ptbIcon.TabIndex = 0;
            this.ptbIcon.TabStop = false;
            this.ptbIcon.Click += new System.EventHandler(this.ptbIcon_Click);
            // 
            // RoundedButtonService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbText);
            this.Controls.Add(this.ptbIcon);
            this.DoubleBuffered = true;
            this.Name = "RoundedButtonService";
            this.Size = new System.Drawing.Size(150, 130);
            ((System.ComponentModel.ISupportInitialize)(this.ptbIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbIcon;
        private System.Windows.Forms.Label lbText;
    }
}
