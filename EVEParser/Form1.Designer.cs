namespace EVEParser
{
    partial class MainForm
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
            this.MainTab = new System.Windows.Forms.TabControl();
            this.MarketTab = new System.Windows.Forms.TabPage();
            this.PriceHistoryChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.MarketBuyDG = new System.Windows.Forms.DataGridView();
            this.MarketSalesDG = new System.Windows.Forms.DataGridView();
            this.RefreshDBBtn = new System.Windows.Forms.Button();
            this.MarketTree = new System.Windows.Forms.TreeView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.MainTab.SuspendLayout();
            this.MarketTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PriceHistoryChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MarketBuyDG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MarketSalesDG)).BeginInit();
            this.SuspendLayout();
            // 
            // MainTab
            // 
            this.MainTab.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.MainTab.Controls.Add(this.MarketTab);
            this.MainTab.Controls.Add(this.tabPage2);
            this.MainTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTab.Location = new System.Drawing.Point(0, 0);
            this.MainTab.Name = "MainTab";
            this.MainTab.SelectedIndex = 0;
            this.MainTab.Size = new System.Drawing.Size(800, 600);
            this.MainTab.TabIndex = 0;
            // 
            // MarketTab
            // 
            this.MarketTab.Controls.Add(this.PriceHistoryChart);
            this.MarketTab.Controls.Add(this.MarketBuyDG);
            this.MarketTab.Controls.Add(this.MarketSalesDG);
            this.MarketTab.Controls.Add(this.RefreshDBBtn);
            this.MarketTab.Controls.Add(this.MarketTree);
            this.MarketTab.Location = new System.Drawing.Point(4, 4);
            this.MarketTab.Name = "MarketTab";
            this.MarketTab.Padding = new System.Windows.Forms.Padding(3);
            this.MarketTab.Size = new System.Drawing.Size(792, 574);
            this.MarketTab.TabIndex = 0;
            this.MarketTab.Text = "Market";
            this.MarketTab.UseVisualStyleBackColor = true;
            this.MarketTab.Resize += new System.EventHandler(this.MarketTab_Resize);
            // 
            // PriceHistoryChart
            // 
            this.PriceHistoryChart.BorderlineColor = System.Drawing.Color.DarkGray;
            this.PriceHistoryChart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.PriceHistoryChart.BorderlineWidth = 2;
            chartArea1.Name = "ChartArea1";
            this.PriceHistoryChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.PriceHistoryChart.Legends.Add(legend1);
            this.PriceHistoryChart.Location = new System.Drawing.Point(202, 433);
            this.PriceHistoryChart.Name = "PriceHistoryChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.PriceHistoryChart.Series.Add(series1);
            this.PriceHistoryChart.Size = new System.Drawing.Size(314, 135);
            this.PriceHistoryChart.TabIndex = 4;
            this.PriceHistoryChart.Text = "chart1";
            // 
            // MarketBuyDG
            // 
            this.MarketBuyDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MarketBuyDG.Location = new System.Drawing.Point(202, 205);
            this.MarketBuyDG.Name = "MarketBuyDG";
            this.MarketBuyDG.Size = new System.Drawing.Size(584, 148);
            this.MarketBuyDG.TabIndex = 3;
            // 
            // MarketSalesDG
            // 
            this.MarketSalesDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MarketSalesDG.GridColor = System.Drawing.SystemColors.Highlight;
            this.MarketSalesDG.Location = new System.Drawing.Point(202, 37);
            this.MarketSalesDG.Name = "MarketSalesDG";
            this.MarketSalesDG.Size = new System.Drawing.Size(584, 162);
            this.MarketSalesDG.TabIndex = 2;
            // 
            // RefreshDBBtn
            // 
            this.RefreshDBBtn.Location = new System.Drawing.Point(3, 8);
            this.RefreshDBBtn.Name = "RefreshDBBtn";
            this.RefreshDBBtn.Size = new System.Drawing.Size(75, 23);
            this.RefreshDBBtn.TabIndex = 1;
            this.RefreshDBBtn.Text = "RefreshDB";
            this.RefreshDBBtn.UseVisualStyleBackColor = true;
            this.RefreshDBBtn.Click += new System.EventHandler(this.RefreshDBBtn_Click);
            // 
            // MarketTree
            // 
            this.MarketTree.Location = new System.Drawing.Point(3, 37);
            this.MarketTree.Name = "MarketTree";
            this.MarketTree.Size = new System.Drawing.Size(193, 531);
            this.MarketTree.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 574);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.MainTab);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EVEParser";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainTab.ResumeLayout(false);
            this.MarketTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PriceHistoryChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MarketBuyDG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MarketSalesDG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainTab;
        private System.Windows.Forms.TabPage MarketTab;
        private System.Windows.Forms.TreeView MarketTree;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button RefreshDBBtn;
        private System.Windows.Forms.DataGridView MarketSalesDG;
        private System.Windows.Forms.DataVisualization.Charting.Chart PriceHistoryChart;
        private System.Windows.Forms.DataGridView MarketBuyDG;
    }
}

