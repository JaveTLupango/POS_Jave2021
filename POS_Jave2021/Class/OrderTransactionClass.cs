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
    public class OrderTransactionClass
    {
        public OleDbConnection _conn;
        public OrderTransactionClass(OleDbConnection conn)
        {
            _conn = conn;
        }

        public ResponseModel InsertPosTransaction(PosModel model)
        {
            try
            {
                model.pos_id = DateTime.Now.ToString("yyyyMMddHHmmss");
                string query = "INSERT INTO [tbl_pos] (pos_id, total_inv, total_price, cash, change, tdt, udt, user_id)" +
                    "VALUES (@pos_id, @total_inv, @total_price, @cash, @change, @tdt, @upd, @userid)";
                using (OleDbCommand command = new OleDbCommand(query, _conn))
                {
                    _conn.Open();
                    command.Parameters.AddWithValue("@pos_id", model.pos_id);
                    command.Parameters.AddWithValue("@total_inv", model.total_inv);
                    command.Parameters.AddWithValue("@total_price", model.total_price);
                    command.Parameters.AddWithValue("@cash", model.cash);
                    command.Parameters.AddWithValue("@change", model.change);
                    command.Parameters.AddWithValue("@tdt", DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss"));
                    command.Parameters.AddWithValue("@upd", DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss"));
                    command.Parameters.AddWithValue("@userid", model.user_id);
                    int rowsAffected = command.ExecuteNonQuery();
                    _conn.Close();
                    if (rowsAffected > 0)
                    {
                        return new ResponseModel
                        {
                            is_catch = false,
                            is_Success = true,
                            message = model.pos_id,
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
        public ResponseModel InsertInvSold(DataTable dt, string transactionID)
        {

            try
            {
                foreach (DataRow dr in dt.Rows)
                {
                    string query = "INSERT INTO [tbl_inv_sold] (inv_id, product_id, price_cost, selling_price, tdt, qty, transaction_id, is_cancel, remarks)" +
                    "VALUES (@inv_id, @product_id, @price_cost, @selling_price, @tdt, @qty, @transaction_id, @is_cancel, @remarks)";

                    using (OleDbCommand command = new OleDbCommand(query, _conn))
                    {
                        _conn.Open();
                        command.Parameters.AddWithValue("@inv_id", dr["inv_id"].ToString());
                        command.Parameters.AddWithValue("@product_id", dr["product_id"].ToString());
                        command.Parameters.AddWithValue("@total_price", dr["total_price"].ToString());
                        command.Parameters.AddWithValue("@selling_price", dr["selling_price"].ToString());
                        command.Parameters.AddWithValue("@tdt", dr["tdt"].ToString());
                        command.Parameters.AddWithValue("@qty", dr["qty"].ToString());
                        command.Parameters.AddWithValue("@transaction_id", transactionID);
                        command.Parameters.AddWithValue("@is_cancel", dr["is_cancel"].ToString());
                        command.Parameters.AddWithValue("@remarks", dr["remarks"].ToString());
                        int rowsAffected = command.ExecuteNonQuery();
                        _conn.Close();                        
                    }
                }
                return new ResponseModel
                {
                    is_catch = false,
                    is_Success = true,
                    message = "Successfully Inserted",
                    title = "Success"
                };
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
    }
}
