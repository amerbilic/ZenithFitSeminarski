using System;
using System.Collections.Generic;
using System.Text;

namespace ZenithFit.Model.Requests
{
    public class ArticlesSearchRequest
    {
        public int? CategoryID { get; set; }
        public int? ManufacturerID { get; set; }

        public string ArticleName { get; set; }

        public string ArticleCode { get; set; }

    }
}
