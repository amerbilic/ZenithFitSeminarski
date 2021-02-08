using System;
using System.Collections.Generic;
using System.Text;

namespace ZenithFit.Model
{
    public class Orders
    {
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
    }
}
