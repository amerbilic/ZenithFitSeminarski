using System;
using System.Collections.Generic;

namespace ZenithFit.WebAPI.Database
{
    public partial class OrderDetails
    {
        public int OrderDetailsId { get; set; }
        public int OrderId { get; set; }
        public int Amount { get; set; }
        public decimal Price { get; set; }
        public decimal? Discount { get; set; }
        public int? ArticleId { get; set; }

        public virtual Articles Article { get; set; }
    }
}
