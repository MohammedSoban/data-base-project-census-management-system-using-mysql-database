namespace census_mangment_system
{
    partial class graphForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(graphForm));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.birthRateChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.loadGraphButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.resetButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rButton = new System.Windows.Forms.Button();
            this.loadPieButton = new System.Windows.Forms.Button();
            this.pieChartLitreacy = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.RESET = new System.Windows.Forms.Button();
            this.loadPie2Button = new System.Windows.Forms.Button();
            this.piechart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.birthRateChart)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pieChartLitreacy)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.piechart)).BeginInit();
            this.SuspendLayout();
            // 
            // birthRateChart
            // 
            this.birthRateChart.BackColor = System.Drawing.SystemColors.ActiveCaption;
            chartArea1.Name = "ChartArea1";
            this.birthRateChart.ChartAreas.Add(chartArea1);
            this.birthRateChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.birthRateChart.Legends.Add(legend1);
            this.birthRateChart.Location = new System.Drawing.Point(0, 0);
            this.birthRateChart.Name = "birthRateChart";
            this.birthRateChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.MarkerSize = 3;
            series1.Name = "birth rate";
            series1.XValueMember = "PEOPLE";
            series1.YValueMembers = "YEARS";
            this.birthRateChart.Series.Add(series1);
            this.birthRateChart.Size = new System.Drawing.Size(411, 255);
            this.birthRateChart.TabIndex = 0;
            this.birthRateChart.Text = "chart1";
            this.birthRateChart.Click += new System.EventHandler(this.birthRateChart_Click);
            // 
            // loadGraphButton
            // 
            this.loadGraphButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.loadGraphButton.Location = new System.Drawing.Point(306, 199);
            this.loadGraphButton.Name = "loadGraphButton";
            this.loadGraphButton.Size = new System.Drawing.Size(98, 34);
            this.loadGraphButton.TabIndex = 1;
            this.loadGraphButton.Text = "LOAD CHART";
            this.loadGraphButton.UseVisualStyleBackColor = false;
            this.loadGraphButton.Click += new System.EventHandler(this.loadGraphButton_Click_1);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Image = ((System.Drawing.Image)(resources.GetObject("backButton.Image")));
            this.backButton.Location = new System.Drawing.Point(12, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(76, 34);
            this.backButton.TabIndex = 14;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.resetButton);
            this.panel1.Controls.Add(this.loadGraphButton);
            this.panel1.Controls.Add(this.birthRateChart);
            this.panel1.Location = new System.Drawing.Point(48, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(411, 255);
            this.panel1.TabIndex = 15;
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.resetButton.Location = new System.Drawing.Point(306, 164);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(98, 29);
            this.resetButton.TabIndex = 17;
            this.resetButton.Text = "RESET";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rButton);
            this.panel2.Controls.Add(this.loadPieButton);
            this.panel2.Controls.Add(this.pieChartLitreacy);
            this.panel2.Location = new System.Drawing.Point(549, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(428, 255);
            this.panel2.TabIndex = 16;
            // 
            // rButton
            // 
            this.rButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rButton.Location = new System.Drawing.Point(336, 164);
            this.rButton.Name = "rButton";
            this.rButton.Size = new System.Drawing.Size(75, 29);
            this.rButton.TabIndex = 18;
            this.rButton.Text = "RESET";
            this.rButton.UseVisualStyleBackColor = false;
            this.rButton.Click += new System.EventHandler(this.rButton_Click);
            // 
            // loadPieButton
            // 
            this.loadPieButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.loadPieButton.Location = new System.Drawing.Point(336, 199);
            this.loadPieButton.Name = "loadPieButton";
            this.loadPieButton.Size = new System.Drawing.Size(80, 34);
            this.loadPieButton.TabIndex = 2;
            this.loadPieButton.Text = "LOAD CHART";
            this.loadPieButton.UseVisualStyleBackColor = false;
            this.loadPieButton.Click += new System.EventHandler(this.loadPieButton_Click);
            // 
            // pieChartLitreacy
            // 
            this.pieChartLitreacy.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.pieChartLitreacy.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pieChartLitreacy.BackImageTransparentColor = System.Drawing.Color.Transparent;
            this.pieChartLitreacy.BackSecondaryColor = System.Drawing.SystemColors.ActiveCaption;
            this.pieChartLitreacy.BorderlineColor = System.Drawing.SystemColors.ActiveCaption;
            chartArea2.Name = "ChartArea1";
            this.pieChartLitreacy.ChartAreas.Add(chartArea2);
            this.pieChartLitreacy.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.pieChartLitreacy.Legends.Add(legend2);
            this.pieChartLitreacy.Location = new System.Drawing.Point(0, 0);
            this.pieChartLitreacy.Name = "pieChartLitreacy";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.IsValueShownAsLabel = true;
            series2.IsXValueIndexed = true;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.pieChartLitreacy.Series.Add(series2);
            this.pieChartLitreacy.Size = new System.Drawing.Size(428, 255);
            this.pieChartLitreacy.TabIndex = 0;
            this.pieChartLitreacy.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(640, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "QUALIFICATIONS CLASSIFIED";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(167, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "BIRTH RATE";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.RESET);
            this.panel3.Controls.Add(this.loadPie2Button);
            this.panel3.Controls.Add(this.piechart);
            this.panel3.Location = new System.Drawing.Point(48, 369);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(411, 214);
            this.panel3.TabIndex = 3;
            // 
            // RESET
            // 
            this.RESET.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.RESET.Location = new System.Drawing.Point(317, 119);
            this.RESET.Name = "RESET";
            this.RESET.Size = new System.Drawing.Size(87, 33);
            this.RESET.TabIndex = 19;
            this.RESET.Text = "RESET";
            this.RESET.UseVisualStyleBackColor = false;
            this.RESET.Click += new System.EventHandler(this.RESET_Click);
            // 
            // loadPie2Button
            // 
            this.loadPie2Button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.loadPie2Button.Location = new System.Drawing.Point(317, 158);
            this.loadPie2Button.Name = "loadPie2Button";
            this.loadPie2Button.Size = new System.Drawing.Size(87, 44);
            this.loadPie2Button.TabIndex = 1;
            this.loadPie2Button.Text = "LOAD CHART";
            this.loadPie2Button.UseVisualStyleBackColor = false;
            this.loadPie2Button.Click += new System.EventHandler(this.loadPie2Button_Click);
            // 
            // piechart
            // 
            this.piechart.BackColor = System.Drawing.SystemColors.ActiveCaption;
            chartArea3.Name = "ChartArea1";
            this.piechart.ChartAreas.Add(chartArea3);
            this.piechart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.piechart.Legends.Add(legend3);
            this.piechart.Location = new System.Drawing.Point(0, 0);
            this.piechart.Name = "piechart";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.IsValueShownAsLabel = true;
            series3.Legend = "Legend1";
            series3.Name = "maleVsfemale";
            this.piechart.Series.Add(series3);
            this.piechart.Size = new System.Drawing.Size(411, 214);
            this.piechart.TabIndex = 0;
            this.piechart.Text = "chart1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(176, 339);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "MALE VS FEMALE";
            // 
            // graphForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(989, 643);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.backButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "graphForm";
            this.Text = "CENSUS MANAGEMENT SYSTEM";
            ((System.ComponentModel.ISupportInitialize)(this.birthRateChart)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pieChartLitreacy)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.piechart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart birthRateChart;
        private System.Windows.Forms.Button loadGraphButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button loadPieButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart pieChartLitreacy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button loadPie2Button;
        private System.Windows.Forms.DataVisualization.Charting.Chart piechart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button rButton;
        private System.Windows.Forms.Button RESET;
    }
}