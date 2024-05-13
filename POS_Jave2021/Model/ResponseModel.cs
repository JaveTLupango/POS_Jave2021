using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_Jave2021.Model
{
    public class ResponseModel
    {
        public bool is_Success { get; set; }
        public string message { get; set; }
        public bool is_catch { get; set; }
        public string title { get; set; }
    }
}
