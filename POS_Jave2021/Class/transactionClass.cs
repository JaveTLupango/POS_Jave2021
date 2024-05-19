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
    public class transactionClass
    {

        public static OleDbConnection _conn = null;
        public transactionClass(OleDbConnection conn)
        {
            _conn = conn;
        }

        public async Task<ResponseModel> insertTransaction(string userid,
            DataTable orders,
            decimal totalorderprice,
            decimal cashOrder,
            decimal cashChange)
        {
            var res = new ResponseModel();
            try
            {

            }
            catch (Exception)
            {

                throw;
            }

            return res;
        }
    }
}
