using System;
using System.Collections.Generic;

namespace ZenithFit.WebAPI.Database
{
    public partial class Orders
    {
        public Orders()
        {
            CompleteOrder = new HashSet<CompleteOrder>();
        }

        public int OrderId { get; set; }
        public string OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public bool OrderStatus { get; set; }
        public bool? OrderCancelled { get; set; }
        public decimal OrderPriceNoTax { get; set; }
        public decimal OrderPriceTax { get; set; }
        public int WarehouseId { get; set; }
        public int ClientId { get; set; }
        public int? UserId { get; set; }

        public virtual Clients Client { get; set; }
        public virtual Users User { get; set; }
        public virtual Warehouses Warehouse { get; set; }
        public virtual ICollection<CompleteOrder> CompleteOrder { get; set; }
    }
}
