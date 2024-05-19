using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_Jave2021.Model
{
    public class customOrderLayoutModel
    {
        public int ID { get; set; }
        public string InvID { get; set; }
        public string Name { get; set; }
        public int QTY { get; set; }
        public decimal Price { get; set; }
        public decimal TotalPrice { get; set; }
        public bool IsCancel  { get; set; }
        public string Remarks { get; set; }
    }
}
