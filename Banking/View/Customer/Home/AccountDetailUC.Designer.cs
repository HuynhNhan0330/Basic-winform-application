namespace Banking
{
    partial class AccountDetailUC
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
            this.pibReturn = new System.Windows.Forms.PictureBox();
            this.aPanel1 = new Banking.AControls.APanel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.atxbNewPassword = new Banking.AControls.ATextboxUC();
            this.abtnSavePassword = new Banking.AControls.AButton();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lbCreated = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lbMoney = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbAccountNumber = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbEmail = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbDate = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbGender = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbName = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pibAvatar = new Banking.AControls.ACircularPictureBox();
            this.pibChangeAvatar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pibReturn)).BeginInit();
            this.aPanel1.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibChangeAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // pibReturn
            // 
            this.pibReturn.BackgroundImage = global::Banking.Properties.Resources._return;
            this.pibReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pibReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pibReturn.Location = new System.Drawing.Point(25, 25);
            this.pibReturn.Name = "pibReturn";
            this.pibReturn.Size = new System.Drawing.Size(32, 32);
            this.pibReturn.TabIndex = 12;
            this.pibReturn.TabStop = false;
            this.pibReturn.Click += new System.EventHandler(this.pibReturn_Click);
            // 
            // aPanel1
            // 
            this.aPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(208)))), ((int)(((byte)(130)))));
            this.aPanel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(208)))), ((int)(((byte)(130)))));
            this.aPanel1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.aPanel1.BorderRadius = 0;
            this.aPanel1.BorderSize = 0;
            this.aPanel1.Controls.Add(this.panel8);
            this.aPanel1.Controls.Add(this.panel7);
            this.aPanel1.Controls.Add(this.panel6);
            this.aPanel1.Controls.Add(this.panel5);
            this.aPanel1.Controls.Add(this.panel4);
            this.aPanel1.Controls.Add(this.panel2);
            this.aPanel1.Controls.Add(this.panel1);
            this.aPanel1.Controls.Add(this.panel3);
            this.aPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.aPanel1.ForeColor = System.Drawing.Color.White;
            this.aPanel1.Location = new System.Drawing.Point(0, 140);
            this.aPanel1.Name = "aPanel1";
            this.aPanel1.RoundType = Banking.AControls.APanel.RoundStyles.Full;
            this.aPanel1.Size = new System.Drawing.Size(596, 465);
            this.aPanel1.TabIndex = 13;
            this.aPanel1.TextColor = System.Drawing.Color.White;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.atxbNewPassword);
            this.panel8.Controls.Add(this.abtnSavePassword);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(0, 385);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(596, 80);
            this.panel8.TabIndex = 16;
            // 
            // atxbNewPassword
            // 
            this.atxbNewPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(180)))), ((int)(((byte)(110)))));
            this.atxbNewPassword.BorderColor = System.Drawing.Color.White;
            this.atxbNewPassword.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(180)))), ((int)(((byte)(110)))));
            this.atxbNewPassword.BorderRadius = 10;
            this.atxbNewPassword.BorderSize = 2;
            this.atxbNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.atxbNewPassword.ForeColor = System.Drawing.Color.White;
            this.atxbNewPassword.isFocused = false;
            this.atxbNewPassword.isPlaceholder = true;
            this.atxbNewPassword.Location = new System.Drawing.Point(30, 22);
            this.atxbNewPassword.Margin = new System.Windows.Forms.Padding(4);
            this.atxbNewPassword.Multiline = false;
            this.atxbNewPassword.Name = "atxbNewPassword";
            this.atxbNewPassword.Padding = new System.Windows.Forms.Padding(7);
            this.atxbNewPassword.PasswordChar = false;
            this.atxbNewPassword.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(232)))), ((int)(((byte)(224)))));
            this.atxbNewPassword.PlaceholderText = "Nhập mật khẩu mới";
            this.atxbNewPassword.RoundType = Banking.AControls.ATextboxUC.RoundStyles.Full;
            this.atxbNewPassword.Size = new System.Drawing.Size(200, 35);
            this.atxbNewPassword.TabIndex = 1;
            this.atxbNewPassword.textAlign = Banking.AControls.ATextboxUC.TextAlign.Left;
            this.atxbNewPassword.Texts = "";
            this.atxbNewPassword.UnderlinedStyle = false;
            // 
            // abtnSavePassword
            // 
            this.abtnSavePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(180)))), ((int)(((byte)(110)))));
            this.abtnSavePassword.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(180)))), ((int)(((byte)(110)))));
            this.abtnSavePassword.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.abtnSavePassword.BorderRadius = 15;
            this.abtnSavePassword.BorderSize = 0;
            this.abtnSavePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.abtnSavePassword.FlatAppearance.BorderSize = 0;
            this.abtnSavePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.abtnSavePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.abtnSavePassword.ForeColor = System.Drawing.Color.White;
            this.abtnSavePassword.LineType = Banking.AControls.AButton.LineStyles.None;
            this.abtnSavePassword.Location = new System.Drawing.Point(416, 20);
            this.abtnSavePassword.Name = "abtnSavePassword";
            this.abtnSavePassword.RoundType = Banking.AControls.AButton.RoundStyles.Full;
            this.abtnSavePassword.Size = new System.Drawing.Size(150, 40);
            this.abtnSavePassword.TabIndex = 0;
            this.abtnSavePassword.Text = "Lưu mật khẩu";
            this.abtnSavePassword.TextColor = System.Drawing.Color.White;
            this.abtnSavePassword.ThinknessLine = 0;
            this.abtnSavePassword.UseVisualStyleBackColor = false;
            this.abtnSavePassword.Click += new System.EventHandler(this.abtnSavePassword_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.lbCreated);
            this.panel7.Controls.Add(this.label13);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 330);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(596, 55);
            this.panel7.TabIndex = 12;
            // 
            // lbCreated
            // 
            this.lbCreated.AutoSize = true;
            this.lbCreated.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbCreated.Location = new System.Drawing.Point(498, 15);
            this.lbCreated.Name = "lbCreated";
            this.lbCreated.Size = new System.Drawing.Size(64, 25);
            this.lbCreated.TabIndex = 1;
            this.lbCreated.Text = "label5";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label13.Location = new System.Drawing.Point(25, 15);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(174, 25);
            this.label13.TabIndex = 0;
            this.label13.Text = "Ngày tạo tài khoản";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.lbMoney);
            this.panel6.Controls.Add(this.label11);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 275);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(596, 55);
            this.panel6.TabIndex = 11;
            // 
            // lbMoney
            // 
            this.lbMoney.AutoSize = true;
            this.lbMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbMoney.Location = new System.Drawing.Point(498, 15);
            this.lbMoney.Name = "lbMoney";
            this.lbMoney.Size = new System.Drawing.Size(64, 25);
            this.lbMoney.TabIndex = 1;
            this.lbMoney.Text = "label5";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label11.Location = new System.Drawing.Point(25, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 25);
            this.label11.TabIndex = 0;
            this.label11.Text = "Số dư";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lbAccountNumber);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 220);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(596, 55);
            this.panel5.TabIndex = 10;
            // 
            // lbAccountNumber
            // 
            this.lbAccountNumber.AutoSize = true;
            this.lbAccountNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbAccountNumber.Location = new System.Drawing.Point(498, 15);
            this.lbAccountNumber.Name = "lbAccountNumber";
            this.lbAccountNumber.Size = new System.Drawing.Size(64, 25);
            this.lbAccountNumber.TabIndex = 1;
            this.lbAccountNumber.Text = "label5";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.Location = new System.Drawing.Point(25, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "Số tài khoản";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lbEmail);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 165);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(596, 55);
            this.panel4.TabIndex = 9;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbEmail.Location = new System.Drawing.Point(498, 15);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(64, 25);
            this.lbEmail.TabIndex = 1;
            this.lbEmail.Text = "label5";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(25, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Email";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbDate);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 110);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(596, 55);
            this.panel2.TabIndex = 8;
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbDate.Location = new System.Drawing.Point(498, 15);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(64, 25);
            this.lbDate.TabIndex = 1;
            this.lbDate.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(25, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày sinh";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbGender);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(596, 55);
            this.panel1.TabIndex = 7;
            // 
            // lbGender
            // 
            this.lbGender.AutoSize = true;
            this.lbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbGender.Location = new System.Drawing.Point(498, 15);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(64, 25);
            this.lbGender.TabIndex = 1;
            this.lbGender.Text = "label5";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(25, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Giới tính";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbName);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(596, 55);
            this.panel3.TabIndex = 6;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbName.Location = new System.Drawing.Point(498, 15);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(64, 25);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(25, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Họ và tên";
            // 
            // pibAvatar
            // 
            this.pibAvatar.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.pibAvatar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(221)))), ((int)(((byte)(164)))));
            this.pibAvatar.BorderColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(74)))), ((int)(((byte)(46)))));
            this.pibAvatar.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.pibAvatar.BorderSize = 2;
            this.pibAvatar.GradientAngle = 50F;
            this.pibAvatar.Location = new System.Drawing.Point(248, 25);
            this.pibAvatar.Name = "pibAvatar";
            this.pibAvatar.Size = new System.Drawing.Size(100, 100);
            this.pibAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pibAvatar.TabIndex = 7;
            this.pibAvatar.TabStop = false;
            // 
            // pibChangeAvatar
            // 
            this.pibChangeAvatar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pibChangeAvatar.Image = global::Banking.Properties.Resources.changes;
            this.pibChangeAvatar.Location = new System.Drawing.Point(354, 93);
            this.pibChangeAvatar.Name = "pibChangeAvatar";
            this.pibChangeAvatar.Size = new System.Drawing.Size(32, 32);
            this.pibChangeAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pibChangeAvatar.TabIndex = 14;
            this.pibChangeAvatar.TabStop = false;
            this.pibChangeAvatar.Click += new System.EventHandler(this.pibChangeAvatar_Click);
            // 
            // AccountDetailUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pibChangeAvatar);
            this.Controls.Add(this.aPanel1);
            this.Controls.Add(this.pibReturn);
            this.Controls.Add(this.pibAvatar);
            this.Name = "AccountDetailUC";
            this.Size = new System.Drawing.Size(596, 605);
            this.Load += new System.EventHandler(this.AccountDetailUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pibReturn)).EndInit();
            this.aPanel1.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibChangeAvatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label label6;
        private AControls.ACircularPictureBox pibAvatar;
        private System.Windows.Forms.PictureBox pibReturn;
        private AControls.APanel aPanel1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lbCreated;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lbMoney;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lbAccountNumber;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbGender;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel8;
        private AControls.ATextboxUC atxbNewPassword;
        private AControls.AButton abtnSavePassword;
        private System.Windows.Forms.PictureBox pibChangeAvatar;
    }
}
