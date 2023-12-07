namespace Banking.Usercontrols
{
    partial class NotificationItemUC
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
            this.lbNote = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbNote
            // 
            this.lbNote.AutoSize = true;
            this.lbNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbNote.ForeColor = System.Drawing.Color.White;
            this.lbNote.Location = new System.Drawing.Point(25, 25);
            this.lbNote.MaximumSize = new System.Drawing.Size(440, 0);
            this.lbNote.Name = "lbNote";
            this.lbNote.Size = new System.Drawing.Size(53, 20);
            this.lbNote.TabIndex = 0;
            this.lbNote.Text = "label1";
            // 
            // NotificationItemUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(74)))), ((int)(((byte)(46)))));
            this.Controls.Add(this.lbNote);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "NotificationItemUC";
            this.Size = new System.Drawing.Size(440, 97);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNote;
    }
}
