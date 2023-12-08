namespace Banking.Usercontrols
{
    partial class SaveBookItemUC
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
            this.lbMoney = new System.Windows.Forms.Label();
            this.lbTern = new System.Windows.Forms.Label();
            this.lbCreate = new System.Windows.Forms.Label();
            this.lbType = new System.Windows.Forms.Label();
            this.pibLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pibLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbMoney
            // 
            this.lbMoney.AutoSize = true;
            this.lbMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbMoney.Location = new System.Drawing.Point(25, 15);
            this.lbMoney.Name = "lbMoney";
            this.lbMoney.Size = new System.Drawing.Size(41, 20);
            this.lbMoney.TabIndex = 0;
            this.lbMoney.Text = "Tiền";
            // 
            // lbTern
            // 
            this.lbTern.AutoSize = true;
            this.lbTern.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbTern.Location = new System.Drawing.Point(25, 50);
            this.lbTern.Name = "lbTern";
            this.lbTern.Size = new System.Drawing.Size(81, 20);
            this.lbTern.TabIndex = 1;
            this.lbTern.Text = "Hình thức";
            // 
            // lbCreate
            // 
            this.lbCreate.AutoSize = true;
            this.lbCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbCreate.Location = new System.Drawing.Point(388, 85);
            this.lbCreate.Name = "lbCreate";
            this.lbCreate.Size = new System.Drawing.Size(75, 20);
            this.lbCreate.TabIndex = 2;
            this.lbCreate.Text = "Ngày tạo";
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbType.Location = new System.Drawing.Point(25, 85);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(41, 20);
            this.lbType.TabIndex = 3;
            this.lbType.Text = "Loại";
            // 
            // pibLogo
            // 
            this.pibLogo.Image = global::Banking.Properties.Resources.wallet;
            this.pibLogo.Location = new System.Drawing.Point(413, 15);
            this.pibLogo.Name = "pibLogo";
            this.pibLogo.Size = new System.Drawing.Size(50, 50);
            this.pibLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pibLogo.TabIndex = 4;
            this.pibLogo.TabStop = false;
            // 
            // SaveBookItemUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pibLogo);
            this.Controls.Add(this.lbType);
            this.Controls.Add(this.lbCreate);
            this.Controls.Add(this.lbTern);
            this.Controls.Add(this.lbMoney);
            this.Name = "SaveBookItemUC";
            this.Size = new System.Drawing.Size(496, 120);
            ((System.ComponentModel.ISupportInitialize)(this.pibLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMoney;
        private System.Windows.Forms.Label lbTern;
        private System.Windows.Forms.Label lbCreate;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.PictureBox pibLogo;
    }
}
