using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace EVEParser
{
    public partial class MainForm : Form
    {
        //Database connection var
        private SQLiteConnection m_DBConn;
        private void CtlResize()
        {
            //Resize refresh DB btn without size change
            RefreshDBBtn.Top = MarketTab.Top + 5;
            RefreshDBBtn.Left = MarketTab.Left + 5;
            // Resize market tree control
            MarketTree.Top = RefreshDBBtn.Bottom + 5;
            MarketTree.Left = MarketTab.Left + 5;
            MarketTree.Height = MarketTab.Height - 20 - RefreshDBBtn.Height;
            MarketTree.Width = 150;
            //Resize datagrid sales
            MarketSalesDG.Top = MarketTree.Top;
            MarketSalesDG.Left = MarketTree.Right + 5;
            MarketSalesDG.Height = 200;
            MarketSalesDG.Width = MarketTab.Width - 160;
            //Resize datagrid buy
            MarketBuyDG.Top = MarketSalesDG.Bottom + 5;
            MarketBuyDG.Left = MarketSalesDG.Left;
            MarketBuyDG.Height = 200;
            MarketBuyDG.Width = MarketSalesDG.Width;
            //Resize chart
            PriceHistoryChart.Top = MarketBuyDG.Bottom + 5;
            PriceHistoryChart.Left = MarketBuyDG.Left;
            PriceHistoryChart.Height = MarketTab.Height - 455;
            PriceHistoryChart.Width = (int)(MarketBuyDG.Width/2);
        }


        public MainForm()
        {
            InitializeComponent();
        }

        private void MarketTab_Resize(object sender, EventArgs e)
        {
            CtlResize();
        }

        private void RefreshDBBtn_Click(object sender, EventArgs e)
        {
            //Refresh database
            SQLiteDataAdapter adp = new SQLiteDataAdapter();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //Define ctrls size
            CtlResize();

            //Open database
            string strConn = "Data Source=sqlite-latest.sqlite;version=3;Read Only= True;";
            m_DBConn = new SQLiteConnection(strConn);
            m_DBConn.Open();

            //Show database
            SQLiteCommand cmd = new SQLiteCommand();
            // cmd.CommandText = "SELECT * from sqlite_master WHERE type='table' ";
            cmd.CommandText = "SELECT * from invTypes where typeName='Tritanium'";
            cmd.Connection = m_DBConn;
           SQLiteDataReader dr = cmd.ExecuteReader();
          
            SQLiteDataAdapter dapt = new SQLiteDataAdapter(cmd);
            DataTable dtab = new DataTable();
            dapt.Fill(dtab);
            MarketSalesDG.DataSource = dtab;
            
         }
    }
}
