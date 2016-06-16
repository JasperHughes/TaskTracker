namespace Task_Tracker
{
    partial class IterationGraph
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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.iterationChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.printBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.iterationChart)).BeginInit();
            this.SuspendLayout();
            // 
            // iterationChart
            // 
            chartArea1.Name = "ChartArea1";
            this.iterationChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.iterationChart.Legends.Add(legend1);
            this.iterationChart.Location = new System.Drawing.Point(12, 12);
            this.iterationChart.Name = "iterationChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series1.Legend = "Legend1";
            series1.Name = "Completed Tasks";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series2.Legend = "Legend1";
            series2.Name = "Tasks";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.iterationChart.Series.Add(series1);
            this.iterationChart.Series.Add(series2);
            this.iterationChart.Size = new System.Drawing.Size(731, 399);
            this.iterationChart.TabIndex = 0;
            this.iterationChart.Text = "Iteration Progress";
            // 
            // printBtn
            // 
            this.printBtn.Location = new System.Drawing.Point(668, 417);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(75, 23);
            this.printBtn.TabIndex = 1;
            this.printBtn.Text = "Print";
            this.printBtn.UseVisualStyleBackColor = true;
            // 
            // IterationGraph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 452);
            this.Controls.Add(this.printBtn);
            this.Controls.Add(this.iterationChart);
            this.Name = "IterationGraph";
            this.Text = "IterationGraph";
            this.Load += new System.EventHandler(this.IterationGraph_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iterationChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart iterationChart;
        private System.Windows.Forms.Button printBtn;
    }
}