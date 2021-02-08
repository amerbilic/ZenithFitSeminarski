using System;
using System.Collections.Generic;
using System.Text;

namespace ZenithFit.Model
{
    public class Procurements
    {
        public int ProcurementId { get; set; }
        public string ProcurementNumber { get; set; }
        public DateTime ProcurementDate { get; set; }
        public decimal ProcurementAccountAmount { get; set; }
        public decimal ProcurementTax { get; set; }
        public string ProcurementNote { get; set; }
        public string WarehouseName { get; set; }
        public string SupplierName { get; set; }
        public string ContactPerson { get; set; }
        public string ContactPhone { get; set; }

        public int WarehouseId { get; set; }
        public int UserId { get; set; }
        public int SupplierId { get; set; }
    }
}
