using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ZenithFit.Model.Requests
{
    public class CompleteOrderInsertRequest
    {
        [Required]
        public int ClientId { get; set; }
        [Required]
        public int UserId { get; set; }
        [Required]
        public DateTime CompleteOrderDate { get; set; }
        public bool CompleteOrderSent { get; set; }
        [Required]
        public int OrderId { get; set; }
    }
}
