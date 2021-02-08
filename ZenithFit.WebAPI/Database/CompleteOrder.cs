using System;
using System.Collections.Generic;

namespace ZenithFit.WebAPI.Database
{
    public partial class CompleteOrder
    {
        public int CompleteOrderId { get; set; }
        public int ClientId { get; set; }
        public int UserId { get; set; }
        public DateTime CompleteOrderDate { get; set; }
        public bool CompleteOrderSent { get; set; }
        public int OrderId { get; set; }

        public virtual Clients Client { get; set; }
        public virtual Orders Order { get; set; }
        public virtual Users User { get; set; }
    }
}
