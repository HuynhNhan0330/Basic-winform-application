namespace Banking
{
    partial class TransferMoneyUC
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.abtnOut = new Banking.AControls.AButton();
            this.aButton1 = new Banking.AControls.AButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Banking.Properties.Resources.Finance_Customizable_Isometric_Illustrations___Amico_Style;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(50, 219);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(496, 361);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // abtnOut
            // 
            this.abtnOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(208)))), ((int)(((byte)(128)))));
            this.abtnOut.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(208)))), ((int)(((byte)(128)))));
            this.abtnOut.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.abtnOut.BorderRadius = 30;
            this.abtnOut.BorderSize = 0;
            this.abtnOut.FlatAppearance.BorderSize = 0;
            this.abtnOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.abtnOut.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abtnOut.ForeColor = System.Drawing.Color.White;
            this.abtnOut.LineType = Banking.AControls.AButton.LineStyles.None;
            this.abtnOut.Location = new System.Drawing.Point(50, 120);
            this.abtnOut.Name = "abtnOut";
            this.abtnOut.RoundType = Banking.AControls.AButton.RoundStyles.Right;
            this.abtnOut.Size = new System.Drawing.Size(496, 70);
            this.abtnOut.TabIndex = 1;
            this.abtnOut.Text = "XX Chuyển tiền ngoài hệ thống";
            this.abtnOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.abtnOut.TextColor = System.Drawing.Color.White;
            this.abtnOut.ThinknessLine = 0;
            this.abtnOut.UseVisualStyleBackColor = false;
            this.abtnOut.Click += new System.EventHandler(this.abtnOut_Click);
            // 
            // aButton1
            // 
            this.aButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(208)))), ((int)(((byte)(128)))));
            this.aButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(208)))), ((int)(((byte)(128)))));
            this.aButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.aButton1.BorderRadius = 30;
            this.aButton1.BorderSize = 0;
            this.aButton1.FlatAppearance.BorderSize = 0;
            this.aButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aButton1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aButton1.ForeColor = System.Drawing.Color.White;
            this.aButton1.LineType = Banking.AControls.AButton.LineStyles.None;
            this.aButton1.Location = new System.Drawing.Point(50, 25);
            this.aButton1.Name = "aButton1";
            this.aButton1.RoundType = Banking.AControls.AButton.RoundStyles.Right;
            this.aButton1.Size = new System.Drawing.Size(496, 70);
            this.aButton1.TabIndex = 0;
            this.aButton1.Text = "XX Chuyển tiền trong hệ thống";
            this.aButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.aButton1.TextColor = System.Drawing.Color.White;
            this.aButton1.ThinknessLine = 0;
            this.aButton1.UseVisualStyleBackColor = false;
            this.aButton1.Click += new System.EventHandler(this.aButton1_Click);
            // 
            // TransferMoneyUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.abtnOut);
            this.Controls.Add(this.aButton1);
            this.Name = "TransferMoneyUC";
            this.Size = new System.Drawing.Size(596, 605);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AControls.AButton aButton1;
        private AControls.AButton abtnOut;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
