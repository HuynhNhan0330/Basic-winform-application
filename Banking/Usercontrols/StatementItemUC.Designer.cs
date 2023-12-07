namespace Banking.Usercontrols
{
    partial class StatementItemUC
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
            this.pnLine = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbMoney = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.lbNote = new System.Windows.Forms.Label();
            this.pibType = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibType)).BeginInit();
            this.SuspendLayout();
            // 
            // pnLine
            // 
            this.pnLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(93)))), ((int)(((byte)(56)))));
            this.pnLine.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnLine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(93)))), ((int)(((byte)(56)))));
            this.pnLine.Location = new System.Drawing.Point(0, 97);
            this.pnLine.Name = "pnLine";
            this.pnLine.Size = new System.Drawing.Size(496, 3);
            this.pnLine.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbMoney);
            this.panel2.Controls.Add(this.lbTime);
            this.panel2.Controls.Add(this.lbNote);
            this.panel2.Controls.Add(this.pibType);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(496, 97);
            this.panel2.TabIndex = 5;
            // 
            // lbMoney
            // 
            this.lbMoney.AutoSize = true;
            this.lbMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbMoney.ForeColor = System.Drawing.Color.Black;
            this.lbMoney.Location = new System.Drawing.Point(411, 45);
            this.lbMoney.MaximumSize = new System.Drawing.Size(140, 0);
            this.lbMoney.Name = "lbMoney";
            this.lbMoney.Size = new System.Drawing.Size(53, 20);
            this.lbMoney.TabIndex = 7;
            this.lbMoney.Text = "label3";
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lbTime.Location = new System.Drawing.Point(80, 25);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(72, 17);
            this.lbTime.TabIndex = 6;
            this.lbTime.Text = "02/1/2003";
            // 
            // lbNote
            // 
            this.lbNote.AutoSize = true;
            this.lbNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbNote.ForeColor = System.Drawing.Color.Black;
            this.lbNote.Location = new System.Drawing.Point(80, 45);
            this.lbNote.MaximumSize = new System.Drawing.Size(235, 0);
            this.lbNote.Name = "lbNote";
            this.lbNote.Size = new System.Drawing.Size(44, 20);
            this.lbNote.TabIndex = 5;
            this.lbNote.Text = "Note";
            // 
            // pibType
            // 
            this.pibType.BackgroundImage = global::Banking.Properties.Resources.down_arrow;
            this.pibType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pibType.Location = new System.Drawing.Point(25, 25);
            this.pibType.Name = "pibType";
            this.pibType.Size = new System.Drawing.Size(40, 40);
            this.pibType.TabIndex = 4;
            this.pibType.TabStop = false;
            // 
            // StatementItemUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnLine);
            this.Name = "StatementItemUC";
            this.Size = new System.Drawing.Size(496, 100);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibType)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnLine;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbMoney;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label lbNote;
        private System.Windows.Forms.PictureBox pibType;
    }
}
