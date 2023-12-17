namespace Banking
{
    partial class SaveUC
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
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.atxbMoney = new Banking.AControls.ATextboxUC();
            this.lbCurrentMoney = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.aPanel1 = new Banking.AControls.APanel();
            this.cbTern = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.atxbAccountNumber = new Banking.AControls.ATextboxUC();
            this.panel3 = new System.Windows.Forms.Panel();
            this.aPanel2 = new Banking.AControls.APanel();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.abtnDone = new Banking.AControls.AButton();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.aPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.aPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(0, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Số tiền gửi";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.atxbMoney);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Location = new System.Drawing.Point(50, 280);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(0, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Chọn kỳ hạn gửi";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.aPanel1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(50, 200);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(496, 37);
            this.panel2.TabIndex = 14;
            // 
            // aPanel1
            // 
            this.aPanel1.BackColor = System.Drawing.Color.White;
            this.aPanel1.BackgroundColor = System.Drawing.Color.White;
            this.aPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(180)))), ((int)(((byte)(110)))));
            this.aPanel1.BorderRadius = 10;
            this.aPanel1.BorderSize = 2;
            this.aPanel1.Controls.Add(this.cbTern);
            this.aPanel1.ForeColor = System.Drawing.Color.White;
            this.aPanel1.Location = new System.Drawing.Point(195, 0);
            this.aPanel1.Name = "aPanel1";
            this.aPanel1.RoundType = Banking.AControls.APanel.RoundStyles.Full;
            this.aPanel1.Size = new System.Drawing.Size(298, 37);
            this.aPanel1.TabIndex = 1;
            this.aPanel1.TextColor = System.Drawing.Color.White;
            // 
            // cbTern
            // 
            this.cbTern.AutoCompleteCustomSource.AddRange(new string[] {
            "Không kỳ hạn - 0.10%,",
            "7 ngày            - 0.20%",
            "14 ngày          - 0.20%",
            "1 tháng          - 3.10%",
            "2 tháng          - 3.10%",
            "3 tháng          - 3.40%",
            "6 tháng          - 4.00%",
            "9 tháng          - 4.00%",
            "12 tháng        - 5.50%",
            "24 tháng        - 5.50%",
            "36 tháng        - 5.50%",
            "48 tháng        - 5.50%",
            "60 tháng        - 5.50%"});
            this.cbTern.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbTern.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTern.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTern.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbTern.FormattingEnabled = true;
            this.cbTern.Items.AddRange(new object[] {
            "1 tháng - 12.00%",
            "2 tháng - 24.00%",
            "3 tháng - 36.00%",
            "4 tháng - 48.00%",
            "5 tháng - 60.00%"});
            this.cbTern.Location = new System.Drawing.Point(16, 4);
            this.cbTern.Name = "cbTern";
            this.cbTern.Size = new System.Drawing.Size(277, 28);
            this.cbTern.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(192, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 39);
            this.label2.TabIndex = 13;
            this.label2.Text = "Mở tiết kiệm";
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
            // panel3
            // 
            this.panel3.Controls.Add(this.aPanel2);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(50, 360);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(496, 37);
            this.panel3.TabIndex = 22;
            // 
            // aPanel2
            // 
            this.aPanel2.BackColor = System.Drawing.Color.White;
            this.aPanel2.BackgroundColor = System.Drawing.Color.White;
            this.aPanel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(180)))), ((int)(((byte)(110)))));
            this.aPanel2.BorderRadius = 10;
            this.aPanel2.BorderSize = 2;
            this.aPanel2.Controls.Add(this.cbType);
            this.aPanel2.ForeColor = System.Drawing.Color.White;
            this.aPanel2.Location = new System.Drawing.Point(195, 0);
            this.aPanel2.Name = "aPanel2";
            this.aPanel2.RoundType = Banking.AControls.APanel.RoundStyles.Full;
            this.aPanel2.Size = new System.Drawing.Size(298, 37);
            this.aPanel2.TabIndex = 1;
            this.aPanel2.TextColor = System.Drawing.Color.White;
            // 
            // cbType
            // 
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "Lãi vào tài khoản nguồn",
            "Lãi vào sổ tiết kiệm"});
            this.cbType.Location = new System.Drawing.Point(16, 4);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(277, 28);
            this.cbType.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(0, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Chọn hình thức gửi";
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
            // SaveUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.abtnDone);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.lbCurrentMoney);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "SaveUC";
            this.Size = new System.Drawing.Size(596, 605);
            this.Load += new System.EventHandler(this.saveUC_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.aPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.aPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AControls.AButton abtnDone;
        private AControls.ATextboxUC atxbMoney;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbCurrentMoney;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbTern;
        private AControls.APanel aPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private AControls.ATextboxUC atxbAccountNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private AControls.APanel aPanel2;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Label label4;
    }
}
