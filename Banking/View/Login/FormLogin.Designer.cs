namespace Banking
{
    partial class FormLogin
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
            this.apnMain = new Banking.AControls.APanel();
            this.SuspendLayout();
            // 
            // apnMain
            // 
            this.apnMain.BackColor = System.Drawing.Color.White;
            this.apnMain.BackgroundColor = System.Drawing.Color.White;
            this.apnMain.BorderColor = System.Drawing.Color.White;
            this.apnMain.BorderRadius = 60;
            this.apnMain.BorderSize = 0;
            this.apnMain.ForeColor = System.Drawing.Color.White;
            this.apnMain.Location = new System.Drawing.Point(0, 150);
            this.apnMain.Name = "apnMain";
            this.apnMain.RoundType = Banking.AControls.APanel.RoundStyles.Top;
            this.apnMain.Size = new System.Drawing.Size(500, 650);
            this.apnMain.TabIndex = 0;
            this.apnMain.TextColor = System.Drawing.Color.White;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(93)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(500, 800);
            this.Controls.Add(this.apnMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLogin";
            this.ResumeLayout(false);

        }

        #endregion

        private AControls.APanel apnMain;
    }
}