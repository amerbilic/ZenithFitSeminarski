using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ZenithFit.WebAPI.Database
{
    public class Messages
    {
        [Key]
        public int MessageId { get; set; }
        public string Text { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool Sender { get; set; }
        public int ClientId { get; set; }
        public Clients Client { get; set; }
    }
}
