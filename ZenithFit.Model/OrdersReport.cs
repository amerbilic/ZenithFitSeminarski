using System;
using System.Collections.Generic;
using System.Text;

namespace ZenithFit.Model
{
    public class OrdersReport
    {
        public string OrderNumber { get; set; }
        public DateTime Date { get; set; }
        public decimal AmountWithTax { get; set; }
        public decimal AmountWithNoTax { get; set; }


    }
}
