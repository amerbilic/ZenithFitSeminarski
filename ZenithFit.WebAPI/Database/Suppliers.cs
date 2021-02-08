using System;
using System.Collections.Generic;

namespace ZenithFit.WebAPI.Database
{
    public partial class Suppliers
    {
        public Suppliers()
        {
            Procurements = new HashSet<Procurements>();
        }

        public int SupplierId { get; set; }
        public string SupplierName { get; set; }
        public string SupplierContact { get; set; }
        public string SupplierAddress { get; set; }
        public string SupplierPhone { get; set; }
        public string SupplierWeb { get; set; }
        public string SupplierEmail { get; set; }
        public string SupplierBankAccount { get; set; }
        public string SupplierNote { get; set; }
        public bool SupplierStatus { get; set; }

        public virtual ICollection<Procurements> Procurements { get; set; }
    }
}
