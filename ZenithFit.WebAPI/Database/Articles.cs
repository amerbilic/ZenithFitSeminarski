using System;
using System.Collections.Generic;

namespace ZenithFit.WebAPI.Database
{
    public partial class Articles
    {
        public Articles()
        {
            OrderDetails = new HashSet<OrderDetails>();
            ProcurementDetails = new HashSet<ProcurementDetails>();
            Ratings = new HashSet<Ratings>();
        }

        public int ArticleId { get; set; }
        public string ArticleName { get; set; }
        public string ArticleCode { get; set; }
        public decimal ArticlePrice { get; set; }
        public byte[] ArticlePicture { get; set; }
        public byte[] ArticlePictureThumb { get; set; }
        public bool? ArticleStatus { get; set; }
        public int CategoryId { get; set; }
        public int ManufacturerId { get; set; }

        public virtual Categories Category { get; set; }
        public virtual Manufacturers Manufacturer { get; set; }
        public virtual ICollection<OrderDetails> OrderDetails { get; set; }
        public virtual ICollection<ProcurementDetails> ProcurementDetails { get; set; }
        public virtual ICollection<Ratings> Ratings { get; set; }
    }
}
