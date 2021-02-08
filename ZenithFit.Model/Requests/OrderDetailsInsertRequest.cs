using System;
using System.Collections.Generic;
using System.Text;

namespace ZenithFit.Model.Requests
{
    public class OrderDetailsInsertRequest
    {
        public int OrderId { get; set; }
        public decimal Amount { get; set; }
        public decimal Price { get; set; }
        public decimal? Discount { get; set; }
        public int? ArticleId { get; set; }
    }
}
