using System;
using System.Collections.Generic;
using System.Text;

namespace ZenithFit.Model
{
    public class SoldArticles
    {
        public string ArticleName { get; set; }
        public string ArticleCode { get; set; }
        public decimal ArticlePrice { get; set; }
        public int Amount { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
