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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.pnMain = new System.Windows.Forms.Panel();
            this.abtnIn = new Banking.AControls.AButton();
            this.abtnOut = new Banking.AControls.AButton();
            this.abtnAll = new Banking.AControls.AButton();
            this.abtnSearch = new Banking.AControls.AButton();
            this.adpTo = new Banking.AControls.ADateTimePicker();
            this.adpFrom = new Banking.AControls.ADateTimePicker();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // pnMain
            // 
            this.pnMain.AutoScroll = true;
            this.pnMain.Location = new System.Drawing.Point(50, 380);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(496, 200);
            this.pnMain.TabIndex = 2;
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
            this.abtnIn.Location = new System.Drawing.Point(396, 320);
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
            this.abtnOut.Location = new System.Drawing.Point(225, 320);
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
            this.abtnAll.Location = new System.Drawing.Point(50, 320);
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
            this.abtnSearch.Location = new System.Drawing.Point(426, 26);
            this.abtnSearch.Name = "abtnSearch";
            this.abtnSearch.RoundType = Banking.AControls.AButton.RoundStyles.Full;
            this.abtnSearch.Size = new System.Drawing.Size(120, 45);
            this.abtnSearch.TabIndex = 3;
            this.abtnSearch.Text = "Tìm kiếm";
            this.abtnSearch.TextColor = System.Drawing.Color.White;
            this.abtnSearch.ThinknessLine = 0;
            this.abtnSearch.UseVisualStyleBackColor = false;
            this.abtnSearch.Click += new System.EventHandler(this.abtnSearch_Click);
            // 
            // adpTo
            // 
            this.adpTo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(180)))), ((int)(((byte)(110)))));
            this.adpTo.BorderSize = 2;
            this.adpTo.CustomFormat = "dd/MM/yyyy";
            this.adpTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.adpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.adpTo.Location = new System.Drawing.Point(225, 26);
            this.adpTo.MinimumSize = new System.Drawing.Size(4, 35);
            this.adpTo.Name = "adpTo";
            this.adpTo.Size = new System.Drawing.Size(150, 35);
            this.adpTo.SkinColor = System.Drawing.Color.Transparent;
            this.adpTo.TabIndex = 1;
            this.adpTo.TextColor = System.Drawing.Color.Black;
            // 
            // adpFrom
            // 
            this.adpFrom.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(180)))), ((int)(((byte)(110)))));
            this.adpFrom.BorderSize = 2;
            this.adpFrom.CustomFormat = "dd/MM/yyyy";
            this.adpFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.adpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.adpFrom.Location = new System.Drawing.Point(50, 26);
            this.adpFrom.MinimumSize = new System.Drawing.Size(4, 35);
            this.adpFrom.Name = "adpFrom";
            this.adpFrom.Size = new System.Drawing.Size(150, 35);
            this.adpFrom.SkinColor = System.Drawing.Color.Transparent;
            this.adpFrom.TabIndex = 0;
            this.adpFrom.TextColor = System.Drawing.Color.Black;
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.BorderWidth = 5;
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(50, 90);
            this.chart.Name = "chart";
            series1.BackSecondaryColor = System.Drawing.Color.White;
            series1.BorderColor = System.Drawing.Color.White;
            series1.BorderWidth = 5;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Color = System.Drawing.Color.White;
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(496, 200);
            this.chart.TabIndex = 8;
            this.chart.Text = "chart";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            title1.Name = "Title1";
            title1.Text = "Biểu đồ tròn chi tiêu";
            this.chart.Titles.Add(title1);
            // 
            // StatementUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.chart);
            this.Controls.Add(this.abtnIn);
            this.Controls.Add(this.abtnOut);
            this.Controls.Add(this.abtnAll);
            this.Controls.Add(this.abtnSearch);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.adpTo);
            this.Controls.Add(this.adpFrom);
            this.Name = "StatementUC";
            this.Size = new System.Drawing.Size(596, 605);
            this.Load += new System.EventHandler(this.StatementUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AControls.ADateTimePicker adpFrom;
        private AControls.ADateTimePicker adpTo;
        private System.Windows.Forms.Panel pnMain;
        private AControls.AButton abtnSearch;
        private AControls.AButton abtnAll;
        private AControls.AButton abtnOut;
        private AControls.AButton abtnIn;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
    }
}
