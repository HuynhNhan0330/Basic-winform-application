namespace HouseWork
{
    partial class UCMessageUser
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
            this.lbText = new System.Windows.Forms.Label();
            this.pnuc = new System.Windows.Forms.Panel();
            this.pnuc.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbText
            // 
            this.lbText.AutoSize = true;
            this.lbText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(134)))), ((int)(((byte)(222)))));
            this.lbText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lbText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbText.ForeColor = System.Drawing.Color.White;
            this.lbText.Location = new System.Drawing.Point(30, 5);
            this.lbText.MaximumSize = new System.Drawing.Size(315, 0);
            this.lbText.Name = "lbText";
            this.lbText.Size = new System.Drawing.Size(306, 66);
            this.lbText.TabIndex = 2;
            this.lbText.Text = " This is a sample text message. This is a sample text message. This is a sample t" +
    "ext message. ";
            // 
            // pnuc
            // 
            this.pnuc.BackColor = System.Drawing.Color.Transparent;
            this.pnuc.Controls.Add(this.lbText);
            this.pnuc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnuc.Location = new System.Drawing.Point(0, 0);
            this.pnuc.Margin = new System.Windows.Forms.Padding(0);
            this.pnuc.Name = "pnuc";
            this.pnuc.Size = new System.Drawing.Size(350, 75);
            this.pnuc.TabIndex = 3;
            // 
            // UCMessageUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pnuc);
            this.Name = "UCMessageUser";
            this.Size = new System.Drawing.Size(350, 75);
            this.pnuc.ResumeLayout(false);
            this.pnuc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbText;
        private System.Windows.Forms.Panel pnuc;
    }
}
