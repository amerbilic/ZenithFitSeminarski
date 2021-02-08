using System;
using System.Collections.Generic;

namespace ZenithFit.WebAPI.Database
{
    public partial class Warehouses
    {
        public Warehouses()
        {
            Orders = new HashSet<Orders>();
            Procurements = new HashSet<Procurements>();
        }

        public int WarehouseId { get; set; }
        public string WarehouseName { get; set; }
        public string WarehouseAddress { get; set; }
        public string WarehouseNote { get; set; }

        public virtual ICollection<Orders> Orders { get; set; }
        public virtual ICollection<Procurements> Procurements { get; set; }
    }
}
