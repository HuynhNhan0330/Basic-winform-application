namespace Banking
{
    partial class FormMainCustomerWindown
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
            this.pnMenu = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.abtnHome = new Banking.AControls.AButton();
            this.abtnTransferMoney = new Banking.AControls.AButton();
            this.abtnStatement = new Banking.AControls.AButton();
            this.abtnSave = new Banking.AControls.AButton();
            this.abtnQRCode = new Banking.AControls.AButton();
            this.pnTop = new System.Windows.Forms.Panel();
            this.piNotification = new System.Windows.Forms.PictureBox();
            this.pibClose = new System.Windows.Forms.PictureBox();
            this.lbNameBank = new System.Windows.Forms.Label();
            this.pnMain = new System.Windows.Forms.Panel();
            this.pnMenu.SuspendLayout();
            this.pnTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.piNotification)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibClose)).BeginInit();
            this.SuspendLayout();
            // 
            // pnMenu
            // 
            this.pnMenu.BackColor = System.Drawing.Color.White;
            this.pnMenu.Controls.Add(this.panel2);
            this.pnMenu.Controls.Add(this.abtnHome);
            this.pnMenu.Controls.Add(this.abtnTransferMoney);
            this.pnMenu.Controls.Add(this.abtnStatement);
            this.pnMenu.Controls.Add(this.abtnSave);
            this.pnMenu.Controls.Add(this.abtnQRCode);
            this.pnMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnMenu.Location = new System.Drawing.Point(0, 705);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(596, 95);
            this.pnMenu.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(93)))), ((int)(((byte)(56)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.ForeColor = System.Drawing.Color.Blue;
            this.panel2.Location = new System.Drawing.Point(0, 90);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(596, 5);
            this.panel2.TabIndex = 0;
            // 
            // abtnHome
            // 
            this.abtnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(93)))), ((int)(((byte)(56)))));
            this.abtnHome.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(93)))), ((int)(((byte)(56)))));
            this.abtnHome.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(93)))), ((int)(((byte)(56)))));
            this.abtnHome.BorderRadius = 30;
            this.abtnHome.BorderSize = 0;
            this.abtnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.abtnHome.FlatAppearance.BorderSize = 0;
            this.abtnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.abtnHome.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abtnHome.ForeColor = System.Drawing.Color.White;
            this.abtnHome.Image = global::Banking.Properties.Resources.homeActive;
            this.abtnHome.LineType = Banking.AControls.AButton.LineStyles.None;
            this.abtnHome.Location = new System.Drawing.Point(-2, 1);
            this.abtnHome.Name = "abtnHome";
            this.abtnHome.RoundType = Banking.AControls.AButton.RoundStyles.Top;
            this.abtnHome.Size = new System.Drawing.Size(120, 90);
            this.abtnHome.TabIndex = 0;
            this.abtnHome.Text = "Trang chủ";
            this.abtnHome.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.abtnHome.TextColor = System.Drawing.Color.White;
            this.abtnHome.ThinknessLine = 0;
            this.abtnHome.UseVisualStyleBackColor = false;
            this.abtnHome.Click += new System.EventHandler(this.abtnHome_Click);
            // 
            // abtnTransferMoney
            // 
            this.abtnTransferMoney.BackColor = System.Drawing.Color.Transparent;
            this.abtnTransferMoney.BackgroundColor = System.Drawing.Color.Transparent;
            this.abtnTransferMoney.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(93)))), ((int)(((byte)(56)))));
            this.abtnTransferMoney.BorderRadius = 30;
            this.abtnTransferMoney.BorderSize = 0;
            this.abtnTransferMoney.Cursor = System.Windows.Forms.Cursors.Hand;
            this.abtnTransferMoney.FlatAppearance.BorderSize = 0;
            this.abtnTransferMoney.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.abtnTransferMoney.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abtnTransferMoney.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.abtnTransferMoney.Image = global::Banking.Properties.Resources.transferDeactive;
            this.abtnTransferMoney.LineType = Banking.AControls.AButton.LineStyles.None;
            this.abtnTransferMoney.Location = new System.Drawing.Point(118, 1);
            this.abtnTransferMoney.Name = "abtnTransferMoney";
            this.abtnTransferMoney.RoundType = Banking.AControls.AButton.RoundStyles.Top;
            this.abtnTransferMoney.Size = new System.Drawing.Size(120, 90);
            this.abtnTransferMoney.TabIndex = 4;
            this.abtnTransferMoney.Text = "Chuyển tiền";
            this.abtnTransferMoney.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.abtnTransferMoney.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.abtnTransferMoney.ThinknessLine = 0;
            this.abtnTransferMoney.UseVisualStyleBackColor = false;
            this.abtnTransferMoney.Click += new System.EventHandler(this.abtnTransferMoney_Click);
            // 
            // abtnStatement
            // 
            this.abtnStatement.BackColor = System.Drawing.Color.Transparent;
            this.abtnStatement.BackgroundColor = System.Drawing.Color.Transparent;
            this.abtnStatement.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(93)))), ((int)(((byte)(56)))));
            this.abtnStatement.BorderRadius = 30;
            this.abtnStatement.BorderSize = 0;
            this.abtnStatement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.abtnStatement.FlatAppearance.BorderSize = 0;
            this.abtnStatement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.abtnStatement.Font = new System.Drawing.Font("Arial", 9.5F);
            this.abtnStatement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.abtnStatement.Image = global::Banking.Properties.Resources.fileDeactive;
            this.abtnStatement.LineType = Banking.AControls.AButton.LineStyles.None;
            this.abtnStatement.Location = new System.Drawing.Point(478, 1);
            this.abtnStatement.Name = "abtnStatement";
            this.abtnStatement.RoundType = Banking.AControls.AButton.RoundStyles.Top;
            this.abtnStatement.Size = new System.Drawing.Size(120, 90);
            this.abtnStatement.TabIndex = 3;
            this.abtnStatement.Text = "Sao kê";
            this.abtnStatement.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.abtnStatement.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.abtnStatement.ThinknessLine = 0;
            this.abtnStatement.UseVisualStyleBackColor = false;
            this.abtnStatement.Click += new System.EventHandler(this.abtnStatement_Click);
            // 
            // abtnSave
            // 
            this.abtnSave.BackColor = System.Drawing.Color.Transparent;
            this.abtnSave.BackgroundColor = System.Drawing.Color.Transparent;
            this.abtnSave.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(93)))), ((int)(((byte)(56)))));
            this.abtnSave.BorderRadius = 30;
            this.abtnSave.BorderSize = 0;
            this.abtnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.abtnSave.FlatAppearance.BorderSize = 0;
            this.abtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.abtnSave.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abtnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.abtnSave.Image = global::Banking.Properties.Resources.saveMoneyDeactive;
            this.abtnSave.LineType = Banking.AControls.AButton.LineStyles.None;
            this.abtnSave.Location = new System.Drawing.Point(358, 1);
            this.abtnSave.Name = "abtnSave";
            this.abtnSave.RoundType = Banking.AControls.AButton.RoundStyles.Top;
            this.abtnSave.Size = new System.Drawing.Size(120, 90);
            this.abtnSave.TabIndex = 2;
            this.abtnSave.Text = "Mở tiết kiệm";
            this.abtnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.abtnSave.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.abtnSave.ThinknessLine = 0;
            this.abtnSave.UseVisualStyleBackColor = false;
            this.abtnSave.Click += new System.EventHandler(this.abtnSave_Click);
            // 
            // abtnQRCode
            // 
            this.abtnQRCode.BackColor = System.Drawing.Color.Transparent;
            this.abtnQRCode.BackgroundColor = System.Drawing.Color.Transparent;
            this.abtnQRCode.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(93)))), ((int)(((byte)(56)))));
            this.abtnQRCode.BorderRadius = 30;
            this.abtnQRCode.BorderSize = 0;
            this.abtnQRCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.abtnQRCode.FlatAppearance.BorderSize = 0;
            this.abtnQRCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.abtnQRCode.Font = new System.Drawing.Font("Arial", 9.5F);
            this.abtnQRCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.abtnQRCode.Image = global::Banking.Properties.Resources.qrCodeDeactive;
            this.abtnQRCode.LineType = Banking.AControls.AButton.LineStyles.None;
            this.abtnQRCode.Location = new System.Drawing.Point(238, 1);
            this.abtnQRCode.Name = "abtnQRCode";
            this.abtnQRCode.RoundType = Banking.AControls.AButton.RoundStyles.Top;
            this.abtnQRCode.Size = new System.Drawing.Size(120, 90);
            this.abtnQRCode.TabIndex = 1;
            this.abtnQRCode.Text = "QR code";
            this.abtnQRCode.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.abtnQRCode.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.abtnQRCode.ThinknessLine = 0;
            this.abtnQRCode.UseVisualStyleBackColor = false;
            this.abtnQRCode.Click += new System.EventHandler(this.abtnQRCode_Click);
            // 
            // pnTop
            // 
            this.pnTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(93)))), ((int)(((byte)(56)))));
            this.pnTop.Controls.Add(this.piNotification);
            this.pnTop.Controls.Add(this.pibClose);
            this.pnTop.Controls.Add(this.lbNameBank);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(596, 100);
            this.pnTop.TabIndex = 1;
            // 
            // piNotification
            // 
            this.piNotification.BackgroundImage = global::Banking.Properties.Resources.notification_bell;
            this.piNotification.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.piNotification.Cursor = System.Windows.Forms.Cursors.Hand;
            this.piNotification.Location = new System.Drawing.Point(540, 34);
            this.piNotification.Name = "piNotification";
            this.piNotification.Size = new System.Drawing.Size(32, 32);
            this.piNotification.TabIndex = 2;
            this.piNotification.TabStop = false;
            this.piNotification.Click += new System.EventHandler(this.piNotification_Click);
            // 
            // pibClose
            // 
            this.pibClose.BackgroundImage = global::Banking.Properties.Resources.log_out;
            this.pibClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pibClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pibClose.Location = new System.Drawing.Point(25, 34);
            this.pibClose.Name = "pibClose";
            this.pibClose.Size = new System.Drawing.Size(32, 32);
            this.pibClose.TabIndex = 1;
            this.pibClose.TabStop = false;
            this.pibClose.Click += new System.EventHandler(this.pibClose_Click);
            // 
            // lbNameBank
            // 
            this.lbNameBank.AutoSize = true;
            this.lbNameBank.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.lbNameBank.ForeColor = System.Drawing.Color.White;
            this.lbNameBank.Location = new System.Drawing.Point(236, 30);
            this.lbNameBank.Name = "lbNameBank";
            this.lbNameBank.Size = new System.Drawing.Size(125, 39);
            this.lbNameBank.TabIndex = 0;
            this.lbNameBank.Text = "NBank";
            // 
            // pnMain
            // 
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(0, 100);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(596, 605);
            this.pnMain.TabIndex = 2;
            // 
            // FormMainCustomerWindown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(596, 800);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.pnTop);
            this.Controls.Add(this.pnMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMainCustomerWindown";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMainWindown";
            this.Load += new System.EventHandler(this.FormMainCustomerWindown_Load);
            this.pnMenu.ResumeLayout(false);
            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.piNotification)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnMenu;
        private AControls.AButton abtnHome;
        private System.Windows.Forms.Panel panel2;
        private AControls.AButton abtnTransferMoney;
        private AControls.AButton abtnStatement;
        private AControls.AButton abtnSave;
        private AControls.AButton abtnQRCode;
        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.Label lbNameBank;
        private System.Windows.Forms.PictureBox pibClose;
        private System.Windows.Forms.PictureBox piNotification;
        private System.Windows.Forms.Panel pnMain;
    }
}