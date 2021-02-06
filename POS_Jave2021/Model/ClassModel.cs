using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_Jave2021.Model
{
    class ClassModel
    {
        MySqlConnection connection;
        public DataTable SelectFunction(MySqlConnection conn, string query)
        {
            DataTable res_dt = new DataTable();
            try
            {
                connection = conn;
                //open connection
                if (this.OpenConnection() == true)
                {
                    //create command and assign the query and connection from the constructor
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    //Execute command
                    cmd.ExecuteNonQuery();

                    //close connection
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                connection.Close();
                throw;
            }

            return res_dt;
        }

        /// <summary>
        /// Openconnection class function
        /// </summary>
        /// <returns></returns>
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                return false;
            }
        }
    }
}
