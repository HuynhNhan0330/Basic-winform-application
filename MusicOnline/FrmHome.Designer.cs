namespace MusicOnline
{
    partial class FrmHome
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            slider = new PictureBox();
            pnControlBar = new Panel();
            pibClose = new PictureBox();
            aPanel1 = new APanel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)slider).BeginInit();
            pnControlBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pibClose).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(slider);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 766);
            panel1.Name = "panel1";
            panel1.Size = new Size(1600, 134);
            panel1.TabIndex = 0;
            // 
            // slider
            // 
            slider.BackColor = Color.Transparent;
            slider.Location = new Point(409, 50);
            slider.Name = "slider";
            slider.Size = new Size(538, 62);
            slider.TabIndex = 0;
            slider.TabStop = false;
            slider.Paint += slider_Paint;
            // 
            // pnControlBar
            // 
            pnControlBar.Controls.Add(pibClose);
            pnControlBar.Dock = DockStyle.Top;
            pnControlBar.Location = new Point(0, 0);
            pnControlBar.Name = "pnControlBar";
            pnControlBar.Size = new Size(1600, 57);
            pnControlBar.TabIndex = 1;
            // 
            // pibClose
            // 
            pibClose.BackgroundImage = Properties.Resources.CloseIcon2;
            pibClose.BackgroundImageLayout = ImageLayout.Stretch;
            pibClose.Cursor = Cursors.Hand;
            pibClose.Location = new Point(1543, 25);
            pibClose.Name = "pibClose";
            pibClose.Size = new Size(32, 32);
            pibClose.TabIndex = 0;
            pibClose.TabStop = false;
            pibClose.Click += pibClose_Click;
            // 
            // aPanel1
            // 
            aPanel1.BackColor = Color.FromArgb(36, 35, 34);
            aPanel1.BackgroundColor = Color.FromArgb(36, 35, 34);
            aPanel1.BorderColor = Color.PaleVioletRed;
            aPanel1.BorderRadius = 0;
            aPanel1.BorderSize = 0;
            aPanel1.ForeColor = Color.White;
            aPanel1.Location = new Point(112, 298);
            aPanel1.Name = "aPanel1";
            aPanel1.RoundType = APanel.RoundStyles.Full;
            aPanel1.Size = new Size(188, 50);
            aPanel1.TabIndex = 2;
            aPanel1.TextColor = Color.White;
            // 
            // FrmHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1600, 900);
            Controls.Add(aPanel1);
            Controls.Add(pnControlBar);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmHome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)slider).EndInit();
            pnControlBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pibClose).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel pnControlBar;
        private APanel aPanel1;
        private PictureBox slider;
        private PictureBox pibClose;
    }
}