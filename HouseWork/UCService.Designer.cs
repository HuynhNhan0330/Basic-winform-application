namespace HouseWork
{
    partial class UCService
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCService));
            this.pnMenuService = new System.Windows.Forms.Panel();
            this.btnrCook = new HouseWork.RoundedButtonService();
            this.btnrWash = new HouseWork.RoundedButtonService();
            this.pnMainService = new System.Windows.Forms.Panel();
            this.btnCal = new System.Windows.Forms.Button();
            this.btnrClean = new HouseWork.RoundedButtonService();
            this.pnMenuService.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnMenuService
            // 
            this.pnMenuService.Controls.Add(this.btnrClean);
            this.pnMenuService.Controls.Add(this.btnrCook);
            this.pnMenuService.Controls.Add(this.btnrWash);
            this.pnMenuService.Location = new System.Drawing.Point(100, 50);
            this.pnMenuService.Name = "pnMenuService";
            this.pnMenuService.Size = new System.Drawing.Size(150, 430);
            this.pnMenuService.TabIndex = 0;
            // 
            // btnrCook
            // 
            this.btnrCook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(215)))));
            this.btnrCook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnrCook.img = ((System.Drawing.Image)(resources.GetObject("btnrCook.img")));
            this.btnrCook.Location = new System.Drawing.Point(0, 150);
            this.btnrCook.Name = "btnrCook";
            this.btnrCook.Size = new System.Drawing.Size(150, 130);
            this.btnrCook.TabIndex = 3;
            this.btnrCook.text = "Dọn vệ sinh";
            this.btnrCook.Click += new System.EventHandler(this.btnrCook_Click);
            // 
            // btnrWash
            // 
            this.btnrWash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(215)))));
            this.btnrWash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnrWash.img = ((System.Drawing.Image)(resources.GetObject("btnrWash.img")));
            this.btnrWash.Location = new System.Drawing.Point(0, 300);
            this.btnrWash.Name = "btnrWash";
            this.btnrWash.Size = new System.Drawing.Size(150, 130);
            this.btnrWash.TabIndex = 3;
            this.btnrWash.text = "Dọn vệ sinh";
            this.btnrWash.Click += new System.EventHandler(this.btnrWash_Click);
            // 
            // pnMainService
            // 
            this.pnMainService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.pnMainService.Location = new System.Drawing.Point(300, 50);
            this.pnMainService.Name = "pnMainService";
            this.pnMainService.Size = new System.Drawing.Size(1100, 500);
            this.pnMainService.TabIndex = 1;
            // 
            // btnCal
            // 
            this.btnCal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(101)))), ((int)(((byte)(174)))));
            this.btnCal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCal.ForeColor = System.Drawing.Color.White;
            this.btnCal.Location = new System.Drawing.Point(100, 500);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(150, 50);
            this.btnCal.TabIndex = 2;
            this.btnCal.Text = "Thanh toán";
            this.btnCal.UseVisualStyleBackColor = false;
            this.btnCal.Paint += new System.Windows.Forms.PaintEventHandler(this.btnCal_Paint);
            // 
            // btnrClean
            // 
            this.btnrClean.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(101)))), ((int)(((byte)(174)))));
            this.btnrClean.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnrClean.ForeColor = System.Drawing.Color.White;
            this.btnrClean.img = ((System.Drawing.Image)(resources.GetObject("btnrClean.img")));
            this.btnrClean.Location = new System.Drawing.Point(0, 0);
            this.btnrClean.Name = "btnrClean";
            this.btnrClean.Size = new System.Drawing.Size(150, 130);
            this.btnrClean.TabIndex = 3;
            this.btnrClean.text = "Dọn vệ sinh";
            this.btnrClean.Click += new System.EventHandler(this.btnrClean_Click);
            // 
            // UCService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(238)))), ((int)(((byte)(253)))));
            this.Controls.Add(this.btnCal);
            this.Controls.Add(this.pnMainService);
            this.Controls.Add(this.pnMenuService);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(31)))));
            this.Name = "UCService";
            this.Size = new System.Drawing.Size(1500, 600);
            this.Load += new System.EventHandler(this.UCService_Load);
            this.pnMenuService.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnMenuService;
        private System.Windows.Forms.Panel pnMainService;
        private System.Windows.Forms.Button btnCal;
        private RoundedButtonService btnrCook;
        private RoundedButtonService btnrWash;
        private RoundedButtonService btnrClean;
    }
}
