namespace Banking
{
    partial class InvoiceSaveBookUC
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
            this.lbCreated = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbAccountNumber = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pibHome = new System.Windows.Forms.PictureBox();
            this.aPanel1 = new Banking.AControls.APanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbType = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbTern = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbMoney = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibHome)).BeginInit();
            this.aPanel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbCreated
            // 
            this.lbCreated.AutoSize = true;
            this.lbCreated.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbCreated.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lbCreated.Location = new System.Drawing.Point(248, 225);
            this.lbCreated.Name = "lbCreated";
            this.lbCreated.Size = new System.Drawing.Size(75, 20);
            this.lbCreated.TabIndex = 11;
            this.lbCreated.Text = "Ngày tạo";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Banking.Properties.Resources._checked;
            this.pictureBox1.Location = new System.Drawing.Point(248, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbName.Location = new System.Drawing.Point(498, 25);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(66, 20);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "lbName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(25, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên người thụ hưởng";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbName);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(596, 65);
            this.panel2.TabIndex = 4;
            // 
            // lbAccountNumber
            // 
            this.lbAccountNumber.AutoSize = true;
            this.lbAccountNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbAccountNumber.Location = new System.Drawing.Point(498, 15);
            this.lbAccountNumber.Name = "lbAccountNumber";
            this.lbAccountNumber.Size = new System.Drawing.Size(53, 20);
            this.lbAccountNumber.TabIndex = 1;
            this.lbAccountNumber.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(25, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(191, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tài khoản thụ hưởng";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbAccountNumber);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 65);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(596, 55);
            this.panel3.TabIndex = 5;
            // 
            // pibHome
            // 
            this.pibHome.BackgroundImage = global::Banking.Properties.Resources.house;
            this.pibHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pibHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pibHome.Location = new System.Drawing.Point(539, 25);
            this.pibHome.Name = "pibHome";
            this.pibHome.Size = new System.Drawing.Size(32, 32);
            this.pibHome.TabIndex = 12;
            this.pibHome.TabStop = false;
            this.pibHome.Click += new System.EventHandler(this.pibHome_Click);
            // 
            // aPanel1
            // 
            this.aPanel1.AutoScroll = true;
            this.aPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(208)))), ((int)(((byte)(130)))));
            this.aPanel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(208)))), ((int)(((byte)(130)))));
            this.aPanel1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.aPanel1.BorderRadius = 40;
            this.aPanel1.BorderSize = 0;
            this.aPanel1.Controls.Add(this.panel5);
            this.aPanel1.Controls.Add(this.panel1);
            this.aPanel1.Controls.Add(this.panel3);
            this.aPanel1.Controls.Add(this.panel2);
            this.aPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.aPanel1.ForeColor = System.Drawing.Color.Black;
            this.aPanel1.Location = new System.Drawing.Point(0, 275);
            this.aPanel1.Name = "aPanel1";
            this.aPanel1.RoundType = Banking.AControls.APanel.RoundStyles.Top;
            this.aPanel1.Size = new System.Drawing.Size(596, 330);
            this.aPanel1.TabIndex = 10;
            this.aPanel1.TextColor = System.Drawing.Color.Black;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lbType);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 175);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(596, 55);
            this.panel5.TabIndex = 8;
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbType.Location = new System.Drawing.Point(498, 15);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(53, 20);
            this.lbType.TabIndex = 1;
            this.lbType.Text = "label7";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(25, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Hình thức gửi";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbTern);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(596, 55);
            this.panel1.TabIndex = 7;
            // 
            // lbTern
            // 
            this.lbTern.AutoSize = true;
            this.lbTern.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbTern.Location = new System.Drawing.Point(498, 15);
            this.lbTern.Name = "lbTern";
            this.lbTern.Size = new System.Drawing.Size(53, 20);
            this.lbTern.TabIndex = 1;
            this.lbTern.Text = "label7";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(25, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Kỳ hạn gửi";
            // 
            // lbMoney
            // 
            this.lbMoney.AutoSize = true;
            this.lbMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbMoney.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(140)))), ((int)(((byte)(80)))));
            this.lbMoney.Location = new System.Drawing.Point(243, 190);
            this.lbMoney.Name = "lbMoney";
            this.lbMoney.Size = new System.Drawing.Size(88, 29);
            this.lbMoney.TabIndex = 9;
            this.lbMoney.Text = "Số tiền";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(68, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(460, 39);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tạo sổ tiết kiệm thành công";
            // 
            // InvoiceSaveBookUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lbCreated);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pibHome);
            this.Controls.Add(this.aPanel1);
            this.Controls.Add(this.lbMoney);
            this.Controls.Add(this.label1);
            this.Name = "InvoiceSaveBookUC";
            this.Size = new System.Drawing.Size(596, 605);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibHome)).EndInit();
            this.aPanel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCreated;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbAccountNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pibHome;
        private AControls.APanel aPanel1;
        private System.Windows.Forms.Label lbMoney;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbTern;
        private System.Windows.Forms.Label label4;
    }
}
