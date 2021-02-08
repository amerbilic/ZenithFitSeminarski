using System;
using System.Collections.Generic;

namespace ZenithFit.WebAPI.Database
{
    public partial class Procurements
    {
        public Procurements()
        {
            ProcurementDetails = new HashSet<ProcurementDetails>();
        }

        public int ProcurementId { get; set; }
        public string ProcurementNumber { get; set; }
        public DateTime ProcurementDate { get; set; }
        public decimal ProcurementAccountAmount { get; set; }
        public decimal ProcurementTax { get; set; }
        public string ProcurementNote { get; set; }
        public int WarehouseId { get; set; }
        public int UserId { get; set; }
        public int SupplierId { get; set; }

        public virtual Suppliers Supplier { get; set; }
        public virtual Users User { get; set; }
        public virtual Warehouses Warehouse { get; set; }
        public virtual ICollection<ProcurementDetails> ProcurementDetails { get; set; }
    }
}
