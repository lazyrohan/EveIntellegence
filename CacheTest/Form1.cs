using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CacheParser.MethodCall;
using System.Data.SQLite;

namespace CacheTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ParseCacheBtn_Click(object sender, EventArgs e)
        {
            LogInfoEdit.Clear();
            if (m_sSelectedMethodCall == null)
            {
                MessageBox.Show("Choose a methodCall first. Show charorder for example.");
                m_sSelectedMethodCall = "GetCharOrders";
            }
            label1.Text = m_sSelectedMethodCall;
            label1.Refresh();
            LogInfoEdit.Clear();
            LogInfoEdit.Text = ParseMethodCall.ParseCall(m_sSelectedMethodCall);
            LogInfoEdit.Refresh();
                
        }

        private void MethodCallsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Set current selected MethodCall
            m_sSelectedMethodCall = MethodCallsList.Text;

        }

        //
        private string m_sSelectedMethodCall;

    }
}
