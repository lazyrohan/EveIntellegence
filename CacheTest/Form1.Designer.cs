namespace CacheTest
{
    partial class Form1
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
            this.MainTab = new System.Windows.Forms.TabControl();
            this.MarketTab = new System.Windows.Forms.TabPage();
            this.RefreshDBBtn = new System.Windows.Forms.Button();
            this.SalesDataGrid = new System.Windows.Forms.DataGridView();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.DebugTab = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.MethodCallsList = new System.Windows.Forms.ListBox();
            this.ParseCacheBtn = new System.Windows.Forms.Button();
            this.LogInfoEdit = new System.Windows.Forms.RichTextBox();
            this.MainTab.SuspendLayout();
            this.MarketTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SalesDataGrid)).BeginInit();
            this.DebugTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTab
            // 
            this.MainTab.Controls.Add(this.MarketTab);
            this.MainTab.Controls.Add(this.DebugTab);
            this.MainTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTab.Location = new System.Drawing.Point(0, 0);
            this.MainTab.Name = "MainTab";
            this.MainTab.SelectedIndex = 0;
            this.MainTab.Size = new System.Drawing.Size(842, 460);
            this.MainTab.TabIndex = 0;
            // 
            // MarketTab
            // 
            this.MarketTab.Controls.Add(this.RefreshDBBtn);
            this.MarketTab.Controls.Add(this.SalesDataGrid);
            this.MarketTab.Controls.Add(this.treeView1);
            this.MarketTab.Location = new System.Drawing.Point(4, 22);
            this.MarketTab.Name = "MarketTab";
            this.MarketTab.Padding = new System.Windows.Forms.Padding(3);
            this.MarketTab.Size = new System.Drawing.Size(834, 434);
            this.MarketTab.TabIndex = 0;
            this.MarketTab.Text = "Market";
            this.MarketTab.UseVisualStyleBackColor = true;
            // 
            // RefreshDBBtn
            // 
            this.RefreshDBBtn.Location = new System.Drawing.Point(47, 18);
            this.RefreshDBBtn.Name = "RefreshDBBtn";
            this.RefreshDBBtn.Size = new System.Drawing.Size(75, 23);
            this.RefreshDBBtn.TabIndex = 3;
            this.RefreshDBBtn.Text = "RefreshDB";
            this.RefreshDBBtn.UseVisualStyleBackColor = true;
            // 
            // SalesDataGrid
            // 
            this.SalesDataGrid.AllowUserToOrderColumns = true;
            this.SalesDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.SalesDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.SalesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SalesDataGrid.Location = new System.Drawing.Point(200, 47);
            this.SalesDataGrid.Name = "SalesDataGrid";
            this.SalesDataGrid.RowTemplate.ReadOnly = true;
            this.SalesDataGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SalesDataGrid.Size = new System.Drawing.Size(626, 379);
            this.SalesDataGrid.TabIndex = 2;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(6, 47);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(188, 379);
            this.treeView1.TabIndex = 1;
            // 
            // DebugTab
            // 
            this.DebugTab.Controls.Add(this.label1);
            this.DebugTab.Controls.Add(this.comboBox1);
            this.DebugTab.Controls.Add(this.MethodCallsList);
            this.DebugTab.Controls.Add(this.ParseCacheBtn);
            this.DebugTab.Controls.Add(this.LogInfoEdit);
            this.DebugTab.Location = new System.Drawing.Point(4, 22);
            this.DebugTab.Name = "DebugTab";
            this.DebugTab.Padding = new System.Windows.Forms.Padding(3);
            this.DebugTab.Size = new System.Drawing.Size(834, 434);
            this.DebugTab.TabIndex = 4;
            this.DebugTab.Text = "DebugTab";
            this.DebugTab.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(339, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "SelectedIndexChanged"});
            this.comboBox1.Location = new System.Drawing.Point(236, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(116, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // MethodCallsList
            // 
            this.MethodCallsList.FormattingEnabled = true;
            this.MethodCallsList.Items.AddRange(new object[] {
            "CharGetNewTransactions",
            "GetAgents",
            "GetAgentsInSpace",
            "GetAllianceJumpBridges",
            "GetAllianceSystems",
            "GetAverageMarketPrices",
            "GetBillTypes",
            "GetBlueprintDataByOwner",
            "GetBookmarks",
            "GetChannels",
            "GetCharacterRankInfo",
            "GetCharOrders",
            "GetCharStandings",
            "GetCorporateStationOffice",
            "GetCorporationWarFactionID",
            "GetCorpStandings",
            "GetDelayedRewardsByGroupIDs",
            "GetDynamicCelestials",
            "GetEmploymentRecord",
            "GetEntryTypes",
            "GetFacWarSystems",
            "GetFormations",
            "GetHomeStation",
            "GetImageServerLink",
            "GetItemKillCountPlayer",
            "GetKeyMap",
            "GetKillMail",
            "GetLPExchangeRates",
            "GetMarketGroups",
            "GetMedalsReceived",
            "GetMyEscalatingPathDetails",
            "GetMyJournalDetails",
            "GetMyKillRights",
            "GetNewPriceHistory",
            "GetNPCDivisions",
            "GetNPCNPCStandings",
            "GetOldPriceHistory",
            "GetOperandsForChar",
            "GetOrders",
            "GetPlanetResourceInfo",
            "GetPublicInfo",
            "GetPublicInfo3",
            "GetRecentShipKillsAndLosses",
            "GetRegionBest",
            "GetRewardData",
            "GetStation",
            "GetStationAsks",
            "GetStationExtraInfo",
            "GetStationSolarSystemsByOwner",
            "GetSystemAsks",
            "GetTopPilotBounties",
            "GetWarFactions",
            "StartupCheck"});
            this.MethodCallsList.Location = new System.Drawing.Point(8, 6);
            this.MethodCallsList.Name = "MethodCallsList";
            this.MethodCallsList.Size = new System.Drawing.Size(183, 368);
            this.MethodCallsList.TabIndex = 2;
            this.MethodCallsList.SelectedIndexChanged += new System.EventHandler(this.MethodCallsList_SelectedIndexChanged);
            // 
            // ParseCacheBtn
            // 
            this.ParseCacheBtn.Location = new System.Drawing.Point(342, 128);
            this.ParseCacheBtn.Name = "ParseCacheBtn";
            this.ParseCacheBtn.Size = new System.Drawing.Size(75, 23);
            this.ParseCacheBtn.TabIndex = 1;
            this.ParseCacheBtn.Text = "ParseCache";
            this.ParseCacheBtn.UseVisualStyleBackColor = true;
            this.ParseCacheBtn.Click += new System.EventHandler(this.ParseCacheBtn_Click);
            // 
            // LogInfoEdit
            // 
            this.LogInfoEdit.Location = new System.Drawing.Point(488, 6);
            this.LogInfoEdit.Name = "LogInfoEdit";
            this.LogInfoEdit.Size = new System.Drawing.Size(338, 422);
            this.LogInfoEdit.TabIndex = 0;
            this.LogInfoEdit.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 460);
            this.Controls.Add(this.MainTab);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MainTab.ResumeLayout(false);
            this.MarketTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SalesDataGrid)).EndInit();
            this.DebugTab.ResumeLayout(false);
            this.DebugTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainTab;
        private System.Windows.Forms.TabPage MarketTab;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TabPage DebugTab;
        private System.Windows.Forms.RichTextBox LogInfoEdit;
        private System.Windows.Forms.Button ParseCacheBtn;
        private System.Windows.Forms.ListBox MethodCallsList;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView SalesDataGrid;
        private System.Windows.Forms.Button RefreshDBBtn;
    }
}