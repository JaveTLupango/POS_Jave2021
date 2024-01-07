using MySql.Data.MySqlClient;
using POS_Jave2021.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_Jave2021.Class
{
    class connectionClass
    {
        /// <summary>
        /// Connection Conn
        /// </summary>
        public static MySqlConnection conn;

        /// <summary>
        /// ConnStringData
        /// </summary>
        /// <returns></returns>
        public static classConnection connStringData()
        {
            classConnection ret = new classConnection();
            //ret.host = ConfigurationManager.AppSettings["connHost"];
            //ret.dbname = ConfigurationManager.AppSettings["conndbName"];
            //ret.username = ConfigurationManager.AppSettings["connUsername"];
            //ret.password = ConfigurationManager.AppSettings["connPassword"];
            //constrings
            ret.constring = ConfigurationManager.AppSettings["constrings"];
            return ret;
        }
        /// <summary>
        /// connection String Process
        /// </summary>
        public static OleDbConnection connect()
        {
            //string connectionString;
            //connectionString = "SERVER=" + m.host + ";" + "DATABASE=" +
            //m.dbname + ";" + "UID=" + m.username + ";" + "PASSWORD=" + m.password + ";";
            //conn = new MySqlConnection(connectionString);
            //MessageBox.Show("Success");

            classConnection m = connStringData();
            OleDbConnection con = new OleDbConnection(@""+m.constring+"");
            return con;

        }
    }
}
