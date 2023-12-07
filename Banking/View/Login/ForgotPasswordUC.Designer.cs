namespace Banking
{
    partial class ForgotPasswordUC
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
            this.aPanel2 = new Banking.AControls.APanel();
            this.atxbPassword = new Banking.AControls.ATextboxUC();
            this.pibHideViewPassword = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbSendOTP = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.aPanel1 = new Banking.AControls.APanel();
            this.atxbOTP = new Banking.AControls.ATextboxUC();
            this.abtnLogin = new Banking.AControls.AButton();
            this.lbLogin = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.aPanel3 = new Banking.AControls.APanel();
            this.atxbEmail = new Banking.AControls.ATextboxUC();
            this.aPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibHideViewPassword)).BeginInit();
            this.aPanel1.SuspendLayout();
            this.aPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // aPanel2
            // 
            this.aPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(180)))), ((int)(((byte)(110)))));
            this.aPanel2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(180)))), ((int)(((byte)(110)))));
            this.aPanel2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.aPanel2.BorderRadius = 10;
            this.aPanel2.BorderSize = 0;
            this.aPanel2.Controls.Add(this.atxbPassword);
            this.aPanel2.Controls.Add(this.pibHideViewPassword);
            this.aPanel2.ForeColor = System.Drawing.Color.White;
            this.aPanel2.Location = new System.Drawing.Point(100, 280);
            this.aPanel2.Name = "aPanel2";
            this.aPanel2.RoundType = Banking.AControls.APanel.RoundStyles.Full;
            this.aPanel2.Size = new System.Drawing.Size(400, 40);
            this.aPanel2.TabIndex = 40;
            this.aPanel2.TextColor = System.Drawing.Color.White;
            // 
            // atxbPassword
            // 
            this.atxbPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(180)))), ((int)(((byte)(110)))));
            this.atxbPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(180)))), ((int)(((byte)(110)))));
            this.atxbPassword.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(180)))), ((int)(((byte)(110)))));
            this.atxbPassword.BorderRadius = 0;
            this.atxbPassword.BorderSize = 2;
            this.atxbPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.atxbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.atxbPassword.ForeColor = System.Drawing.Color.White;
            this.atxbPassword.isFocused = false;
            this.atxbPassword.isPlaceholder = true;
            this.atxbPassword.Location = new System.Drawing.Point(19, 3);
            this.atxbPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.atxbPassword.Multiline = false;
            this.atxbPassword.Name = "atxbPassword";
            this.atxbPassword.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.atxbPassword.PasswordChar = true;
            this.atxbPassword.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(232)))), ((int)(((byte)(224)))));
            this.atxbPassword.PlaceholderText = "Mật khẩu mới";
            this.atxbPassword.RoundType = Banking.AControls.ATextboxUC.RoundStyles.Full;
            this.atxbPassword.Size = new System.Drawing.Size(330, 33);
            this.atxbPassword.TabIndex = 29;
            this.atxbPassword.textAlign = Banking.AControls.ATextboxUC.TextAlign.Left;
            this.atxbPassword.Texts = "";
            this.atxbPassword.UnderlinedStyle = false;
            // 
            // pibHideViewPassword
            // 
            this.pibHideViewPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(180)))), ((int)(((byte)(110)))));
            this.pibHideViewPassword.BackgroundImage = global::Banking.Properties.Resources.view;
            this.pibHideViewPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pibHideViewPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pibHideViewPassword.Location = new System.Drawing.Point(361, 9);
            this.pibHideViewPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pibHideViewPassword.Name = "pibHideViewPassword";
            this.pibHideViewPassword.Size = new System.Drawing.Size(22, 22);
            this.pibHideViewPassword.TabIndex = 25;
            this.pibHideViewPassword.TabStop = false;
            this.pibHideViewPassword.Click += new System.EventHandler(this.pibHideViewPassword_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(185, 50);
            this.label4.MaximumSize = new System.Drawing.Size(330, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 35);
            this.label4.TabIndex = 37;
            this.label4.Text = "Quên mật khẩu";
            // 
            // lbSendOTP
            // 
            this.lbSendOTP.AutoSize = true;
            this.lbSendOTP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbSendOTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lbSendOTP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(156)))), ((int)(((byte)(95)))));
            this.lbSendOTP.Location = new System.Drawing.Point(429, 236);
            this.lbSendOTP.Name = "lbSendOTP";
            this.lbSendOTP.Size = new System.Drawing.Size(62, 18);
            this.lbSendOTP.TabIndex = 35;
            this.lbSendOTP.Text = "Gửi mã";
            this.lbSendOTP.Click += new System.EventHandler(this.lbSendOTP_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(113)))), ((int)(((byte)(122)))));
            this.label2.Location = new System.Drawing.Point(328, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 18);
            this.label2.TabIndex = 34;
            this.label2.Text = "Chưa có mã?";
            // 
            // aPanel1
            // 
            this.aPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(180)))), ((int)(((byte)(110)))));
            this.aPanel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(180)))), ((int)(((byte)(110)))));
            this.aPanel1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.aPanel1.BorderRadius = 10;
            this.aPanel1.BorderSize = 0;
            this.aPanel1.Controls.Add(this.atxbOTP);
            this.aPanel1.ForeColor = System.Drawing.Color.White;
            this.aPanel1.Location = new System.Drawing.Point(100, 191);
            this.aPanel1.Name = "aPanel1";
            this.aPanel1.RoundType = Banking.AControls.APanel.RoundStyles.Full;
            this.aPanel1.Size = new System.Drawing.Size(400, 40);
            this.aPanel1.TabIndex = 39;
            this.aPanel1.TextColor = System.Drawing.Color.White;
            // 
            // atxbOTP
            // 
            this.atxbOTP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(180)))), ((int)(((byte)(110)))));
            this.atxbOTP.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(180)))), ((int)(((byte)(110)))));
            this.atxbOTP.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(180)))), ((int)(((byte)(110)))));
            this.atxbOTP.BorderRadius = 0;
            this.atxbOTP.BorderSize = 2;
            this.atxbOTP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.atxbOTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.atxbOTP.ForeColor = System.Drawing.Color.White;
            this.atxbOTP.isFocused = false;
            this.atxbOTP.isPlaceholder = true;
            this.atxbOTP.Location = new System.Drawing.Point(19, 3);
            this.atxbOTP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.atxbOTP.Multiline = false;
            this.atxbOTP.Name = "atxbOTP";
            this.atxbOTP.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.atxbOTP.PasswordChar = false;
            this.atxbOTP.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(232)))), ((int)(((byte)(224)))));
            this.atxbOTP.PlaceholderText = "Mã OTP";
            this.atxbOTP.RoundType = Banking.AControls.ATextboxUC.RoundStyles.Full;
            this.atxbOTP.Size = new System.Drawing.Size(350, 33);
            this.atxbOTP.TabIndex = 22;
            this.atxbOTP.textAlign = Banking.AControls.ATextboxUC.TextAlign.Left;
            this.atxbOTP.Texts = "";
            this.atxbOTP.UnderlinedStyle = false;
            // 
            // abtnLogin
            // 
            this.abtnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(208)))), ((int)(((byte)(128)))));
            this.abtnLogin.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(208)))), ((int)(((byte)(128)))));
            this.abtnLogin.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.abtnLogin.BorderRadius = 15;
            this.abtnLogin.BorderSize = 0;
            this.abtnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.abtnLogin.FlatAppearance.BorderSize = 0;
            this.abtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.abtnLogin.Font = new System.Drawing.Font("Arial", 10.8F);
            this.abtnLogin.ForeColor = System.Drawing.Color.White;
            this.abtnLogin.LineType = Banking.AControls.AButton.LineStyles.None;
            this.abtnLogin.Location = new System.Drawing.Point(100, 350);
            this.abtnLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.abtnLogin.Name = "abtnLogin";
            this.abtnLogin.RoundType = Banking.AControls.AButton.RoundStyles.Full;
            this.abtnLogin.Size = new System.Drawing.Size(400, 40);
            this.abtnLogin.TabIndex = 36;
            this.abtnLogin.Text = "Xác nhận";
            this.abtnLogin.TextColor = System.Drawing.Color.White;
            this.abtnLogin.ThinknessLine = 0;
            this.abtnLogin.UseVisualStyleBackColor = false;
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lbLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(156)))), ((int)(((byte)(95)))));
            this.lbLogin.Location = new System.Drawing.Point(328, 415);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(88, 18);
            this.lbLogin.TabIndex = 42;
            this.lbLogin.Text = "Đăng nhập";
            this.lbLogin.Click += new System.EventHandler(this.lbLogin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(113)))), ((int)(((byte)(122)))));
            this.label3.Location = new System.Drawing.Point(189, 415);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 18);
            this.label3.TabIndex = 41;
            this.label3.Text = "Đã nhớ mật khẩu?";
            // 
            // aPanel3
            // 
            this.aPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(180)))), ((int)(((byte)(110)))));
            this.aPanel3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(180)))), ((int)(((byte)(110)))));
            this.aPanel3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.aPanel3.BorderRadius = 10;
            this.aPanel3.BorderSize = 0;
            this.aPanel3.Controls.Add(this.atxbEmail);
            this.aPanel3.ForeColor = System.Drawing.Color.White;
            this.aPanel3.Location = new System.Drawing.Point(100, 125);
            this.aPanel3.Name = "aPanel3";
            this.aPanel3.RoundType = Banking.AControls.APanel.RoundStyles.Full;
            this.aPanel3.Size = new System.Drawing.Size(400, 40);
            this.aPanel3.TabIndex = 43;
            this.aPanel3.TextColor = System.Drawing.Color.White;
            // 
            // atxbEmail
            // 
            this.atxbEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(180)))), ((int)(((byte)(110)))));
            this.atxbEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(180)))), ((int)(((byte)(110)))));
            this.atxbEmail.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(180)))), ((int)(((byte)(110)))));
            this.atxbEmail.BorderRadius = 0;
            this.atxbEmail.BorderSize = 2;
            this.atxbEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.atxbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.atxbEmail.ForeColor = System.Drawing.Color.White;
            this.atxbEmail.isFocused = false;
            this.atxbEmail.isPlaceholder = true;
            this.atxbEmail.Location = new System.Drawing.Point(19, 3);
            this.atxbEmail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.atxbEmail.Multiline = false;
            this.atxbEmail.Name = "atxbEmail";
            this.atxbEmail.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.atxbEmail.PasswordChar = false;
            this.atxbEmail.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(232)))), ((int)(((byte)(224)))));
            this.atxbEmail.PlaceholderText = "Nhập email";
            this.atxbEmail.RoundType = Banking.AControls.ATextboxUC.RoundStyles.Full;
            this.atxbEmail.Size = new System.Drawing.Size(350, 33);
            this.atxbEmail.TabIndex = 22;
            this.atxbEmail.textAlign = Banking.AControls.ATextboxUC.TextAlign.Left;
            this.atxbEmail.Texts = "";
            this.atxbEmail.UnderlinedStyle = false;
            // 
            // ForgotPasswordUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.aPanel3);
            this.Controls.Add(this.lbLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.aPanel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbSendOTP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.aPanel1);
            this.Controls.Add(this.abtnLogin);
            this.Name = "ForgotPasswordUC";
            this.Size = new System.Drawing.Size(600, 600);
            this.aPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pibHideViewPassword)).EndInit();
            this.aPanel1.ResumeLayout(false);
            this.aPanel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private AControls.APanel aPanel2;
        private AControls.ATextboxUC atxbPassword;
        private System.Windows.Forms.PictureBox pibHideViewPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbSendOTP;
        private System.Windows.Forms.Label label2;
        private AControls.APanel aPanel1;
        private AControls.ATextboxUC atxbOTP;
        private AControls.AButton abtnLogin;
        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.Label label3;
        private AControls.APanel aPanel3;
        private AControls.ATextboxUC atxbEmail;
    }
}
