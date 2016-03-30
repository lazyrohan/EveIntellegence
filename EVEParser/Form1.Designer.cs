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
            this.MarketMainSplit = new System.Windows.Forms.SplitContainer();
            this.RefreshMarketBtn = new System.Windows.Forms.Button();
            this.RefreshDBBtn = new System.Windows.Forms.Button();
            this.MarketMainInfoSplit = new System.Windows.Forms.SplitContainer();
            this.MarketTree = new System.Windows.Forms.TreeView();
            this.MarketInfoSplit = new System.Windows.Forms.SplitContainer();
            this.MarketOrderSplit = new System.Windows.Forms.SplitContainer();
            this.MarketSalesDG = new System.Windows.Forms.DataGridView();
            this.MarketBuyDG = new System.Windows.Forms.DataGridView();
            this.MarketHistSplit = new System.Windows.Forms.SplitContainer();
            this.PriceHistoryChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.LogRTxt = new System.Windows.Forms.RichTextBox();
            this.MainTab.SuspendLayout();
            this.MarketTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MarketMainSplit)).BeginInit();
            this.MarketMainSplit.Panel1.SuspendLayout();
            this.MarketMainSplit.Panel2.SuspendLayout();
            this.MarketMainSplit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MarketMainInfoSplit)).BeginInit();
            this.MarketMainInfoSplit.Panel1.SuspendLayout();
            this.MarketMainInfoSplit.Panel2.SuspendLayout();
            this.MarketMainInfoSplit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MarketInfoSplit)).BeginInit();
            this.MarketInfoSplit.Panel1.SuspendLayout();
            this.MarketInfoSplit.Panel2.SuspendLayout();
            this.MarketInfoSplit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MarketOrderSplit)).BeginInit();
            this.MarketOrderSplit.Panel1.SuspendLayout();
            this.MarketOrderSplit.Panel2.SuspendLayout();
            this.MarketOrderSplit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MarketSalesDG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MarketBuyDG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MarketHistSplit)).BeginInit();
            this.MarketHistSplit.Panel2.SuspendLayout();
            this.MarketHistSplit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PriceHistoryChart)).BeginInit();
            this.tabPage2.SuspendLayout();
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
            this.MarketTab.Controls.Add(this.MarketMainSplit);
            this.MarketTab.Location = new System.Drawing.Point(4, 4);
            this.MarketTab.Name = "MarketTab";
            this.MarketTab.Padding = new System.Windows.Forms.Padding(3);
            this.MarketTab.Size = new System.Drawing.Size(792, 574);
            this.MarketTab.TabIndex = 0;
            this.MarketTab.Text = "Market";
            this.MarketTab.UseVisualStyleBackColor = true;
            this.MarketTab.Resize += new System.EventHandler(this.MarketTab_Resize);
            // 
            // MarketMainSplit
            // 
            this.MarketMainSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MarketMainSplit.Location = new System.Drawing.Point(3, 3);
            this.MarketMainSplit.Name = "MarketMainSplit";
            this.MarketMainSplit.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // MarketMainSplit.Panel1
            // 
            this.MarketMainSplit.Panel1.Controls.Add(this.RefreshMarketBtn);
            this.MarketMainSplit.Panel1.Controls.Add(this.RefreshDBBtn);
            // 
            // MarketMainSplit.Panel2
            // 
            this.MarketMainSplit.Panel2.Controls.Add(this.MarketMainInfoSplit);
            this.MarketMainSplit.Size = new System.Drawing.Size(786, 568);
            this.MarketMainSplit.SplitterDistance = 33;
            this.MarketMainSplit.TabIndex = 6;
            // 
            // RefreshMarketBtn
            // 
            this.RefreshMarketBtn.AutoSize = true;
            this.RefreshMarketBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RefreshMarketBtn.Location = new System.Drawing.Point(6, 2);
            this.RefreshMarketBtn.Name = "RefreshMarketBtn";
            this.RefreshMarketBtn.Size = new System.Drawing.Size(87, 23);
            this.RefreshMarketBtn.TabIndex = 2;
            this.RefreshMarketBtn.Text = "RefreshMarket";
            this.RefreshMarketBtn.UseVisualStyleBackColor = true;
            this.RefreshMarketBtn.Click += new System.EventHandler(this.RefreshMarketBtn_Click);
            // 
            // RefreshDBBtn
            // 
            this.RefreshDBBtn.Location = new System.Drawing.Point(380, 3);
            this.RefreshDBBtn.Name = "RefreshDBBtn";
            this.RefreshDBBtn.Size = new System.Drawing.Size(75, 23);
            this.RefreshDBBtn.TabIndex = 1;
            this.RefreshDBBtn.Text = "RefreshDB";
            this.RefreshDBBtn.UseVisualStyleBackColor = true;
            this.RefreshDBBtn.Click += new System.EventHandler(this.RefreshDBBtn_Click);
            // 
            // MarketMainInfoSplit
            // 
            this.MarketMainInfoSplit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MarketMainInfoSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MarketMainInfoSplit.Location = new System.Drawing.Point(0, 0);
            this.MarketMainInfoSplit.Name = "MarketMainInfoSplit";
            // 
            // MarketMainInfoSplit.Panel1
            // 
            this.MarketMainInfoSplit.Panel1.Controls.Add(this.MarketTree);
            // 
            // MarketMainInfoSplit.Panel2
            // 
            this.MarketMainInfoSplit.Panel2.Controls.Add(this.MarketInfoSplit);
            this.MarketMainInfoSplit.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.MarketMainInfoSplit.Size = new System.Drawing.Size(786, 531);
            this.MarketMainInfoSplit.SplitterDistance = 130;
            this.MarketMainInfoSplit.TabIndex = 5;
            // 
            // MarketTree
            // 
            this.MarketTree.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MarketTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MarketTree.Location = new System.Drawing.Point(0, 0);
            this.MarketTree.Name = "MarketTree";
            this.MarketTree.ShowNodeToolTips = true;
            this.MarketTree.Size = new System.Drawing.Size(128, 529);
            this.MarketTree.TabIndex = 0;
            this.MarketTree.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.MarketTree_NodeMouseDoubleClick);
            // 
            // MarketInfoSplit
            // 
            this.MarketInfoSplit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MarketInfoSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MarketInfoSplit.Location = new System.Drawing.Point(0, 0);
            this.MarketInfoSplit.Name = "MarketInfoSplit";
            // 
            // MarketInfoSplit.Panel1
            // 
            this.MarketInfoSplit.Panel1.Controls.Add(this.MarketOrderSplit);
            // 
            // MarketInfoSplit.Panel2
            // 
            this.MarketInfoSplit.Panel2.Controls.Add(this.MarketHistSplit);
            this.MarketInfoSplit.Size = new System.Drawing.Size(652, 531);
            this.MarketInfoSplit.SplitterDistance = 314;
            this.MarketInfoSplit.TabIndex = 1;
            // 
            // MarketOrderSplit
            // 
            this.MarketOrderSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MarketOrderSplit.Location = new System.Drawing.Point(0, 0);
            this.MarketOrderSplit.Name = "MarketOrderSplit";
            this.MarketOrderSplit.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // MarketOrderSplit.Panel1
            // 
            this.MarketOrderSplit.Panel1.Controls.Add(this.MarketSalesDG);
            // 
            // MarketOrderSplit.Panel2
            // 
            this.MarketOrderSplit.Panel2.Controls.Add(this.MarketBuyDG);
            this.MarketOrderSplit.Size = new System.Drawing.Size(312, 529);
            this.MarketOrderSplit.SplitterDistance = 258;
            this.MarketOrderSplit.TabIndex = 0;
            // 
            // MarketSalesDG
            // 
            this.MarketSalesDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MarketSalesDG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MarketSalesDG.GridColor = System.Drawing.SystemColors.Highlight;
            this.MarketSalesDG.Location = new System.Drawing.Point(0, 0);
            this.MarketSalesDG.Name = "MarketSalesDG";
            this.MarketSalesDG.Size = new System.Drawing.Size(312, 258);
            this.MarketSalesDG.TabIndex = 2;
            // 
            // MarketBuyDG
            // 
            this.MarketBuyDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MarketBuyDG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MarketBuyDG.Location = new System.Drawing.Point(0, 0);
            this.MarketBuyDG.Name = "MarketBuyDG";
            this.MarketBuyDG.Size = new System.Drawing.Size(312, 267);
            this.MarketBuyDG.TabIndex = 3;
            // 
            // MarketHistSplit
            // 
            this.MarketHistSplit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MarketHistSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MarketHistSplit.Location = new System.Drawing.Point(0, 0);
            this.MarketHistSplit.Name = "MarketHistSplit";
            this.MarketHistSplit.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // MarketHistSplit.Panel2
            // 
            this.MarketHistSplit.Panel2.Controls.Add(this.PriceHistoryChart);
            this.MarketHistSplit.Size = new System.Drawing.Size(334, 531);
            this.MarketHistSplit.SplitterDistance = 126;
            this.MarketHistSplit.TabIndex = 0;
            // 
            // PriceHistoryChart
            // 
            this.PriceHistoryChart.BorderlineColor = System.Drawing.Color.DarkGray;
            this.PriceHistoryChart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.PriceHistoryChart.BorderlineWidth = 2;
            chartArea1.Name = "ChartArea1";
            this.PriceHistoryChart.ChartAreas.Add(chartArea1);
            this.PriceHistoryChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.PriceHistoryChart.Legends.Add(legend1);
            this.PriceHistoryChart.Location = new System.Drawing.Point(0, 0);
            this.PriceHistoryChart.Name = "PriceHistoryChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.PriceHistoryChart.Series.Add(series1);
            this.PriceHistoryChart.Size = new System.Drawing.Size(332, 399);
            this.PriceHistoryChart.TabIndex = 4;
            this.PriceHistoryChart.Text = "chart1";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.LogRTxt);
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 574);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // LogRTxt
            // 
            this.LogRTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogRTxt.Location = new System.Drawing.Point(3, 3);
            this.LogRTxt.Name = "LogRTxt";
            this.LogRTxt.Size = new System.Drawing.Size(786, 568);
            this.LogRTxt.TabIndex = 0;
            this.LogRTxt.Text = "";
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
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainTab.ResumeLayout(false);
            this.MarketTab.ResumeLayout(false);
            this.MarketMainSplit.Panel1.ResumeLayout(false);
            this.MarketMainSplit.Panel1.PerformLayout();
            this.MarketMainSplit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MarketMainSplit)).EndInit();
            this.MarketMainSplit.ResumeLayout(false);
            this.MarketMainInfoSplit.Panel1.ResumeLayout(false);
            this.MarketMainInfoSplit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MarketMainInfoSplit)).EndInit();
            this.MarketMainInfoSplit.ResumeLayout(false);
            this.MarketInfoSplit.Panel1.ResumeLayout(false);
            this.MarketInfoSplit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MarketInfoSplit)).EndInit();
            this.MarketInfoSplit.ResumeLayout(false);
            this.MarketOrderSplit.Panel1.ResumeLayout(false);
            this.MarketOrderSplit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MarketOrderSplit)).EndInit();
            this.MarketOrderSplit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MarketSalesDG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MarketBuyDG)).EndInit();
            this.MarketHistSplit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MarketHistSplit)).EndInit();
            this.MarketHistSplit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PriceHistoryChart)).EndInit();
            this.tabPage2.ResumeLayout(false);
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
        private System.Windows.Forms.SplitContainer MarketMainInfoSplit;
        private System.Windows.Forms.SplitContainer MarketOrderSplit;
        private System.Windows.Forms.SplitContainer MarketInfoSplit;
        private System.Windows.Forms.SplitContainer MarketHistSplit;
        private System.Windows.Forms.SplitContainer MarketMainSplit;
        private System.Windows.Forms.Button RefreshMarketBtn;
        private System.Windows.Forms.RichTextBox LogRTxt;
    }
}

