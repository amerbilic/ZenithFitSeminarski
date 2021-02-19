using System;
using System.Collections.Generic;
using System.Text;

namespace ZenithFit.Model
{
    public class OrderDetails
    {
        public int OrderDetailsID { get; set; }
        public int OrderId { get; set; }
        public int Amount { get; set; }
        public decimal Price { get; set; }
        public decimal? Discount { get; set; }
        public int? ArticleId { get; set; }
        public string ArticleArticleCode { get; set; }
        public string ArticleArticleName { get; set; }
    }
}
