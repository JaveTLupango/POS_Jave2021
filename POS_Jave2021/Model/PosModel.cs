using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_Jave2021.Model
{
    public class PosModel
    {
        public int ID { get; set; }
        public string pos_id { get; set; }
        public string total_inv { get; set; }
        public decimal total_price { get; set; }
        public decimal cash { get; set; }
        public decimal change { get; set; }
        public string user_id { get; set; }
    }
}
