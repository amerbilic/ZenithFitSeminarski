using System;
using System.Collections.Generic;
using System.Text;

namespace ZenithFit.Model
{
    public class Messages
    {
        public int MessageId { get; set; }
        public string Text { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool Sender { get; set; }
        public int ClientId { get; set; }

    }
}
