namespace Banking
{
    partial class HomeUC
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
            this.aPanel1 = new Banking.AControls.APanel();
            this.lbDetailaAccount = new System.Windows.Forms.Label();
            this.lbAccountName = new System.Windows.Forms.Label();
            this.pibAvatar = new Banking.AControls.ACircularPictureBox();
            this.lbMoney = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnSaveBook = new System.Windows.Forms.Panel();
            this.aPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // aPanel1
            // 
            this.aPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(208)))), ((int)(((byte)(128)))));
            this.aPanel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(208)))), ((int)(((byte)(128)))));
            this.aPanel1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.aPanel1.BorderRadius = 20;
            this.aPanel1.BorderSize = 0;
            this.aPanel1.Controls.Add(this.lbDetailaAccount);
            this.aPanel1.Controls.Add(this.lbAccountName);
            this.aPanel1.Controls.Add(this.pibAvatar);
            this.aPanel1.Controls.Add(this.lbMoney);
            this.aPanel1.Controls.Add(this.lbName);
            this.aPanel1.ForeColor = System.Drawing.Color.White;
            this.aPanel1.Location = new System.Drawing.Point(50, 25);
            this.aPanel1.Name = "aPanel1";
            this.aPanel1.RoundType = Banking.AControls.APanel.RoundStyles.Full;
            this.aPanel1.Size = new System.Drawing.Size(496, 160);
            this.aPanel1.TabIndex = 0;
            this.aPanel1.TextColor = System.Drawing.Color.White;
            // 
            // lbDetailaAccount
            // 
            this.lbDetailaAccount.AutoSize = true;
            this.lbDetailaAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbDetailaAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic);
            this.lbDetailaAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(250)))), ((int)(((byte)(241)))));
            this.lbDetailaAccount.Location = new System.Drawing.Point(366, 130);
            this.lbDetailaAccount.Name = "lbDetailaAccount";
            this.lbDetailaAccount.Size = new System.Drawing.Size(98, 20);
            this.lbDetailaAccount.TabIndex = 4;
            this.lbDetailaAccount.Text = "Xem chi tiết";
            this.lbDetailaAccount.Click += new System.EventHandler(this.lbDetailaAccount_Click);
            // 
            // lbAccountName
            // 
            this.lbAccountName.AutoSize = true;
            this.lbAccountName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbAccountName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(250)))), ((int)(((byte)(241)))));
            this.lbAccountName.Location = new System.Drawing.Point(30, 70);
            this.lbAccountName.Name = "lbAccountName";
            this.lbAccountName.Size = new System.Drawing.Size(101, 20);
            this.lbAccountName.TabIndex = 3;
            this.lbAccountName.Text = "Số tài khoản";
            // 
            // pibAvatar
            // 
            this.pibAvatar.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.pibAvatar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(221)))), ((int)(((byte)(164)))));
            this.pibAvatar.BorderColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(74)))), ((int)(((byte)(46)))));
            this.pibAvatar.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.pibAvatar.BorderSize = 2;
            this.pibAvatar.GradientAngle = 50F;
            this.pibAvatar.Location = new System.Drawing.Point(366, 15);
            this.pibAvatar.Name = "pibAvatar";
            this.pibAvatar.Size = new System.Drawing.Size(100, 100);
            this.pibAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pibAvatar.TabIndex = 2;
            this.pibAvatar.TabStop = false;
            // 
            // lbMoney
            // 
            this.lbMoney.AutoSize = true;
            this.lbMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbMoney.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(250)))), ((int)(((byte)(241)))));
            this.lbMoney.Location = new System.Drawing.Point(30, 115);
            this.lbMoney.Name = "lbMoney";
            this.lbMoney.Size = new System.Drawing.Size(41, 20);
            this.lbMoney.TabIndex = 1;
            this.lbMoney.Text = "Tiền";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(250)))), ((int)(((byte)(241)))));
            this.lbName.Location = new System.Drawing.Point(30, 25);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(168, 20);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Huynh Mai Cao Nhan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(50, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(293, 29);
            this.label4.TabIndex = 1;
            this.label4.Text = "Danh sách sổ tiết kiệm";
            // 
            // pnSaveBook
            // 
            this.pnSaveBook.AutoScroll = true;
            this.pnSaveBook.Location = new System.Drawing.Point(50, 270);
            this.pnSaveBook.Name = "pnSaveBook";
            this.pnSaveBook.Size = new System.Drawing.Size(496, 310);
            this.pnSaveBook.TabIndex = 2;
            // 
            // HomeUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnSaveBook);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.aPanel1);
            this.Name = "HomeUC";
            this.Size = new System.Drawing.Size(596, 605);
            this.Load += new System.EventHandler(this.HomeUC_Load);
            this.aPanel1.ResumeLayout(false);
            this.aPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AControls.APanel aPanel1;
        private System.Windows.Forms.Label lbMoney;
        private System.Windows.Forms.Label lbName;
        private AControls.ACircularPictureBox pibAvatar;
        private System.Windows.Forms.Label lbAccountName;
        private System.Windows.Forms.Label lbDetailaAccount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnSaveBook;
    }
}
