using System;
using System.Collections.Generic;
using System.Text;

namespace ZenithFit.Model
{
    public class Articles
    {
        public int ArticleID { get; set; }
        public string ArticleName { get; set; }
        public string ArticleCode { get; set; }
        public decimal ArticlePrice { get; set; }
        public byte[] ArticlePicture { get; set; }
        public byte[] ArticlePictureThumb { get; set; }
        public bool? ArticleStatus { get; set; }
        public decimal AveragePrice { get; set; }
        public int CategoryId { get; set; }
        public int ManufacturerId { get; set; }

        public string CategoryName { get; set; }

        public string ManufacturerName { get; set; }

    }
}
