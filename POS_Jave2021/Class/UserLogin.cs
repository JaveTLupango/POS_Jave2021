using POS_Jave2021.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_Jave2021.Class
{
    public class UserLogin
    {

        public bool login(userModel model, OleDbConnection conn)
        {
            try
            {
                DataTable dtResult = new DataTable();
                string query = "SELECT * FROM tbl_users WHERE username = @username AND [password] = @password ";

                using (OleDbCommand command = new OleDbCommand(query, conn))
                {
                    conn.Open();
                    command.Parameters.AddWithValue("@username", model.username); 
                    command.Parameters.AddWithValue("@password", model.password);
                    OleDbDataAdapter da = new OleDbDataAdapter(command);
                    da.Fill(dtResult);
                    conn.Close();

                    return dtResult.Rows.Count > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error during login: " + ex.ToString());
                return false;
            }
        }

    }

}

