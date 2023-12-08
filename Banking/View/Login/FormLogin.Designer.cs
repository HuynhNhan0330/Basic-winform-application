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
            this.lbNameBank = new System.Windows.Forms.Label();
            this.apnMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // apnMain
            // 
            this.apnMain.BackColor = System.Drawing.Color.White;
            this.apnMain.BackgroundColor = System.Drawing.Color.White;
            this.apnMain.BorderColor = System.Drawing.Color.White;
            this.apnMain.BorderRadius = 60;
            this.apnMain.BorderSize = 0;
            this.apnMain.Controls.Add(this.loginUC1);
            this.apnMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.apnMain.ForeColor = System.Drawing.Color.White;
            this.apnMain.Location = new System.Drawing.Point(0, 200);
            this.apnMain.Name = "apnMain";
            this.apnMain.RoundType = Banking.AControls.APanel.RoundStyles.Top;
            this.apnMain.Size = new System.Drawing.Size(600, 600);
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
            this.loginUC1.Size = new System.Drawing.Size(600, 600);
            this.loginUC1.TabIndex = 0;
            // 
            // lbNameBank
            // 
            this.lbNameBank.AutoSize = true;
            this.lbNameBank.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.lbNameBank.ForeColor = System.Drawing.Color.White;
            this.lbNameBank.Location = new System.Drawing.Point(236, 80);
            this.lbNameBank.Name = "lbNameBank";
            this.lbNameBank.Size = new System.Drawing.Size(125, 39);
            this.lbNameBank.TabIndex = 1;
            this.lbNameBank.Text = "NBank";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(93)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(600, 800);
            this.Controls.Add(this.lbNameBank);
            this.Controls.Add(this.apnMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLogin";
            this.apnMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AControls.APanel apnMain;
        private LoginUC loginUC1;
        private System.Windows.Forms.Label lbNameBank;
    }
}