namespace Banking
{
    partial class InTransferMoneyUC
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
            this.abtnDone = new Banking.AControls.AButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.atxbNote = new Banking.AControls.ATextboxUC();
            this.label9 = new System.Windows.Forms.Label();
            this.lbReName = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.atxbMoney = new Banking.AControls.ATextboxUC();
            this.label7 = new System.Windows.Forms.Label();
            this.lbCurrentMoney = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.atxbReAccountNumber = new Banking.AControls.ATextboxUC();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.atxbAccountNumber = new Banking.AControls.ATextboxUC();
            this.label1 = new System.Windows.Forms.Label();
            this.pibReturn = new System.Windows.Forms.PictureBox();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibReturn)).BeginInit();
            this.SuspendLayout();
            // 
            // abtnDone
            // 
            this.abtnDone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(208)))), ((int)(((byte)(128)))));
            this.abtnDone.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(208)))), ((int)(((byte)(128)))));
            this.abtnDone.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.abtnDone.BorderRadius = 20;
            this.abtnDone.BorderSize = 0;
            this.abtnDone.FlatAppearance.BorderSize = 0;
            this.abtnDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.abtnDone.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abtnDone.ForeColor = System.Drawing.Color.White;
            this.abtnDone.LineType = Banking.AControls.AButton.LineStyles.None;
            this.abtnDone.Location = new System.Drawing.Point(75, 521);
            this.abtnDone.Name = "abtnDone";
            this.abtnDone.RoundType = Banking.AControls.AButton.RoundStyles.Full;
            this.abtnDone.Size = new System.Drawing.Size(446, 50);
            this.abtnDone.TabIndex = 21;
            this.abtnDone.Text = "Hoàn tất";
            this.abtnDone.TextColor = System.Drawing.Color.White;
            this.abtnDone.ThinknessLine = 0;
            this.abtnDone.UseVisualStyleBackColor = false;
            this.abtnDone.Click += new System.EventHandler(this.abtnDone_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.atxbNote);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Location = new System.Drawing.Point(50, 352);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(496, 37);
            this.panel5.TabIndex = 20;
            // 
            // atxbNote
            // 
            this.atxbNote.BackColor = System.Drawing.Color.White;
            this.atxbNote.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(180)))), ((int)(((byte)(110)))));
            this.atxbNote.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(180)))), ((int)(((byte)(110)))));
            this.atxbNote.BorderRadius = 10;
            this.atxbNote.BorderSize = 2;
            this.atxbNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.atxbNote.ForeColor = System.Drawing.Color.Black;
            this.atxbNote.isFocused = false;
            this.atxbNote.isPlaceholder = true;
            this.atxbNote.Location = new System.Drawing.Point(195, 0);
            this.atxbNote.Margin = new System.Windows.Forms.Padding(4);
            this.atxbNote.Multiline = false;
            this.atxbNote.Name = "atxbNote";
            this.atxbNote.Padding = new System.Windows.Forms.Padding(7);
            this.atxbNote.PasswordChar = false;
            this.atxbNote.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.atxbNote.PlaceholderText = "Nhập nội dung giao dịch";
            this.atxbNote.RoundType = Banking.AControls.ATextboxUC.RoundStyles.Full;
            this.atxbNote.Size = new System.Drawing.Size(300, 35);
            this.atxbNote.TabIndex = 1;
            this.atxbNote.textAlign = Banking.AControls.ATextboxUC.TextAlign.Left;
            this.atxbNote.Texts = "";
            this.atxbNote.UnderlinedStyle = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(0, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Nội dung giao dịch";
            // 
            // lbReName
            // 
            this.lbReName.AutoSize = true;
            this.lbReName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lbReName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(38)))), ((int)(((byte)(30)))));
            this.lbReName.Location = new System.Drawing.Point(510, 242);
            this.lbReName.Name = "lbReName";
            this.lbReName.Size = new System.Drawing.Size(33, 20);
            this.lbReName.TabIndex = 19;
            this.lbReName.Text = "XX";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.atxbMoney);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Location = new System.Drawing.Point(50, 292);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(496, 37);
            this.panel4.TabIndex = 18;
            // 
            // atxbMoney
            // 
            this.atxbMoney.BackColor = System.Drawing.Color.White;
            this.atxbMoney.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(180)))), ((int)(((byte)(110)))));
            this.atxbMoney.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(180)))), ((int)(((byte)(110)))));
            this.atxbMoney.BorderRadius = 10;
            this.atxbMoney.BorderSize = 2;
            this.atxbMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.atxbMoney.ForeColor = System.Drawing.Color.Black;
            this.atxbMoney.isFocused = false;
            this.atxbMoney.isPlaceholder = true;
            this.atxbMoney.Location = new System.Drawing.Point(195, 0);
            this.atxbMoney.Margin = new System.Windows.Forms.Padding(4);
            this.atxbMoney.Multiline = false;
            this.atxbMoney.Name = "atxbMoney";
            this.atxbMoney.Padding = new System.Windows.Forms.Padding(7);
            this.atxbMoney.PasswordChar = false;
            this.atxbMoney.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.atxbMoney.PlaceholderText = "Nhập số tiền";
            this.atxbMoney.RoundType = Banking.AControls.ATextboxUC.RoundStyles.Full;
            this.atxbMoney.Size = new System.Drawing.Size(300, 35);
            this.atxbMoney.TabIndex = 1;
            this.atxbMoney.textAlign = Banking.AControls.ATextboxUC.TextAlign.Left;
            this.atxbMoney.Texts = "";
            this.atxbMoney.UnderlinedStyle = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(0, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Số tiền giao dịch";
            // 
            // lbCurrentMoney
            // 
            this.lbCurrentMoney.AutoSize = true;
            this.lbCurrentMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbCurrentMoney.ForeColor = System.Drawing.Color.DimGray;
            this.lbCurrentMoney.Location = new System.Drawing.Point(485, 140);
            this.lbCurrentMoney.MaximumSize = new System.Drawing.Size(170, 0);
            this.lbCurrentMoney.Name = "lbCurrentMoney";
            this.lbCurrentMoney.Size = new System.Drawing.Size(59, 20);
            this.lbCurrentMoney.TabIndex = 17;
            this.lbCurrentMoney.Text = "1000 đ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(241, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Số dư khả dụng";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.atxbReAccountNumber);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(49, 192);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(496, 37);
            this.panel3.TabIndex = 15;
            // 
            // atxbReAccountNumber
            // 
            this.atxbReAccountNumber.BackColor = System.Drawing.Color.White;
            this.atxbReAccountNumber.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(180)))), ((int)(((byte)(110)))));
            this.atxbReAccountNumber.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(180)))), ((int)(((byte)(110)))));
            this.atxbReAccountNumber.BorderRadius = 10;
            this.atxbReAccountNumber.BorderSize = 2;
            this.atxbReAccountNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.atxbReAccountNumber.ForeColor = System.Drawing.Color.Black;
            this.atxbReAccountNumber.isFocused = false;
            this.atxbReAccountNumber.isPlaceholder = true;
            this.atxbReAccountNumber.Location = new System.Drawing.Point(195, 0);
            this.atxbReAccountNumber.Margin = new System.Windows.Forms.Padding(4);
            this.atxbReAccountNumber.Multiline = false;
            this.atxbReAccountNumber.Name = "atxbReAccountNumber";
            this.atxbReAccountNumber.Padding = new System.Windows.Forms.Padding(7);
            this.atxbReAccountNumber.PasswordChar = false;
            this.atxbReAccountNumber.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.atxbReAccountNumber.PlaceholderText = "Nhập số tài khoản";
            this.atxbReAccountNumber.RoundType = Banking.AControls.ATextboxUC.RoundStyles.Full;
            this.atxbReAccountNumber.Size = new System.Drawing.Size(300, 35);
            this.atxbReAccountNumber.TabIndex = 1;
            this.atxbReAccountNumber.textAlign = Banking.AControls.ATextboxUC.TextAlign.Left;
            this.atxbReAccountNumber.Texts = "";
            this.atxbReAccountNumber.UnderlinedStyle = false;
            this.atxbReAccountNumber._TextChanged += new System.EventHandler(this.atxbReAccountNumber__TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(0, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "STK thụ hưởng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(75, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(420, 39);
            this.label2.TabIndex = 13;
            this.label2.Text = "Chuyển tiền trong NBank";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.atxbAccountNumber);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(50, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(496, 37);
            this.panel1.TabIndex = 12;
            // 
            // atxbAccountNumber
            // 
            this.atxbAccountNumber.BackColor = System.Drawing.Color.White;
            this.atxbAccountNumber.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(180)))), ((int)(((byte)(110)))));
            this.atxbAccountNumber.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(180)))), ((int)(((byte)(110)))));
            this.atxbAccountNumber.BorderRadius = 10;
            this.atxbAccountNumber.BorderSize = 2;
            this.atxbAccountNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.atxbAccountNumber.ForeColor = System.Drawing.Color.Black;
            this.atxbAccountNumber.isFocused = false;
            this.atxbAccountNumber.isPlaceholder = false;
            this.atxbAccountNumber.Location = new System.Drawing.Point(195, 0);
            this.atxbAccountNumber.Margin = new System.Windows.Forms.Padding(4);
            this.atxbAccountNumber.Multiline = false;
            this.atxbAccountNumber.Name = "atxbAccountNumber";
            this.atxbAccountNumber.Padding = new System.Windows.Forms.Padding(7);
            this.atxbAccountNumber.PasswordChar = false;
            this.atxbAccountNumber.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.atxbAccountNumber.PlaceholderText = "";
            this.atxbAccountNumber.RoundType = Banking.AControls.ATextboxUC.RoundStyles.Full;
            this.atxbAccountNumber.Size = new System.Drawing.Size(300, 35);
            this.atxbAccountNumber.TabIndex = 1;
            this.atxbAccountNumber.textAlign = Banking.AControls.ATextboxUC.TextAlign.Left;
            this.atxbAccountNumber.Texts = "";
            this.atxbAccountNumber.UnderlinedStyle = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(0, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài khoản nguồn";
            // 
            // pibReturn
            // 
            this.pibReturn.BackgroundImage = global::Banking.Properties.Resources._return;
            this.pibReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pibReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pibReturn.Location = new System.Drawing.Point(25, 25);
            this.pibReturn.Name = "pibReturn";
            this.pibReturn.Size = new System.Drawing.Size(32, 32);
            this.pibReturn.TabIndex = 11;
            this.pibReturn.TabStop = false;
            this.pibReturn.Click += new System.EventHandler(this.pibReturn_Click);
            // 
            // InTransferMoneyUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.abtnDone);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.lbReName);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.lbCurrentMoney);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pibReturn);
            this.Name = "InTransferMoneyUC";
            this.Size = new System.Drawing.Size(596, 605);
            this.Load += new System.EventHandler(this.InTransferMoneyUC_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibReturn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AControls.AButton abtnDone;
        private System.Windows.Forms.Panel panel5;
        private AControls.ATextboxUC atxbNote;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbReName;
        private System.Windows.Forms.Panel panel4;
        private AControls.ATextboxUC atxbMoney;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbCurrentMoney;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private AControls.ATextboxUC atxbReAccountNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private AControls.ATextboxUC atxbAccountNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pibReturn;
    }
}
