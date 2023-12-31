﻿using System.Drawing;
using System.Windows.Forms;

namespace Banking
{
    partial class RegisterUC
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
            this.label4 = new System.Windows.Forms.Label();
            this.lbLogin = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.abtnRegsiter = new Banking.AControls.AButton();
            this.aPanel1 = new Banking.AControls.APanel();
            this.atxbName = new Banking.AControls.ATextboxUC();
            this.aPanel2 = new Banking.AControls.APanel();
            this.atxbEmail = new Banking.AControls.ATextboxUC();
            this.aPanel3 = new Banking.AControls.APanel();
            this.atxbPhone = new Banking.AControls.ATextboxUC();
            this.aPanel4 = new Banking.AControls.APanel();
            this.atxbPassword = new Banking.AControls.ATextboxUC();
            this.pibHideViewPassword = new System.Windows.Forms.PictureBox();
            this.aPanel5 = new Banking.AControls.APanel();
            this.atxbRePassword = new Banking.AControls.ATextboxUC();
            this.pibHideViewRePassword = new System.Windows.Forms.PictureBox();
            this.aPanel6 = new Banking.AControls.APanel();
            this.adpBirthday = new Banking.AControls.ADateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.rdMan = new System.Windows.Forms.RadioButton();
            this.aPanel7 = new Banking.AControls.APanel();
            this.label3 = new System.Windows.Forms.Label();
            this.rdWoman = new System.Windows.Forms.RadioButton();
            this.aPanel1.SuspendLayout();
            this.aPanel2.SuspendLayout();
            this.aPanel3.SuspendLayout();
            this.aPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibHideViewPassword)).BeginInit();
            this.aPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibHideViewRePassword)).BeginInit();
            this.aPanel6.SuspendLayout();
            this.aPanel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(196, 50);
            this.label4.MaximumSize = new System.Drawing.Size(330, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 35);
            this.label4.TabIndex = 15;
            this.label4.Text = "Tạo tài khoản";
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lbLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(156)))), ((int)(((byte)(95)))));
            this.lbLogin.Location = new System.Drawing.Point(305, 553);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(88, 18);
            this.lbLogin.TabIndex = 13;
            this.lbLogin.Text = "Đăng nhập";
            this.lbLogin.Click += new System.EventHandler(this.lbLogin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(113)))), ((int)(((byte)(122)))));
            this.label2.Location = new System.Drawing.Point(179, 553);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Đã có tài khoản?";
            // 
            // abtnRegsiter
            // 
            this.abtnRegsiter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(208)))), ((int)(((byte)(128)))));
            this.abtnRegsiter.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(208)))), ((int)(((byte)(128)))));
            this.abtnRegsiter.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.abtnRegsiter.BorderRadius = 15;
            this.abtnRegsiter.BorderSize = 0;
            this.abtnRegsiter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.abtnRegsiter.FlatAppearance.BorderSize = 0;
            this.abtnRegsiter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.abtnRegsiter.Font = new System.Drawing.Font("Arial", 10.8F);
            this.abtnRegsiter.ForeColor = System.Drawing.Color.White;
            this.abtnRegsiter.LineType = Banking.AControls.AButton.LineStyles.None;
            this.abtnRegsiter.Location = new System.Drawing.Point(100, 500);
            this.abtnRegsiter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.abtnRegsiter.Name = "abtnRegsiter";
            this.abtnRegsiter.RoundType = Banking.AControls.AButton.RoundStyles.Full;
            this.abtnRegsiter.Size = new System.Drawing.Size(400, 40);
            this.abtnRegsiter.TabIndex = 14;
            this.abtnRegsiter.Text = "Đăng ký";
            this.abtnRegsiter.TextColor = System.Drawing.Color.White;
            this.abtnRegsiter.ThinknessLine = 0;
            this.abtnRegsiter.UseVisualStyleBackColor = false;
            this.abtnRegsiter.Click += new System.EventHandler(this.abtnRegsiter_Click);
            // 
            // aPanel1
            // 
            this.aPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(180)))), ((int)(((byte)(110)))));
            this.aPanel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(180)))), ((int)(((byte)(110)))));
            this.aPanel1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.aPanel1.BorderRadius = 10;
            this.aPanel1.BorderSize = 0;
            this.aPanel1.Controls.Add(this.atxbName);
            this.aPanel1.ForeColor = System.Drawing.Color.White;
            this.aPanel1.Location = new System.Drawing.Point(100, 115);
            this.aPanel1.Name = "aPanel1";
            this.aPanel1.RoundType = Banking.AControls.APanel.RoundStyles.Full;
            this.aPanel1.Size = new System.Drawing.Size(400, 40);
            this.aPanel1.TabIndex = 32;
            this.aPanel1.TextColor = System.Drawing.Color.White;
            // 
            // atxbName
            // 
            this.atxbName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(180)))), ((int)(((byte)(110)))));
            this.atxbName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(180)))), ((int)(((byte)(110)))));
            this.atxbName.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(180)))), ((int)(((byte)(110)))));
            this.atxbName.BorderRadius = 0;
            this.atxbName.BorderSize = 2;
            this.atxbName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.atxbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.atxbName.ForeColor = System.Drawing.Color.White;
            this.atxbName.isFocused = false;
            this.atxbName.isPlaceholder = true;
            this.atxbName.Location = new System.Drawing.Point(19, 3);
            this.atxbName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.atxbName.Multiline = false;
            this.atxbName.Name = "atxbName";
            this.atxbName.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.atxbName.PasswordChar = false;
            this.atxbName.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(232)))), ((int)(((byte)(224)))));
            this.atxbName.PlaceholderText = "Họ và tên";
            this.atxbName.RoundType = Banking.AControls.ATextboxUC.RoundStyles.Full;
            this.atxbName.Size = new System.Drawing.Size(350, 33);
            this.atxbName.TabIndex = 22;
            this.atxbName.textAlign = Banking.AControls.ATextboxUC.TextAlign.Left;
            this.atxbName.Texts = "";
            this.atxbName.UnderlinedStyle = false;
            // 
            // aPanel2
            // 
            this.aPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(180)))), ((int)(((byte)(110)))));
            this.aPanel2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(180)))), ((int)(((byte)(110)))));
            this.aPanel2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.aPanel2.BorderRadius = 10;
            this.aPanel2.BorderSize = 0;
            this.aPanel2.Controls.Add(this.atxbEmail);
            this.aPanel2.ForeColor = System.Drawing.Color.White;
            this.aPanel2.Location = new System.Drawing.Point(100, 265);
            this.aPanel2.Name = "aPanel2";
            this.aPanel2.RoundType = Banking.AControls.APanel.RoundStyles.Full;
            this.aPanel2.Size = new System.Drawing.Size(400, 40);
            this.aPanel2.TabIndex = 33;
            this.aPanel2.TextColor = System.Drawing.Color.White;
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
            this.atxbEmail.PlaceholderText = "Email";
            this.atxbEmail.RoundType = Banking.AControls.ATextboxUC.RoundStyles.Full;
            this.atxbEmail.Size = new System.Drawing.Size(350, 33);
            this.atxbEmail.TabIndex = 22;
            this.atxbEmail.textAlign = Banking.AControls.ATextboxUC.TextAlign.Left;
            this.atxbEmail.Texts = "";
            this.atxbEmail.UnderlinedStyle = false;
            // 
            // aPanel3
            // 
            this.aPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(180)))), ((int)(((byte)(110)))));
            this.aPanel3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(180)))), ((int)(((byte)(110)))));
            this.aPanel3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.aPanel3.BorderRadius = 10;
            this.aPanel3.BorderSize = 0;
            this.aPanel3.Controls.Add(this.atxbPhone);
            this.aPanel3.ForeColor = System.Drawing.Color.White;
            this.aPanel3.Location = new System.Drawing.Point(100, 315);
            this.aPanel3.Name = "aPanel3";
            this.aPanel3.RoundType = Banking.AControls.APanel.RoundStyles.Full;
            this.aPanel3.Size = new System.Drawing.Size(400, 40);
            this.aPanel3.TabIndex = 34;
            this.aPanel3.TextColor = System.Drawing.Color.White;
            // 
            // atxbPhone
            // 
            this.atxbPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(180)))), ((int)(((byte)(110)))));
            this.atxbPhone.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(180)))), ((int)(((byte)(110)))));
            this.atxbPhone.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(180)))), ((int)(((byte)(110)))));
            this.atxbPhone.BorderRadius = 0;
            this.atxbPhone.BorderSize = 2;
            this.atxbPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.atxbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.atxbPhone.ForeColor = System.Drawing.Color.White;
            this.atxbPhone.isFocused = false;
            this.atxbPhone.isPlaceholder = true;
            this.atxbPhone.Location = new System.Drawing.Point(19, 3);
            this.atxbPhone.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.atxbPhone.Multiline = false;
            this.atxbPhone.Name = "atxbPhone";
            this.atxbPhone.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.atxbPhone.PasswordChar = false;
            this.atxbPhone.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(232)))), ((int)(((byte)(224)))));
            this.atxbPhone.PlaceholderText = "Số điện thoại";
            this.atxbPhone.RoundType = Banking.AControls.ATextboxUC.RoundStyles.Full;
            this.atxbPhone.Size = new System.Drawing.Size(350, 33);
            this.atxbPhone.TabIndex = 22;
            this.atxbPhone.textAlign = Banking.AControls.ATextboxUC.TextAlign.Left;
            this.atxbPhone.Texts = "";
            this.atxbPhone.UnderlinedStyle = false;
            // 
            // aPanel4
            // 
            this.aPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(180)))), ((int)(((byte)(110)))));
            this.aPanel4.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(180)))), ((int)(((byte)(110)))));
            this.aPanel4.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.aPanel4.BorderRadius = 10;
            this.aPanel4.BorderSize = 0;
            this.aPanel4.Controls.Add(this.atxbPassword);
            this.aPanel4.Controls.Add(this.pibHideViewPassword);
            this.aPanel4.ForeColor = System.Drawing.Color.White;
            this.aPanel4.Location = new System.Drawing.Point(100, 365);
            this.aPanel4.Name = "aPanel4";
            this.aPanel4.RoundType = Banking.AControls.APanel.RoundStyles.Full;
            this.aPanel4.Size = new System.Drawing.Size(400, 40);
            this.aPanel4.TabIndex = 35;
            this.aPanel4.TextColor = System.Drawing.Color.White;
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
            this.atxbPassword.PlaceholderText = "Mật khẩu";
            this.atxbPassword.RoundType = Banking.AControls.ATextboxUC.RoundStyles.Full;
            this.atxbPassword.Size = new System.Drawing.Size(330, 33);
            this.atxbPassword.TabIndex = 29;
            this.atxbPassword.textAlign = Banking.AControls.ATextboxUC.TextAlign.Left;
            this.atxbPassword.Texts = "";
            this.atxbPassword.UnderlinedStyle = false;
            // 
            // pibHideViewPassword
            // 
            this.pibHideViewPassword.BackColor = System.Drawing.Color.Transparent;
            this.pibHideViewPassword.BackgroundImage = global::Banking.Properties.Resources.hide;
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
            // aPanel5
            // 
            this.aPanel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(180)))), ((int)(((byte)(110)))));
            this.aPanel5.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(180)))), ((int)(((byte)(110)))));
            this.aPanel5.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.aPanel5.BorderRadius = 10;
            this.aPanel5.BorderSize = 0;
            this.aPanel5.Controls.Add(this.atxbRePassword);
            this.aPanel5.Controls.Add(this.pibHideViewRePassword);
            this.aPanel5.ForeColor = System.Drawing.Color.White;
            this.aPanel5.Location = new System.Drawing.Point(100, 415);
            this.aPanel5.Name = "aPanel5";
            this.aPanel5.RoundType = Banking.AControls.APanel.RoundStyles.Full;
            this.aPanel5.Size = new System.Drawing.Size(400, 40);
            this.aPanel5.TabIndex = 36;
            this.aPanel5.TextColor = System.Drawing.Color.White;
            // 
            // atxbRePassword
            // 
            this.atxbRePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(180)))), ((int)(((byte)(110)))));
            this.atxbRePassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(180)))), ((int)(((byte)(110)))));
            this.atxbRePassword.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(180)))), ((int)(((byte)(110)))));
            this.atxbRePassword.BorderRadius = 0;
            this.atxbRePassword.BorderSize = 2;
            this.atxbRePassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.atxbRePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.atxbRePassword.ForeColor = System.Drawing.Color.White;
            this.atxbRePassword.isFocused = false;
            this.atxbRePassword.isPlaceholder = true;
            this.atxbRePassword.Location = new System.Drawing.Point(19, 3);
            this.atxbRePassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.atxbRePassword.Multiline = false;
            this.atxbRePassword.Name = "atxbRePassword";
            this.atxbRePassword.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.atxbRePassword.PasswordChar = true;
            this.atxbRePassword.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(232)))), ((int)(((byte)(224)))));
            this.atxbRePassword.PlaceholderText = "Nhập lại mật khẩu";
            this.atxbRePassword.RoundType = Banking.AControls.ATextboxUC.RoundStyles.Full;
            this.atxbRePassword.Size = new System.Drawing.Size(330, 33);
            this.atxbRePassword.TabIndex = 29;
            this.atxbRePassword.textAlign = Banking.AControls.ATextboxUC.TextAlign.Left;
            this.atxbRePassword.Texts = "";
            this.atxbRePassword.UnderlinedStyle = false;
            // 
            // pibHideViewRePassword
            // 
            this.pibHideViewRePassword.BackColor = System.Drawing.Color.Transparent;
            this.pibHideViewRePassword.BackgroundImage = global::Banking.Properties.Resources.hide;
            this.pibHideViewRePassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pibHideViewRePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pibHideViewRePassword.Location = new System.Drawing.Point(361, 9);
            this.pibHideViewRePassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pibHideViewRePassword.Name = "pibHideViewRePassword";
            this.pibHideViewRePassword.Size = new System.Drawing.Size(22, 22);
            this.pibHideViewRePassword.TabIndex = 25;
            this.pibHideViewRePassword.TabStop = false;
            this.pibHideViewRePassword.Click += new System.EventHandler(this.pibHideViewRePassword_Click);
            // 
            // aPanel6
            // 
            this.aPanel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(180)))), ((int)(((byte)(110)))));
            this.aPanel6.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(180)))), ((int)(((byte)(110)))));
            this.aPanel6.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.aPanel6.BorderRadius = 10;
            this.aPanel6.BorderSize = 0;
            this.aPanel6.Controls.Add(this.adpBirthday);
            this.aPanel6.Controls.Add(this.label1);
            this.aPanel6.ForeColor = System.Drawing.Color.White;
            this.aPanel6.Location = new System.Drawing.Point(100, 165);
            this.aPanel6.Name = "aPanel6";
            this.aPanel6.RoundType = Banking.AControls.APanel.RoundStyles.Full;
            this.aPanel6.Size = new System.Drawing.Size(400, 40);
            this.aPanel6.TabIndex = 37;
            this.aPanel6.TextColor = System.Drawing.Color.White;
            // 
            // adpBirthday
            // 
            this.adpBirthday.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(180)))), ((int)(((byte)(110)))));
            this.adpBirthday.BorderSize = 0;
            this.adpBirthday.CalendarForeColor = System.Drawing.Color.Black;
            this.adpBirthday.CalendarMonthBackground = System.Drawing.Color.Black;
            this.adpBirthday.CalendarTitleBackColor = System.Drawing.Color.Black;
            this.adpBirthday.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.adpBirthday.CustomFormat = "dd/MM/yyyy";
            this.adpBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.adpBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.adpBirthday.Location = new System.Drawing.Point(234, 1);
            this.adpBirthday.MinimumSize = new System.Drawing.Size(4, 30);
            this.adpBirthday.Name = "adpBirthday";
            this.adpBirthday.Size = new System.Drawing.Size(148, 30);
            this.adpBirthday.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(180)))), ((int)(((byte)(110)))));
            this.adpBirthday.TabIndex = 1;
            this.adpBirthday.TextColor = System.Drawing.Color.White;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ngày sinh";
            // 
            // rdMan
            // 
            this.rdMan.AutoSize = true;
            this.rdMan.Checked = true;
            this.rdMan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rdMan.Location = new System.Drawing.Point(255, 8);
            this.rdMan.Name = "rdMan";
            this.rdMan.Size = new System.Drawing.Size(65, 24);
            this.rdMan.TabIndex = 38;
            this.rdMan.TabStop = true;
            this.rdMan.Text = "Nam";
            this.rdMan.UseVisualStyleBackColor = true;
            // 
            // aPanel7
            // 
            this.aPanel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(180)))), ((int)(((byte)(110)))));
            this.aPanel7.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(180)))), ((int)(((byte)(110)))));
            this.aPanel7.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.aPanel7.BorderRadius = 10;
            this.aPanel7.BorderSize = 0;
            this.aPanel7.Controls.Add(this.rdWoman);
            this.aPanel7.Controls.Add(this.label3);
            this.aPanel7.Controls.Add(this.rdMan);
            this.aPanel7.ForeColor = System.Drawing.Color.White;
            this.aPanel7.Location = new System.Drawing.Point(100, 215);
            this.aPanel7.Name = "aPanel7";
            this.aPanel7.RoundType = Banking.AControls.APanel.RoundStyles.Full;
            this.aPanel7.Size = new System.Drawing.Size(400, 40);
            this.aPanel7.TabIndex = 39;
            this.aPanel7.TextColor = System.Drawing.Color.White;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(16, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Giới tính";
            // 
            // rdWoman
            // 
            this.rdWoman.AutoSize = true;
            this.rdWoman.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rdWoman.Location = new System.Drawing.Point(332, 8);
            this.rdWoman.Name = "rdWoman";
            this.rdWoman.Size = new System.Drawing.Size(51, 24);
            this.rdWoman.TabIndex = 39;
            this.rdWoman.Text = "Nữ";
            this.rdWoman.UseVisualStyleBackColor = true;
            // 
            // RegisterUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.aPanel7);
            this.Controls.Add(this.aPanel6);
            this.Controls.Add(this.aPanel5);
            this.Controls.Add(this.aPanel4);
            this.Controls.Add(this.aPanel3);
            this.Controls.Add(this.aPanel2);
            this.Controls.Add(this.aPanel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.abtnRegsiter);
            this.Controls.Add(this.lbLogin);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RegisterUC";
            this.Size = new System.Drawing.Size(600, 600);
            this.aPanel1.ResumeLayout(false);
            this.aPanel2.ResumeLayout(false);
            this.aPanel3.ResumeLayout(false);
            this.aPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pibHideViewPassword)).EndInit();
            this.aPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pibHideViewRePassword)).EndInit();
            this.aPanel6.ResumeLayout(false);
            this.aPanel6.PerformLayout();
            this.aPanel7.ResumeLayout(false);
            this.aPanel7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label4;
        private AControls.AButton abtnRegsiter;
        private Label lbLogin;
        private Label label2;
        private AControls.APanel aPanel1;
        private AControls.ATextboxUC atxbName;
        private AControls.APanel aPanel2;
        private AControls.ATextboxUC atxbEmail;
        private AControls.APanel aPanel3;
        private AControls.ATextboxUC atxbPhone;
        private AControls.APanel aPanel4;
        private AControls.ATextboxUC atxbPassword;
        private PictureBox pibHideViewPassword;
        private AControls.APanel aPanel5;
        private AControls.ATextboxUC atxbRePassword;
        private PictureBox pibHideViewRePassword;
        private AControls.APanel aPanel6;
        private AControls.ADateTimePicker adpBirthday;
        private Label label1;
        private RadioButton rdMan;
        private AControls.APanel aPanel7;
        private Label label3;
        private RadioButton rdWoman;
    }
}
