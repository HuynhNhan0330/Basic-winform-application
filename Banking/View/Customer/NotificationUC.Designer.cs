namespace Banking
{
    partial class NotificationUC
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
            this.abtnSeen = new Banking.AControls.AButton();
            this.abtnDontSeen = new Banking.AControls.AButton();
            this.abtnAll = new Banking.AControls.AButton();
            this.pnMain = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // abtnSeen
            // 
            this.abtnSeen.BackColor = System.Drawing.Color.Transparent;
            this.abtnSeen.BackgroundColor = System.Drawing.Color.Transparent;
            this.abtnSeen.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.abtnSeen.BorderRadius = 0;
            this.abtnSeen.BorderSize = 0;
            this.abtnSeen.FlatAppearance.BorderSize = 0;
            this.abtnSeen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.abtnSeen.Font = new System.Drawing.Font("Arial", 9.5F);
            this.abtnSeen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.abtnSeen.LineType = Banking.AControls.AButton.LineStyles.None;
            this.abtnSeen.Location = new System.Drawing.Point(396, 25);
            this.abtnSeen.Name = "abtnSeen";
            this.abtnSeen.RoundType = Banking.AControls.AButton.RoundStyles.Full;
            this.abtnSeen.Size = new System.Drawing.Size(150, 35);
            this.abtnSeen.TabIndex = 14;
            this.abtnSeen.Text = "Đã xem";
            this.abtnSeen.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.abtnSeen.ThinknessLine = 5;
            this.abtnSeen.UseVisualStyleBackColor = false;
            this.abtnSeen.Click += new System.EventHandler(this.abtnSeen_Click);
            // 
            // abtnDontSeen
            // 
            this.abtnDontSeen.BackColor = System.Drawing.Color.Transparent;
            this.abtnDontSeen.BackgroundColor = System.Drawing.Color.Transparent;
            this.abtnDontSeen.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.abtnDontSeen.BorderRadius = 0;
            this.abtnDontSeen.BorderSize = 0;
            this.abtnDontSeen.FlatAppearance.BorderSize = 0;
            this.abtnDontSeen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.abtnDontSeen.Font = new System.Drawing.Font("Arial", 9.5F);
            this.abtnDontSeen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.abtnDontSeen.LineType = Banking.AControls.AButton.LineStyles.None;
            this.abtnDontSeen.Location = new System.Drawing.Point(225, 25);
            this.abtnDontSeen.Name = "abtnDontSeen";
            this.abtnDontSeen.RoundType = Banking.AControls.AButton.RoundStyles.Full;
            this.abtnDontSeen.Size = new System.Drawing.Size(150, 35);
            this.abtnDontSeen.TabIndex = 13;
            this.abtnDontSeen.Text = "Chưa xem";
            this.abtnDontSeen.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.abtnDontSeen.ThinknessLine = 5;
            this.abtnDontSeen.UseVisualStyleBackColor = false;
            this.abtnDontSeen.Click += new System.EventHandler(this.abtnDontSeen_Click);
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
            this.abtnAll.Location = new System.Drawing.Point(50, 25);
            this.abtnAll.Name = "abtnAll";
            this.abtnAll.RoundType = Banking.AControls.AButton.RoundStyles.Full;
            this.abtnAll.Size = new System.Drawing.Size(150, 35);
            this.abtnAll.TabIndex = 12;
            this.abtnAll.Text = "Toàn bộ";
            this.abtnAll.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(93)))), ((int)(((byte)(56)))));
            this.abtnAll.ThinknessLine = 5;
            this.abtnAll.UseVisualStyleBackColor = false;
            this.abtnAll.Click += new System.EventHandler(this.abtnAll_Click);
            // 
            // pnMain
            // 
            this.pnMain.AutoScroll = true;
            this.pnMain.Location = new System.Drawing.Point(50, 80);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(496, 500);
            this.pnMain.TabIndex = 10;
            // 
            // NotificationUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.abtnSeen);
            this.Controls.Add(this.abtnDontSeen);
            this.Controls.Add(this.abtnAll);
            this.Controls.Add(this.pnMain);
            this.Name = "NotificationUC";
            this.Size = new System.Drawing.Size(596, 605);
            this.Load += new System.EventHandler(this.NotificationUC_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private AControls.AButton abtnSeen;
        private AControls.AButton abtnDontSeen;
        private AControls.AButton abtnAll;
        private System.Windows.Forms.Panel pnMain;
    }
}
