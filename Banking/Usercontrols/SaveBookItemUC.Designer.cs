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
            this.lbNewMoney = new System.Windows.Forms.Label();
            this.lbDuKien = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbMoney
            // 
            this.lbMoney.AutoSize = true;
            this.lbMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbMoney.ForeColor = System.Drawing.Color.Black;
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
            this.lbTern.ForeColor = System.Drawing.Color.Black;
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
            this.lbCreate.ForeColor = System.Drawing.Color.Black;
            this.lbCreate.Location = new System.Drawing.Point(304, 50);
            this.lbCreate.Name = "lbCreate";
            this.lbCreate.Size = new System.Drawing.Size(85, 20);
            this.lbCreate.TabIndex = 2;
            this.lbCreate.Text = "Ngày tạo: ";
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbType.ForeColor = System.Drawing.Color.Black;
            this.lbType.Location = new System.Drawing.Point(25, 85);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(41, 20);
            this.lbType.TabIndex = 3;
            this.lbType.Text = "Loại";
            // 
            // lbNewMoney
            // 
            this.lbNewMoney.AutoSize = true;
            this.lbNewMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbNewMoney.ForeColor = System.Drawing.Color.Black;
            this.lbNewMoney.Location = new System.Drawing.Point(304, 15);
            this.lbNewMoney.Name = "lbNewMoney";
            this.lbNewMoney.Size = new System.Drawing.Size(133, 20);
            this.lbNewMoney.TabIndex = 4;
            this.lbNewMoney.Text = "Tiền nhận được: ";
            // 
            // lbDuKien
            // 
            this.lbDuKien.AutoSize = true;
            this.lbDuKien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbDuKien.ForeColor = System.Drawing.Color.Black;
            this.lbDuKien.Location = new System.Drawing.Point(304, 85);
            this.lbDuKien.Name = "lbDuKien";
            this.lbDuKien.Size = new System.Drawing.Size(115, 20);
            this.lbDuKien.TabIndex = 5;
            this.lbDuKien.Text = "Ngày dự kiến: ";
            // 
            // SaveBookItemUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lbDuKien);
            this.Controls.Add(this.lbNewMoney);
            this.Controls.Add(this.lbType);
            this.Controls.Add(this.lbCreate);
            this.Controls.Add(this.lbTern);
            this.Controls.Add(this.lbMoney);
            this.Name = "SaveBookItemUC";
            this.Size = new System.Drawing.Size(496, 120);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMoney;
        private System.Windows.Forms.Label lbTern;
        private System.Windows.Forms.Label lbCreate;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.Label lbNewMoney;
        private System.Windows.Forms.Label lbDuKien;
    }
}
