namespace Count_Character_Occurence
{
    partial class frmChartResults
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartCharOccurence = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartCharOccurence)).BeginInit();
            this.SuspendLayout();
            // 
            // chartCharOccurence
            // 
            chartArea1.Name = "ChartArea1";
            this.chartCharOccurence.ChartAreas.Add(chartArea1);
            this.chartCharOccurence.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartCharOccurence.Legends.Add(legend1);
            this.chartCharOccurence.Location = new System.Drawing.Point(0, 0);
            this.chartCharOccurence.Name = "chartCharOccurence";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Character Occurence";
            series1.YValuesPerPoint = 2;
            this.chartCharOccurence.Series.Add(series1);
            this.chartCharOccurence.Size = new System.Drawing.Size(1145, 629);
            this.chartCharOccurence.TabIndex = 0;
            this.chartCharOccurence.Text = "Character Occurence";
            this.chartCharOccurence.Click += new System.EventHandler(this.chartCharOccurence_Click);
            // 
            // Chart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 629);
            this.Controls.Add(this.chartCharOccurence);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Chart";
            this.Text = "Result";
            this.Load += new System.EventHandler(this.Result_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartCharOccurence)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataVisualization.Charting.Chart chartCharOccurence;
    }
}