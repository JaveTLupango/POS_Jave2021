using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_Jave2021.Model
{
    public class cashierBtnEnabilityModel
    {        
        public bool _isReady { get; set; }
        public bool _isProceed { get; set; }
        public bool _IsReset { get; set; }
        public bool _IsEnterCash { get; set; }
        public bool _IsVoid { get; set; }
        public bool _IsDebtCredit { get; set; }
    }
}
