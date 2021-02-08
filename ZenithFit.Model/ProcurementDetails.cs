using System;
using System.Collections.Generic;
using System.Text;

namespace ZenithFit.Model
{
    public class ProcurementDetails
    {
        public int ProcurementDetailId { get; set; }
        public int ProcurementId { get; set; }
        public int ArticleId { get; set; }
        public int Amount { get; set; }
        public decimal Price { get; set; }
    }
}
