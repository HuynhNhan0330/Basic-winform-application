using System.Drawing;
using System.Windows.Forms;

namespace HouseWork
{
    partial class FrmHomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHomePage));
            this.pnLeftMenu = new System.Windows.Forms.Panel();
            this.btnrDiscount = new HouseWork.RoundedButtonMenu();
            this.btnrContact = new HouseWork.RoundedButtonMenu();
            this.btnrService = new HouseWork.RoundedButtonMenu();
            this.btnrHome = new HouseWork.RoundedButtonMenu();
            this.pnMenu = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pnRightMenu = new System.Windows.Forms.Panel();
            this.btnrRegister = new HouseWork.RoundedButtonMenu();
            this.btnrLogin = new HouseWork.RoundedButtonMenu();
            this.btnrLogout = new HouseWork.RoundedButtonMenu();
            this.btnrAccount = new HouseWork.RoundedButtonMenu();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pnMain = new System.Windows.Forms.Panel();
            this.IcClose = new System.Windows.Forms.PictureBox();
            this.roundedUC1 = new HouseWork.RoundedButtonMenu();
            this.pnLeftMenu.SuspendLayout();
            this.pnMenu.SuspendLayout();
            this.pnRightMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IcClose)).BeginInit();
            this.SuspendLayout();
            // 
            // pnLeftMenu
            // 
            this.pnLeftMenu.Controls.Add(this.btnrDiscount);
            this.pnLeftMenu.Controls.Add(this.btnrContact);
            this.pnLeftMenu.Controls.Add(this.btnrService);
            this.pnLeftMenu.Controls.Add(this.btnrHome);
            this.pnLeftMenu.Location = new System.Drawing.Point(220, 125);
            this.pnLeftMenu.Name = "pnLeftMenu";
            this.pnLeftMenu.Size = new System.Drawing.Size(615, 100);
            this.pnLeftMenu.TabIndex = 0;
            // 
            // btnrDiscount
            // 
            this.btnrDiscount.BackColor = System.Drawing.Color.Transparent;
            this.btnrDiscount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnrDiscount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(31)))));
            this.btnrDiscount.img = ((System.Drawing.Image)(resources.GetObject("btnrDiscount.img")));
            this.btnrDiscount.Location = new System.Drawing.Point(465, 0);
            this.btnrDiscount.Name = "btnrDiscount";
            this.btnrDiscount.Size = new System.Drawing.Size(150, 100);
            this.btnrDiscount.TabIndex = 8;
            this.btnrDiscount.TabStop = false;
            this.btnrDiscount.text = "Home";
            this.btnrDiscount.Click += new System.EventHandler(this.btnrDiscount_Click);
            // 
            // btnrContact
            // 
            this.btnrContact.BackColor = System.Drawing.Color.Transparent;
            this.btnrContact.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnrContact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(31)))));
            this.btnrContact.img = ((System.Drawing.Image)(resources.GetObject("btnrContact.img")));
            this.btnrContact.Location = new System.Drawing.Point(310, 0);
            this.btnrContact.Name = "btnrContact";
            this.btnrContact.Size = new System.Drawing.Size(150, 100);
            this.btnrContact.TabIndex = 7;
            this.btnrContact.TabStop = false;
            this.btnrContact.text = "Home";
            this.btnrContact.Click += new System.EventHandler(this.btnrContact_Click);
            // 
            // btnrService
            // 
            this.btnrService.BackColor = System.Drawing.Color.Transparent;
            this.btnrService.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnrService.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(31)))));
            this.btnrService.img = ((System.Drawing.Image)(resources.GetObject("btnrService.img")));
            this.btnrService.Location = new System.Drawing.Point(155, 0);
            this.btnrService.Name = "btnrService";
            this.btnrService.Size = new System.Drawing.Size(150, 100);
            this.btnrService.TabIndex = 6;
            this.btnrService.TabStop = false;
            this.btnrService.text = "Home";
            this.btnrService.Click += new System.EventHandler(this.btnrService_Click);
            // 
            // btnrHome
            // 
            this.btnrHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(238)))), ((int)(((byte)(253)))));
            this.btnrHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnrHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(53)))), ((int)(((byte)(91)))));
            this.btnrHome.img = ((System.Drawing.Image)(resources.GetObject("btnrHome.img")));
            this.btnrHome.Location = new System.Drawing.Point(0, 0);
            this.btnrHome.Name = "btnrHome";
            this.btnrHome.Size = new System.Drawing.Size(150, 100);
            this.btnrHome.TabIndex = 5;
            this.btnrHome.TabStop = false;
            this.btnrHome.text = "Home";
            this.btnrHome.Click += new System.EventHandler(this.btnrHome_Click);
            // 
            // pnMenu
            // 
            this.pnMenu.Controls.Add(this.label5);
            this.pnMenu.Controls.Add(this.pnRightMenu);
            this.pnMenu.Controls.Add(this.pictureBox9);
            this.pnMenu.Controls.Add(this.pnLeftMenu);
            this.pnMenu.Location = new System.Drawing.Point(100, 25);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(1300, 225);
            this.pnMenu.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 33F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(220, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(335, 63);
            this.label5.TabIndex = 4;
            this.label5.Text = "HomeMaket";
            // 
            // pnRightMenu
            // 
            this.pnRightMenu.Controls.Add(this.btnrRegister);
            this.pnRightMenu.Controls.Add(this.btnrLogin);
            this.pnRightMenu.Controls.Add(this.btnrLogout);
            this.pnRightMenu.Controls.Add(this.btnrAccount);
            this.pnRightMenu.Location = new System.Drawing.Point(995, 125);
            this.pnRightMenu.Name = "pnRightMenu";
            this.pnRightMenu.Size = new System.Drawing.Size(305, 100);
            this.pnRightMenu.TabIndex = 1;
            // 
            // btnrRegister
            // 
            this.btnrRegister.BackColor = System.Drawing.Color.Transparent;
            this.btnrRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnrRegister.ForeColor = System.Drawing.Color.Black;
            this.btnrRegister.img = global::HouseWork.Properties.Resources.RegisterIcon;
            this.btnrRegister.Location = new System.Drawing.Point(155, 0);
            this.btnrRegister.Name = "btnrRegister";
            this.btnrRegister.Size = new System.Drawing.Size(150, 100);
            this.btnrRegister.TabIndex = 10;
            this.btnrRegister.TabStop = false;
            this.btnrRegister.text = "Đăng ký";
            this.btnrRegister.Click += new System.EventHandler(this.btnrRegister_Click);
            // 
            // btnrLogin
            // 
            this.btnrLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnrLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnrLogin.ForeColor = System.Drawing.Color.Black;
            this.btnrLogin.img = global::HouseWork.Properties.Resources.LoginIcon2;
            this.btnrLogin.Location = new System.Drawing.Point(0, 0);
            this.btnrLogin.Name = "btnrLogin";
            this.btnrLogin.Size = new System.Drawing.Size(150, 100);
            this.btnrLogin.TabIndex = 10;
            this.btnrLogin.TabStop = false;
            this.btnrLogin.text = "Đăng nhập";
            this.btnrLogin.Click += new System.EventHandler(this.btnrLogin_Click);
            // 
            // btnrLogout
            // 
            this.btnrLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnrLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnrLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(31)))));
            this.btnrLogout.img = ((System.Drawing.Image)(resources.GetObject("btnrLogout.img")));
            this.btnrLogout.Location = new System.Drawing.Point(155, 0);
            this.btnrLogout.Name = "btnrLogout";
            this.btnrLogout.Size = new System.Drawing.Size(150, 100);
            this.btnrLogout.TabIndex = 10;
            this.btnrLogout.TabStop = false;
            this.btnrLogout.text = "Home";
            this.btnrLogout.Click += new System.EventHandler(this.btnrLogout_Click);
            // 
            // btnrAccount
            // 
            this.btnrAccount.BackColor = System.Drawing.Color.Transparent;
            this.btnrAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnrAccount.ForeColor = System.Drawing.Color.Black;
            this.btnrAccount.img = ((System.Drawing.Image)(resources.GetObject("btnrAccount.img")));
            this.btnrAccount.Location = new System.Drawing.Point(0, 0);
            this.btnrAccount.Name = "btnrAccount";
            this.btnrAccount.Size = new System.Drawing.Size(150, 100);
            this.btnrAccount.TabIndex = 9;
            this.btnrAccount.TabStop = false;
            this.btnrAccount.text = "Home";
            this.btnrAccount.Click += new System.EventHandler(this.btnrAccount_Click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox9.BackgroundImage = global::HouseWork.Properties.Resources.LogoHome;
            this.pictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox9.Location = new System.Drawing.Point(0, 0);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(200, 190);
            this.pictureBox9.TabIndex = 3;
            this.pictureBox9.TabStop = false;
            // 
            // pnMain
            // 
            this.pnMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(238)))), ((int)(((byte)(253)))));
            this.pnMain.Location = new System.Drawing.Point(0, 250);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(1500, 600);
            this.pnMain.TabIndex = 4;
            // 
            // IcClose
            // 
            this.IcClose.BackColor = System.Drawing.Color.Transparent;
            this.IcClose.BackgroundImage = global::HouseWork.Properties.Resources.CloseIcon2;
            this.IcClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.IcClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IcClose.Location = new System.Drawing.Point(1456, 12);
            this.IcClose.Name = "IcClose";
            this.IcClose.Size = new System.Drawing.Size(32, 32);
            this.IcClose.TabIndex = 2;
            this.IcClose.TabStop = false;
            this.IcClose.Click += new System.EventHandler(this.IcClose_Click);
            // 
            // roundedUC1
            // 
            this.roundedUC1.BackColor = System.Drawing.Color.White;
            this.roundedUC1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundedUC1.ForeColor = System.Drawing.Color.White;
            this.roundedUC1.img = ((System.Drawing.Image)(resources.GetObject("roundedUC1.img")));
            this.roundedUC1.Location = new System.Drawing.Point(218, 3);
            this.roundedUC1.Name = "roundedUC1";
            this.roundedUC1.Size = new System.Drawing.Size(150, 100);
            this.roundedUC1.TabIndex = 5;
            this.roundedUC1.text = "Home";
            // 
            // FrmHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(215)))));
            this.ClientSize = new System.Drawing.Size(1500, 850);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.IcClose);
            this.Controls.Add(this.pnMenu);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(31)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmHomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmHomePage_Load);
            this.pnLeftMenu.ResumeLayout(false);
            this.pnMenu.ResumeLayout(false);
            this.pnMenu.PerformLayout();
            this.pnRightMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IcClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnLeftMenu;
        private System.Windows.Forms.Panel pnMenu;
        private System.Windows.Forms.PictureBox IcClose;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Panel pnMain;
        private RoundedButtonMenu roundedUC1;
        private RoundedButtonMenu btnrHome;
        private RoundedButtonMenu btnrService;
        private System.Windows.Forms.Label label5;
        private RoundedButtonMenu btnrDiscount;
        private RoundedButtonMenu btnrContact;
        private RoundedButtonMenu btnrAccount;
        private RoundedButtonMenu btnrLogout;
        private System.Windows.Forms.Panel pnRightMenu;
        private RoundedButtonMenu btnrLogin;
        private RoundedButtonMenu btnrRegister;
    }
}

