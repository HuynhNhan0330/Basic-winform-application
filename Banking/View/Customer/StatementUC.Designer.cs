namespace Banking
{
    partial class StatementUC
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
            this.pnMain = new System.Windows.Forms.Panel();
            this.abtnAll = new Banking.AControls.AButton();
            this.abtnSearch = new Banking.AControls.AButton();
            this.aDateTimePicker2 = new Banking.AControls.ADateTimePicker();
            this.aDateTimePicker1 = new Banking.AControls.ADateTimePicker();
            this.abtnOut = new Banking.AControls.AButton();
            this.abtnIn = new Banking.AControls.AButton();
            this.SuspendLayout();
            // 
            // pnMain
            // 
            this.pnMain.AutoScroll = true;
            this.pnMain.Location = new System.Drawing.Point(50, 139);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(496, 441);
            this.pnMain.TabIndex = 2;
            // 
            // abtnAll
            // 
            this.abtnAll.BackColor = System.Drawing.Color.Transparent;
            this.abtnAll.BackgroundColor = System.Drawing.Color.Transparent;
            this.abtnAll.BorderColor = System.Drawing.Color.Plum;
            this.abtnAll.BorderRadius = 0;
            this.abtnAll.BorderSize = 0;
            this.abtnAll.FlatAppearance.BorderSize = 0;
            this.abtnAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.abtnAll.Font = new System.Drawing.Font("Arial", 9.5F);
            this.abtnAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(93)))), ((int)(((byte)(56)))));
            this.abtnAll.LineType = Banking.AControls.AButton.LineStyles.Bottom;
            this.abtnAll.Location = new System.Drawing.Point(50, 80);
            this.abtnAll.Name = "abtnAll";
            this.abtnAll.RoundType = Banking.AControls.AButton.RoundStyles.Full;
            this.abtnAll.Size = new System.Drawing.Size(150, 35);
            this.abtnAll.TabIndex = 5;
            this.abtnAll.Text = "Toàn bộ";
            this.abtnAll.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(93)))), ((int)(((byte)(56)))));
            this.abtnAll.ThinknessLine = 5;
            this.abtnAll.UseVisualStyleBackColor = false;
            this.abtnAll.Click += new System.EventHandler(this.abtnAll_Click);
            // 
            // abtnSearch
            // 
            this.abtnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(180)))), ((int)(((byte)(110)))));
            this.abtnSearch.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(180)))), ((int)(((byte)(110)))));
            this.abtnSearch.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.abtnSearch.BorderRadius = 10;
            this.abtnSearch.BorderSize = 0;
            this.abtnSearch.FlatAppearance.BorderSize = 0;
            this.abtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.abtnSearch.Font = new System.Drawing.Font("Arial", 9.5F);
            this.abtnSearch.ForeColor = System.Drawing.Color.White;
            this.abtnSearch.LineType = Banking.AControls.AButton.LineStyles.None;
            this.abtnSearch.Location = new System.Drawing.Point(426, 25);
            this.abtnSearch.Name = "abtnSearch";
            this.abtnSearch.RoundType = Banking.AControls.AButton.RoundStyles.Full;
            this.abtnSearch.Size = new System.Drawing.Size(120, 35);
            this.abtnSearch.TabIndex = 3;
            this.abtnSearch.Text = "Tìm kiếm";
            this.abtnSearch.TextColor = System.Drawing.Color.White;
            this.abtnSearch.ThinknessLine = 0;
            this.abtnSearch.UseVisualStyleBackColor = false;
            // 
            // aDateTimePicker2
            // 
            this.aDateTimePicker2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(180)))), ((int)(((byte)(110)))));
            this.aDateTimePicker2.BorderSize = 2;
            this.aDateTimePicker2.CustomFormat = "dd/MM/yyyy";
            this.aDateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.aDateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.aDateTimePicker2.Location = new System.Drawing.Point(225, 25);
            this.aDateTimePicker2.MinimumSize = new System.Drawing.Size(4, 35);
            this.aDateTimePicker2.Name = "aDateTimePicker2";
            this.aDateTimePicker2.Size = new System.Drawing.Size(150, 35);
            this.aDateTimePicker2.SkinColor = System.Drawing.Color.Transparent;
            this.aDateTimePicker2.TabIndex = 1;
            this.aDateTimePicker2.TextColor = System.Drawing.Color.Black;
            // 
            // aDateTimePicker1
            // 
            this.aDateTimePicker1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(180)))), ((int)(((byte)(110)))));
            this.aDateTimePicker1.BorderSize = 2;
            this.aDateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.aDateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.aDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.aDateTimePicker1.Location = new System.Drawing.Point(50, 25);
            this.aDateTimePicker1.MinimumSize = new System.Drawing.Size(4, 35);
            this.aDateTimePicker1.Name = "aDateTimePicker1";
            this.aDateTimePicker1.Size = new System.Drawing.Size(150, 35);
            this.aDateTimePicker1.SkinColor = System.Drawing.Color.Transparent;
            this.aDateTimePicker1.TabIndex = 0;
            this.aDateTimePicker1.TextColor = System.Drawing.Color.Black;
            // 
            // abtnOut
            // 
            this.abtnOut.BackColor = System.Drawing.Color.Transparent;
            this.abtnOut.BackgroundColor = System.Drawing.Color.Transparent;
            this.abtnOut.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.abtnOut.BorderRadius = 0;
            this.abtnOut.BorderSize = 0;
            this.abtnOut.FlatAppearance.BorderSize = 0;
            this.abtnOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.abtnOut.Font = new System.Drawing.Font("Arial", 9.5F);
            this.abtnOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.abtnOut.LineType = Banking.AControls.AButton.LineStyles.None;
            this.abtnOut.Location = new System.Drawing.Point(225, 80);
            this.abtnOut.Name = "abtnOut";
            this.abtnOut.RoundType = Banking.AControls.AButton.RoundStyles.Full;
            this.abtnOut.Size = new System.Drawing.Size(150, 35);
            this.abtnOut.TabIndex = 6;
            this.abtnOut.Text = "Tiền ra";
            this.abtnOut.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.abtnOut.ThinknessLine = 5;
            this.abtnOut.UseVisualStyleBackColor = false;
            this.abtnOut.Click += new System.EventHandler(this.abtnOut_Click);
            // 
            // abtnIn
            // 
            this.abtnIn.BackColor = System.Drawing.Color.Transparent;
            this.abtnIn.BackgroundColor = System.Drawing.Color.Transparent;
            this.abtnIn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.abtnIn.BorderRadius = 0;
            this.abtnIn.BorderSize = 0;
            this.abtnIn.FlatAppearance.BorderSize = 0;
            this.abtnIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.abtnIn.Font = new System.Drawing.Font("Arial", 9.5F);
            this.abtnIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.abtnIn.LineType = Banking.AControls.AButton.LineStyles.None;
            this.abtnIn.Location = new System.Drawing.Point(396, 80);
            this.abtnIn.Name = "abtnIn";
            this.abtnIn.RoundType = Banking.AControls.AButton.RoundStyles.Full;
            this.abtnIn.Size = new System.Drawing.Size(150, 35);
            this.abtnIn.TabIndex = 7;
            this.abtnIn.Text = "Tiền vào";
            this.abtnIn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.abtnIn.ThinknessLine = 5;
            this.abtnIn.UseVisualStyleBackColor = false;
            this.abtnIn.Click += new System.EventHandler(this.abtnIn_Click);
            // 
            // StatementUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.abtnIn);
            this.Controls.Add(this.abtnOut);
            this.Controls.Add(this.abtnAll);
            this.Controls.Add(this.abtnSearch);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.aDateTimePicker2);
            this.Controls.Add(this.aDateTimePicker1);
            this.Name = "StatementUC";
            this.Size = new System.Drawing.Size(596, 605);
            this.Load += new System.EventHandler(this.StatementUC_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private AControls.ADateTimePicker aDateTimePicker1;
        private AControls.ADateTimePicker aDateTimePicker2;
        private System.Windows.Forms.Panel pnMain;
        private AControls.AButton abtnSearch;
        private AControls.AButton abtnAll;
        private AControls.AButton abtnOut;
        private AControls.AButton abtnIn;
    }
}
