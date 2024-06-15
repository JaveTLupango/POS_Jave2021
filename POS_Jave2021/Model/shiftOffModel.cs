using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_Jave2021.Model
{
    public class shiftOffModel
    {
        public decimal ShiftInAmount { get; set; }
        public decimal TotalSales { get; set; }
        public decimal TotalSalesWithOutDebtCredit { get; set; }
        public decimal VoidSales { get; set; }
        public bool IsBalance { get; set; }
        public decimal DisbalanceAmount { get; set; }
        public decimal ExpectedCashOnHand { get; set; }
        public decimal totalDebtCredit { get; set; }
        public decimal CashOnHand { get; set; }
    }
}
