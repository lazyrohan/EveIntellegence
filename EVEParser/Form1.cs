using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SQLite;
using YamlDotNet.RepresentationModel;
namespace EVEParser
{
    public partial class MainForm : Form
    {
        //Database connection var
        private SQLiteConnection m_DBConn;
        //Control items initialize
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

        //Fill Market tree
        private void FillMarketTree()
        {
            //Show database
            SQLiteCommand pcmd = new SQLiteCommand();
            // cmd.CommandText = "SELECT * from sqlite_master WHERE type='table' ";
            pcmd.Connection = m_DBConn;
            pcmd.CommandText = "SELECT * from invMarketGroups where parentGroupID is null";
            SQLiteDataReader pdr = pcmd.ExecuteReader();
            while (pdr.Read())
            {
                TreeNode pTreeNode = new TreeNode(pdr.GetString(2));
                pTreeNode.ToolTipText = pdr.GetString(3);
                pTreeNode.Tag = "Top node";
                MarketTree.Nodes.Add(pTreeNode);
                GetChldNode(pdr.GetInt32(0),pTreeNode);
            }
            pdr.Close();
            //SQLiteDataAdapter dapt = new SQLiteDataAdapter(cmd);
            //DataTable dtab = new DataTable();
            //dapt.Fill(dtab);
            
            //dtab.Select("parentGroupID is null");
            //MarketSalesDG.DataSource = dtab;
            //Get data from datatable
            //dtab.Rows[0][0] row/column
        }

        //Get child node
        private void GetChldNode(int ParentGroupID,TreeNode pTreeNode)
        {
            //Fill sub node
            SQLiteCommand chldCmd = new SQLiteCommand();
            chldCmd.Connection = m_DBConn;
            chldCmd.CommandText = "select * from invMarketGroups where parentGroupID =" + ParentGroupID.ToString();
            SQLiteDataReader chldDR = chldCmd.ExecuteReader();
            if (chldDR.HasRows)
            {
                while (chldDR.Read())
                {
                    TreeNode chldTreeNode = new TreeNode(chldDR.GetString(2));
                    chldTreeNode.ToolTipText = chldDR[3].ToString();
                    chldTreeNode.Tag = "Parent node.";
                    pTreeNode.Nodes.Add(chldTreeNode);
                    GetChldNode(chldDR.GetInt32(0), chldTreeNode);
                }
                
            }
            else
            {
                //End of nodes and close reader
                chldDR.Close();
                //Add info from invType
                SQLiteCommand chldTypeCmd = new SQLiteCommand();
                chldTypeCmd.Connection = m_DBConn;
                chldTypeCmd.CommandText = "select * from invTypes where marketGroupID =" + ParentGroupID.ToString();
                SQLiteDataReader chldTypeDR = chldTypeCmd.ExecuteReader();
                while (chldTypeDR.Read())
                {
                    TreeNode chldTNode = new TreeNode(chldTypeDR.GetString(2));
                    chldTNode.ToolTipText = chldTypeDR[3].ToString();
                    chldTNode.Tag = chldTypeDR.GetInt32(0);
                    pTreeNode.Nodes.Add(chldTNode);
                }
                chldTypeDR.Close();

            }
            

            
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void MarketTab_Resize(object sender, EventArgs e)
        {
            //CtlResize();
        }
        
        private void RefreshDBBtn_Click(object sender, EventArgs e)
        {
            //Test prog
            LogRTxt.Text = "test log."+Environment.NewLine;
            //YAML DotNet test
            YamlDocument ydoc = new YamlDocument(@"\YC-118-3_1.0_117575\groupIDs.YAML");
            var ystream = new YamlStream(ydoc);
            //TextReader ytr = new StreamReader("");
            LogRTxt.Text += ystream.First().AllNodes.ToString();
            
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //Define ctrls size
           // CtlResize();

            //Open database
            string strConn = "Data Source=eve.db;version=3;Read Only= True;";
            m_DBConn = new SQLiteConnection(strConn);
            m_DBConn.Open();
           // 
            
         }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //close databse 
            m_DBConn.Close();
        }

        private void MarketTree_DragOver(object sender, DragEventArgs e)
        {
            MessageBox.Show("Draged");
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RefreshMarketBtn_Click(object sender, EventArgs e)
        {
            FillMarketTree();
            
        }

        private void MarketTree_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            
            MessageBox.Show("clicked");
        }

        private void MarketTree_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            MessageBox.Show(MarketTree.SelectedNode.Tag.ToString());
        }
    }
}
