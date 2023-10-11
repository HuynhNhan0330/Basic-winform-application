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
            this.SuspendLayout();
            // 
            // lbText
            // 
            this.lbText.AutoSize = true;
            this.lbText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(215)))));
            this.lbText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lbText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(31)))));
            this.lbText.Location = new System.Drawing.Point(38, 3);
            this.lbText.MaximumSize = new System.Drawing.Size(315, 0);
            this.lbText.Name = "lbText";
            this.lbText.Padding = new System.Windows.Forms.Padding(3);
            this.lbText.Size = new System.Drawing.Size(312, 72);
            this.lbText.TabIndex = 2;
            this.lbText.Text = " This is a sample text message. This is a sample text message. This is a sample t" +
    "ext message. ";
            this.lbText.Paint += new System.Windows.Forms.PaintEventHandler(this.lbText_Paint);
            // 
            // UCMessageUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lbText);
            this.Name = "UCMessageUser";
            this.Size = new System.Drawing.Size(350, 75);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbText;
    }
}
