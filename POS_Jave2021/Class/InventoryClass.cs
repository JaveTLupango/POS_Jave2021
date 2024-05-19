﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_Jave2021.Class
{
    public class InventoryClass
    {
        public static OleDbConnection _conn = null;
        public InventoryClass(OleDbConnection conn)
        {
            _conn = conn;
        }

        public DataTable getListofInventory()
        {
            try
            {
                _conn.Close();
                DataTable dt = new DataTable();
                string query = "Select inv.inv_id as ID, inv.product_id as ProductID, pro.item_name as Name, pro.item_description as Description, inv.selling_price as Price, inv.available_inv as Stocks from [tbl_inv] as inv inner join [tbl_products] as pro on inv.product_id = pro.item_id" +
                    " where inv.available_inv > 0";
                using (OleDbCommand command = new OleDbCommand(query, _conn))
                {
                    _conn.Open();
                    OleDbDataAdapter da = new OleDbDataAdapter(command);
                    da.Fill(dt);
                    _conn.Close();
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable customOrderLayout()
        { 
            var dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("InvID");
            dt.Columns.Add("Name");
            dt.Columns.Add("QTY");
            dt.Columns.Add("Price");
            dt.Columns.Add("TotalPrice");
            dt.Columns.Add("IsCancel");
            dt.Columns.Add("Remarks");
            return dt;
        }
    }
}
