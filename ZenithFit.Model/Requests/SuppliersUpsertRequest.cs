using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ZenithFit.Model.Requests
{
    public class SuppliersUpsertRequest
    {
        [Required(AllowEmptyStrings = false)]
        public string SupplierName { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string SupplierContact { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string SupplierAddress { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string SupplierPhone { get; set; }
        public string SupplierWeb { get; set; }
        [MinLength(3)]
        public string SupplierEmail { get; set; }
        public string SupplierBankAccount { get; set; }
        public string SupplierNote { get; set; }
        public bool SupplierStatus { get; set; }
    }
}
