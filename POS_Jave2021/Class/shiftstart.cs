﻿using POS_Jave2021.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_Jave2021.Class
{
    public class shiftstart
    {
        public static OleDbConnection _conn = null;
        public shiftstart(OleDbConnection conn)
        {
            _conn = conn;
        }
        public ResponseModel Insert(shiftmodel model)
        {
            try
            {
                string query = "INSERT INTO [tbl_shifts_start] (user_id, shift_date, shift_In_amount, tdt)" +
                    "VALUES (@userid, @shiftdate, @shiftamount, @tdt)";
                using (OleDbCommand command = new OleDbCommand(query, _conn))
                {
                    _conn.Open();
                    command.Parameters.AddWithValue("@userid", model.user_id);
                    command.Parameters.AddWithValue("@shiftdate", model.shift_date);
                    command.Parameters.AddWithValue("@shiftamount", model.shift_amount);
                    command.Parameters.AddWithValue("@tdt", DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss"));
                    int rowsAffected = command.ExecuteNonQuery();
                    _conn.Close();
                    if (rowsAffected > 0)
                    {
                        return new ResponseModel
                        {
                            is_catch = false,
                            is_Success = true,
                            message = "Successfully Inserted!!",
                            title = "Success"

                        };
                    }
                    else
                    {
                        return new ResponseModel
                        {
                            is_catch = false,
                            is_Success = false,
                            message = "Unsuccessfully Inserted!!",
                            title = "Success"
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                _conn.Close();
                return new ResponseModel
                {
                    is_catch = true,
                    is_Success = false,
                    message = ex.Message
                };
            }
        }

        public bool shiftvalidate(string userid)
        {
            try
            {
                DataTable dt = new DataTable();
                string query = "Select * from [tbl_shifts_start] where user_id = '"+ userid +"' AND shift_date = '"+ DateTime.Now.ToString("MM/dd/yyyy") + "'";
                using (OleDbCommand command = new OleDbCommand(query, _conn))
                {
                    _conn.Open();
                    OleDbDataAdapter da = new OleDbDataAdapter(command);
                    da.Fill(dt);
                    _conn.Close();
                }
                return dt.Rows.Count > 0;
            }
            catch (Exception ex)
            {
                _conn.Close();
                throw ex;
            }
        }

        public DataTable getShiftIn(string userid)
        {
            try
            {
                DataTable dt = new DataTable();
                string query = "SELECT * FROM [tbl_shifts_start] WHERE shift_date = @tdt AND user_id = @id";
                using (OleDbCommand command = new OleDbCommand(query, _conn))
                {
                    _conn.Open();
                    command.Parameters.AddWithValue("@tdt", DateTime.Now.ToString("MM/dd/yyyy"));
                    command.Parameters.AddWithValue("@id", userid); 
                    OleDbDataAdapter da = new OleDbDataAdapter(command);
                    da.Fill(dt);
                    _conn.Close();
                }
                return dt;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool shiftOutAssistValidation()
        {
            string soAssist = ConfigurationManager.AppSettings["shiftOutAssistance"];
            if(Int32.Parse(soAssist) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public ResponseModel shiftOutUpdate(shiftmodel model)
        {
            string query = "UPDATE [tbl_shifts_start] " +
                "shift_Out_amount = @shiftamount, " +
                "out_dt = @tdt, " +
                "is_balance = @isBalance," +
                " disbalance_amount = @disbalanceAmount, " +
                "total_void_sales = @totalVoidSales, " +
                "assist_by = @assistedBy" +
                " Where user_id = @userid and shift_date = @shiftdate";
            using (OleDbCommand command = new OleDbCommand(query, _conn))
            {
                _conn.Open();
                command.Parameters.AddWithValue("@userid", model.user_id);
                command.Parameters.AddWithValue("@shiftdate", model.shift_date);
                command.Parameters.AddWithValue("@isBalance", model.is_balance);
                command.Parameters.AddWithValue("@disbalanceAmount", model.disbalance_amount);
                command.Parameters.AddWithValue("@totalVoidSales", model.total_void_sales);
                command.Parameters.AddWithValue("@assistedBy", model.assist_by);
                command.Parameters.AddWithValue("@tdt", DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss"));
                int rowsAffected = command.ExecuteNonQuery();
                _conn.Close();
                if (rowsAffected > 0)
                {
                    return new ResponseModel
                    {
                        is_catch = false,
                        is_Success = true,
                        message = "Successfully Inserted!!",
                        title = "Success"

                    };
                }
                else
                {
                    return new ResponseModel
                    {
                        is_catch = false,
                        is_Success = false,
                        message = "Unsuccessfully Inserted!!",
                        title = "Success"
                    };
                }
            }
        }
    }
}
