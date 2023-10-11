namespace HouseWork
{
    partial class UCLogin
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
            this.cbShowPassword = new System.Windows.Forms.CheckBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pnLogin = new System.Windows.Forms.Panel();
            this.pnPassword = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnPasswordChild = new System.Windows.Forms.Panel();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnFacebook = new System.Windows.Forms.Button();
            this.pnAccount = new System.Windows.Forms.Panel();
            this.pnAcountChild = new System.Windows.Forms.Panel();
            this.txbAccount = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGoogle = new System.Windows.Forms.Button();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pnLogin.SuspendLayout();
            this.pnPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnPasswordChild.SuspendLayout();
            this.pnAccount.SuspendLayout();
            this.pnAcountChild.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // cbShowPassword
            // 
            this.cbShowPassword.AutoSize = true;
            this.cbShowPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbShowPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbShowPassword.Location = new System.Drawing.Point(189, 215);
            this.cbShowPassword.Name = "cbShowPassword";
            this.cbShowPassword.Size = new System.Drawing.Size(171, 26);
            this.cbShowPassword.TabIndex = 90;
            this.cbShowPassword.Text = "Hiển thị mật khẩu";
            this.cbShowPassword.UseVisualStyleBackColor = true;
            this.cbShowPassword.CheckedChanged += new System.EventHandler(this.cbShowPassword_CheckedChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(101)))), ((int)(((byte)(174)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(25, 251);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(350, 50);
            this.btnLogin.TabIndex = 100;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(126, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Hoặc đăng nhập bằng";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Location = new System.Drawing.Point(282, 323);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(85, 2);
            this.panel3.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gray;
            this.panel4.Location = new System.Drawing.Point(32, 323);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(85, 2);
            this.panel4.TabIndex = 8;
            // 
            // pnLogin
            // 
            this.pnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(230)))), ((int)(((byte)(252)))));
            this.pnLogin.Controls.Add(this.pnPassword);
            this.pnLogin.Controls.Add(this.btnFacebook);
            this.pnLogin.Controls.Add(this.pnAccount);
            this.pnLogin.Controls.Add(this.btnGoogle);
            this.pnLogin.Controls.Add(this.cbShowPassword);
            this.pnLogin.Controls.Add(this.panel4);
            this.pnLogin.Controls.Add(this.btnLogin);
            this.pnLogin.Controls.Add(this.panel3);
            this.pnLogin.Controls.Add(this.label4);
            this.pnLogin.Location = new System.Drawing.Point(100, 50);
            this.pnLogin.Name = "pnLogin";
            this.pnLogin.Size = new System.Drawing.Size(400, 500);
            this.pnLogin.TabIndex = 30;
            // 
            // pnPassword
            // 
            this.pnPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.pnPassword.Controls.Add(this.pictureBox2);
            this.pnPassword.Controls.Add(this.pnPasswordChild);
            this.pnPassword.Controls.Add(this.label7);
            this.pnPassword.Location = new System.Drawing.Point(25, 120);
            this.pnPassword.Name = "pnPassword";
            this.pnPassword.Size = new System.Drawing.Size(350, 85);
            this.pnPassword.TabIndex = 23;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::HouseWork.Properties.Resources.PasswordIcon;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(10, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pnPasswordChild
            // 
            this.pnPasswordChild.BackColor = System.Drawing.Color.White;
            this.pnPasswordChild.Controls.Add(this.txbPassword);
            this.pnPasswordChild.Location = new System.Drawing.Point(5, 38);
            this.pnPasswordChild.Name = "pnPasswordChild";
            this.pnPasswordChild.Size = new System.Drawing.Size(340, 41);
            this.pnPasswordChild.TabIndex = 3;
            // 
            // txbPassword
            // 
            this.txbPassword.BackColor = System.Drawing.Color.White;
            this.txbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPassword.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txbPassword.Location = new System.Drawing.Point(10, 10);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.Size = new System.Drawing.Size(320, 21);
            this.txbPassword.TabIndex = 3;
            this.txbPassword.Text = "password";
            this.txbPassword.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(44, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 25);
            this.label7.TabIndex = 2;
            this.label7.Text = "Mật khẩu";
            // 
            // btnFacebook
            // 
            this.btnFacebook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(121)))), ((int)(((byte)(237)))));
            this.btnFacebook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFacebook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacebook.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacebook.ForeColor = System.Drawing.Color.White;
            this.btnFacebook.Image = global::HouseWork.Properties.Resources.facebook;
            this.btnFacebook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFacebook.Location = new System.Drawing.Point(25, 420);
            this.btnFacebook.Name = "btnFacebook";
            this.btnFacebook.Size = new System.Drawing.Size(350, 50);
            this.btnFacebook.TabIndex = 120;
            this.btnFacebook.Text = "FACEBOOK";
            this.btnFacebook.UseVisualStyleBackColor = false;
            // 
            // pnAccount
            // 
            this.pnAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.pnAccount.Controls.Add(this.pnAcountChild);
            this.pnAccount.Controls.Add(this.pictureBox3);
            this.pnAccount.Controls.Add(this.label5);
            this.pnAccount.Location = new System.Drawing.Point(25, 25);
            this.pnAccount.Name = "pnAccount";
            this.pnAccount.Size = new System.Drawing.Size(350, 85);
            this.pnAccount.TabIndex = 21;
            // 
            // pnAcountChild
            // 
            this.pnAcountChild.BackColor = System.Drawing.Color.White;
            this.pnAcountChild.Controls.Add(this.txbAccount);
            this.pnAcountChild.Location = new System.Drawing.Point(5, 38);
            this.pnAcountChild.Name = "pnAcountChild";
            this.pnAcountChild.Size = new System.Drawing.Size(340, 41);
            this.pnAcountChild.TabIndex = 3;
            // 
            // txbAccount
            // 
            this.txbAccount.BackColor = System.Drawing.Color.White;
            this.txbAccount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbAccount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbAccount.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txbAccount.Location = new System.Drawing.Point(10, 10);
            this.txbAccount.Name = "txbAccount";
            this.txbAccount.Size = new System.Drawing.Size(320, 21);
            this.txbAccount.TabIndex = 3;
            this.txbAccount.Text = "nhanhuynh@gmail.com";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::HouseWork.Properties.Resources.AccountIcon;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(10, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tài khoản";
            // 
            // btnGoogle
            // 
            this.btnGoogle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.btnGoogle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGoogle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoogle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoogle.ForeColor = System.Drawing.Color.White;
            this.btnGoogle.Image = global::HouseWork.Properties.Resources.GoogleIcon2;
            this.btnGoogle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGoogle.Location = new System.Drawing.Point(25, 349);
            this.btnGoogle.Name = "btnGoogle";
            this.btnGoogle.Size = new System.Drawing.Size(350, 50);
            this.btnGoogle.TabIndex = 110;
            this.btnGoogle.Text = "GOOGLE";
            this.btnGoogle.UseVisualStyleBackColor = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.BackgroundImage = global::HouseWork.Properties.Resources.LoginImg;
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox7.Location = new System.Drawing.Point(600, 50);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(800, 500);
            this.pictureBox7.TabIndex = 29;
            this.pictureBox7.TabStop = false;
            // 
            // UCLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(238)))), ((int)(((byte)(253)))));
            this.Controls.Add(this.pnLogin);
            this.Controls.Add(this.pictureBox7);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(31)))));
            this.Name = "UCLogin";
            this.Size = new System.Drawing.Size(1500, 600);
            this.Load += new System.EventHandler(this.UCLogin_Load);
            this.pnLogin.ResumeLayout(false);
            this.pnLogin.PerformLayout();
            this.pnPassword.ResumeLayout(false);
            this.pnPassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnPasswordChild.ResumeLayout(false);
            this.pnPasswordChild.PerformLayout();
            this.pnAccount.ResumeLayout(false);
            this.pnAccount.PerformLayout();
            this.pnAcountChild.ResumeLayout(false);
            this.pnAcountChild.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.CheckBox cbShowPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnGoogle;
        private System.Windows.Forms.Button btnFacebook;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Panel pnLogin;
        private System.Windows.Forms.Panel pnAccount;
        private System.Windows.Forms.Panel pnAcountChild;
        private System.Windows.Forms.TextBox txbAccount;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnPassword;
        private System.Windows.Forms.Panel pnPasswordChild;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.Label label7;
    }
}
