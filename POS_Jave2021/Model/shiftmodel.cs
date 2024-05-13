using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_Jave2021.Model
{
    public class shiftmodel
    {
        public int ID { get; set; }
        public string user_id { get; set; }
        public string shift_date { get; set; }
        public decimal shift_amount { get; set; }
    }
}
