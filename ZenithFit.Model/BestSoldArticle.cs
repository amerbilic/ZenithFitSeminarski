using System;
using System.Collections.Generic;
using System.Text;

namespace ZenithFit.Model
{
    public class BestSoldArticle
    {
        public int ArticleID { get; set; }
        public string ArticleName { get; set; }
        public string ArticleCode { get; set; }
        public decimal ArticlePrice { get; set; }
        public int OrderedTimes { get; set; }
        public int AmountSold { get; set; }
    }
}
