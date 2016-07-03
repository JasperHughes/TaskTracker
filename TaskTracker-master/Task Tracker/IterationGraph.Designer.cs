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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.iterationChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.printBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.iterationChart)).BeginInit();
            this.SuspendLayout();
            // 
            // iterationChart
            // 
            chartArea3.AxisX.Title = "Days of Iteration";
            chartArea3.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea3.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea3.AxisY.Title = "Number of Tasks";
            chartArea3.Name = "ChartArea1";
            this.iterationChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.iterationChart.Legends.Add(legend3);
            this.iterationChart.Location = new System.Drawing.Point(12, 12);
            this.iterationChart.Name = "iterationChart";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series5.Legend = "Legend1";
            series5.Name = "Completed Tasks";
            series5.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series5.YValuesPerPoint = 4;
            series5.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series6.Legend = "Legend1";
            series6.Name = "Tasks";
            series6.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series6.YValuesPerPoint = 4;
            series6.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.iterationChart.Series.Add(series5);
            this.iterationChart.Series.Add(series6);
            this.iterationChart.Size = new System.Drawing.Size(731, 399);
            this.iterationChart.TabIndex = 0;
            this.iterationChart.Text = "Iteration Progress";
            title3.Name = "graphTitle";
            title3.Text = "Iteration Progress";
            this.iterationChart.Titles.Add(title3);
            this.iterationChart.GetToolTipText += new System.EventHandler<System.Windows.Forms.DataVisualization.Charting.ToolTipEventArgs>(this.iterationChart_GetToolTipText);
            // 
            // printBtn
            // 
            this.printBtn.Location = new System.Drawing.Point(668, 417);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(75, 23);
            this.printBtn.TabIndex = 1;
            this.printBtn.Text = "Print";
            this.printBtn.UseVisualStyleBackColor = true;
            this.printBtn.Click += new System.EventHandler(this.printBtn_Click);
            // 
            // IterationGraph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 452);
            this.Controls.Add(this.printBtn);
            this.Controls.Add(this.iterationChart);
            this.Name = "IterationGraph";
            this.Text = "Iteration Progress Graph";
            this.Load += new System.EventHandler(this.IterationGraph_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iterationChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart iterationChart;
        private System.Windows.Forms.Button printBtn;
    }
}