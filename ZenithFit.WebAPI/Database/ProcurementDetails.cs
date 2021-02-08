using System;
using System.Collections.Generic;

namespace ZenithFit.WebAPI.Database
{
    public partial class ProcurementDetails
    {
        public int ProcurementDetailId { get; set; }
        public int ProcurementId { get; set; }
        public int ArticleId { get; set; }
        public int Amount { get; set; }
        public decimal Price { get; set; }

        public virtual Articles Article { get; set; }
        public virtual Procurements Procurement { get; set; }
    }
}
