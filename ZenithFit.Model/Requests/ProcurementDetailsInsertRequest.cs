using System;
using System.Collections.Generic;
using System.Text;

namespace ZenithFit.Model.Requests
{
    public class ProcurementDetailsInsertRequest
    {
        public int ProcurementId { get; set; }
        public int ArticleId { get; set; }
        public int Amount { get; set; }
        public string Code { get; set; }
        public decimal Price { get; set; }
    }
}
