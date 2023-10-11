namespace HouseWork
{
    partial class RoundedButtonMenu
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
            this.pibIcon = new System.Windows.Forms.PictureBox();
            this.lbText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pibIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // pibIcon
            // 
            this.pibIcon.BackgroundImage = global::HouseWork.Properties.Resources.HomeIcon1;
            this.pibIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pibIcon.Location = new System.Drawing.Point(59, 20);
            this.pibIcon.Name = "pibIcon";
            this.pibIcon.Size = new System.Drawing.Size(32, 32);
            this.pibIcon.TabIndex = 0;
            this.pibIcon.TabStop = false;
            this.pibIcon.Click += new System.EventHandler(this.pibIcon_Click);
            // 
            // lbText
            // 
            this.lbText.AutoSize = true;
            this.lbText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbText.Location = new System.Drawing.Point(38, 63);
            this.lbText.Name = "lbText";
            this.lbText.Size = new System.Drawing.Size(78, 29);
            this.lbText.TabIndex = 1;
            this.lbText.Text = "Home";
            this.lbText.Click += new System.EventHandler(this.lbText_Click);
            // 
            // RoundedButtonMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbText);
            this.Controls.Add(this.pibIcon);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "RoundedButtonMenu";
            this.Size = new System.Drawing.Size(150, 100);
            ((System.ComponentModel.ISupportInitialize)(this.pibIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pibIcon;
        private System.Windows.Forms.Label lbText;
    }
}
