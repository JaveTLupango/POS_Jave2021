using MySql.Data.MySqlClient;
using POS_Jave2021.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_Jave2021
{
    public class UserRegistration
    {
        
        public bool register(userModel model, OleDbConnection conn)
        {

            try
            {

                string query = "INSERT INTO [tbl_users] (user_id, username, [password], lastname, firstname, middlename, phone_no, email, usertype, auth_factor, is_active, is_deleted) " +
               "VALUES (@user_id, @username, @password, @lastname, @firstname, @middlename, @phone_no, @email, @usertype, @auth_factor, @is_active, @is_deleted)";



                using (OleDbCommand command = new OleDbCommand(query, conn))
                {

                        conn.Open();
                        //command.Parameters.AddWithValue("@ID", 0);
                        command.Parameters.AddWithValue("@user_id", model.user_id);
                        command.Parameters.AddWithValue("@username", model.username);
                        command.Parameters.AddWithValue("@password", model.password);
                        command.Parameters.AddWithValue("@lastname", model.lastname);
                        command.Parameters.AddWithValue("@firstname", model.firstname);
                        command.Parameters.AddWithValue("@middlename", model.middlename);
                        command.Parameters.AddWithValue("@phone_no", model.phone_no);
                        command.Parameters.AddWithValue("@email", model.email);
                        command.Parameters.AddWithValue("@usertype", model.usertype);
                        command.Parameters.AddWithValue("@auth_factor", model.auth_factor);
                        command.Parameters.AddWithValue("@is_active", model.is_active);
                        command.Parameters.AddWithValue("@is_deleted", model.is_deleted);

                        int rowsAffected = command.ExecuteNonQuery();
                        conn.Close();

                        return rowsAffected > 0; 
                }
            
            
            }
            catch (Exception ex)
            {
                        Console.WriteLine("Error during registration: " + ex.Message);
                        return false;
            }
           


        }
    }
}
