using System;
using System.Collections.Generic;
using System.Text;

namespace ZenithFit.Model
{
    public class CompleteOrder
    {
        public int CompleteOrderId { get; set; }
        public int ClientId { get; set; }
        public int UserId { get; set; }
        public DateTime CompleteOrderDate { get; set; }
        public bool CompleteOrderSent { get; set; }
        public int OrderId { get; set; }
    }
}
