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
            this.loginUC1 = new Banking.LoginUC();
            this.apnMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // apnMain
            // 
            this.apnMain.BackColor = System.Drawing.Color.White;
            this.apnMain.BackgroundColor = System.Drawing.Color.White;
            this.apnMain.BorderColor = System.Drawing.Color.White;
            this.apnMain.BorderRadius = 40;
            this.apnMain.BorderSize = 0;
            this.apnMain.Controls.Add(this.loginUC1);
            this.apnMain.ForeColor = System.Drawing.Color.White;
            this.apnMain.Location = new System.Drawing.Point(50, 50);
            this.apnMain.Name = "apnMain";
            this.apnMain.RoundType = Banking.AControls.APanel.RoundStyles.Full;
            this.apnMain.Size = new System.Drawing.Size(400, 500);
            this.apnMain.TabIndex = 0;
            this.apnMain.TextColor = System.Drawing.Color.White;
            // 
            // loginUC1
            // 
            this.loginUC1.BackColor = System.Drawing.Color.White;
            this.loginUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginUC1.Location = new System.Drawing.Point(0, 0);
            this.loginUC1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loginUC1.Name = "loginUC1";
            this.loginUC1.Size = new System.Drawing.Size(400, 500);
            this.loginUC1.TabIndex = 0;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(123)))), ((int)(((byte)(197)))));
            this.ClientSize = new System.Drawing.Size(500, 600);
            this.Controls.Add(this.apnMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLogin";
            this.apnMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AControls.APanel apnMain;
        private LoginUC loginUC1;
    }
}