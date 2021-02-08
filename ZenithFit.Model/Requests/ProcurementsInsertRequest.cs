using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ZenithFit.Model.Requests
{
    public class ProcurementsInsertRequest
    {
        [Required]
        [MinLength(4)]
        [RegularExpression(@"^[0-9]*$")]
        public string ProcurementNumber { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime ProcurementDate { get; set; }
        public decimal ProcurementAccountAmount { get; set; }
        public decimal ProcurementTax { get; set; }
        [MinLength(10)]
        public string ProcurementNote { get; set; }
        public int WarehouseId { get; set; }
        public int UserId { get; set; }
        public int SupplierId { get; set; }

        public List<ProcurementDetailsInsertRequest> Details { get; set; } = new List<ProcurementDetailsInsertRequest>();
    }
}
