//Class for data connection port with SQLite and YamlDotNet
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Import data libary
using System.Data;
using System.Data.SQLite;
using YamlDotNet.RepresentationModel;

namespace DataConnection 
{
    class SqliteConnection
    {
        //Sqlite database connection interface
        //Private connection member 
        private SQLiteConnection m_dbConn;
        void InitialConn(string dbFilePath)
        {
            //Open database
            if (dbFilePath == "")
            {
                throw new SQLiteException("Empty database file name.");
            }
            string strConn = "Data Source="+dbFilePath+"eve.db;version=3;Read Only= True;";
            m_dbConn = new SQLiteConnection(strConn);           
        }

        void CmdPrepare()
        {
            //Open database
            if (m_dbConn.State != ConnectionState.Open)
            {
                    m_dbConn.Open();
            }
        }
    }

    //Yaml file connection interface
    class YamlConnection
    {

    }
}
