using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ZenithFit.Model.Requests
{
    public class MessagesInsertRequest
    {
        [Required(AllowEmptyStrings = false)]
        public string Text { get; set; }
        [Required(AllowEmptyStrings = false)]
        [DataType(DataType.Date)]
        public DateTime CreatedDate { get; set; }
        [Required]
        public bool Sender { get; set; }

        [Required(AllowEmptyStrings = false)]
        public int ClientId { get; set; }
    }
}
