namespace Banking
{
    partial class QRcodeUC
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
            this.components = new System.ComponentModel.Container();
            this.pibCam = new System.Windows.Forms.PictureBox();
            this.timerQR = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pibCam)).BeginInit();
            this.SuspendLayout();
            // 
            // pibCam
            // 
            this.pibCam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pibCam.Location = new System.Drawing.Point(0, 0);
            this.pibCam.Name = "pibCam";
            this.pibCam.Size = new System.Drawing.Size(596, 605);
            this.pibCam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pibCam.TabIndex = 0;
            this.pibCam.TabStop = false;
            // 
            // timerQR
            // 
            this.timerQR.Enabled = true;
            this.timerQR.Tick += new System.EventHandler(this.timerQR_Tick);
            // 
            // QRcodeUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pibCam);
            this.Name = "QRcodeUC";
            this.Size = new System.Drawing.Size(596, 605);
            ((System.ComponentModel.ISupportInitialize)(this.pibCam)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pibCam;
        private System.Windows.Forms.Timer timerQR;
    }
}
