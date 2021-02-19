using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ZenithFit.WebAPI.Database
{
    public class Comments
    {
        [Key]
        public int CommentId { get; set; }
        public int ArticleId { get; set; }
        public Articles Article { get; set; }
        public int ClientId { get; set; }
        public Clients Client { get; set; }
        public string Text { get; set; }
        public DateTime CommentDate { get; set; }

    }
}
