namespace SortirovkaSGraphicom
{
    partial class InsertionSort
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.buttonDrawGraphics = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chartComparison = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chartGraphics = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.DemoSortInsertion = new System.Windows.Forms.Button();
            this.DemoBinSort = new System.Windows.Forms.Button();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartComparison)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGraphics)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonDrawGraphics
            // 
            this.buttonDrawGraphics.Location = new System.Drawing.Point(12, 12);
            this.buttonDrawGraphics.Name = "buttonDrawGraphics";
            this.buttonDrawGraphics.Size = new System.Drawing.Size(118, 74);
            this.buttonDrawGraphics.TabIndex = 0;
            this.buttonDrawGraphics.Text = "Сравнение сортировок";
            this.buttonDrawGraphics.UseVisualStyleBackColor = true;
            this.buttonDrawGraphics.Click += new System.EventHandler(this.buttonDrawGraphics_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chartComparison);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1586, 893);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Сравнение по кол-ву сравнений";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chartComparison
            // 
            chartArea1.Name = "ChartArea1";
            this.chartComparison.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartComparison.Legends.Add(legend1);
            this.chartComparison.Location = new System.Drawing.Point(3, 3);
            this.chartComparison.Name = "chartComparison";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "BinSortInsertion";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "SimplySortInsertion";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "BubleSort";
            this.chartComparison.Series.Add(series1);
            this.chartComparison.Series.Add(series2);
            this.chartComparison.Series.Add(series3);
            this.chartComparison.Size = new System.Drawing.Size(1580, 887);
            this.chartComparison.TabIndex = 2;
            this.chartComparison.Text = "chart1";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chartGraphics);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1586, 893);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Сравнение по кол-ву обменов";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // chartGraphics
            // 
            chartArea2.Name = "ChartArea1";
            this.chartGraphics.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartGraphics.Legends.Add(legend2);
            this.chartGraphics.Location = new System.Drawing.Point(0, 0);
            this.chartGraphics.Name = "chartGraphics";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "BinSortInsertion";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "Legend1";
            series5.Name = "SimplySortInsertion";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Legend = "Legend1";
            series6.Name = "BubleSort";
            this.chartGraphics.Series.Add(series4);
            this.chartGraphics.Series.Add(series5);
            this.chartGraphics.Series.Add(series6);
            this.chartGraphics.Size = new System.Drawing.Size(1580, 887);
            this.chartGraphics.TabIndex = 1;
            this.chartGraphics.Text = "chart1";
            this.chartGraphics.Click += new System.EventHandler(this.chartGraphics_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(155, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1594, 922);
            this.tabControl1.TabIndex = 2;
            // 
            // DemoSortInsertion
            // 
            this.DemoSortInsertion.Location = new System.Drawing.Point(12, 92);
            this.DemoSortInsertion.Name = "DemoSortInsertion";
            this.DemoSortInsertion.Size = new System.Drawing.Size(118, 91);
            this.DemoSortInsertion.TabIndex = 3;
            this.DemoSortInsertion.Text = "Демонстрация простых вставок";
            this.DemoSortInsertion.UseVisualStyleBackColor = true;
            this.DemoSortInsertion.Click += new System.EventHandler(this.DemoSortInsertion_Click);
            // 
            // DemoBinSort
            // 
            this.DemoBinSort.Location = new System.Drawing.Point(11, 189);
            this.DemoBinSort.Name = "DemoBinSort";
            this.DemoBinSort.Size = new System.Drawing.Size(119, 92);
            this.DemoBinSort.TabIndex = 4;
            this.DemoBinSort.Text = "Демонстрация бинарных вставок";
            this.DemoBinSort.UseVisualStyleBackColor = true;
            this.DemoBinSort.Click += new System.EventHandler(this.DemoBinSort_Click);
            // 
            // InsertionSort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1808, 981);
            this.Controls.Add(this.DemoBinSort);
            this.Controls.Add(this.DemoSortInsertion);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.buttonDrawGraphics);
            this.Name = "InsertionSort";
            this.Text = "Sort";
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartComparison)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartGraphics)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDrawGraphics;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartComparison;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGraphics;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button DemoSortInsertion;
        private System.Windows.Forms.Button DemoBinSort;
    }
}

