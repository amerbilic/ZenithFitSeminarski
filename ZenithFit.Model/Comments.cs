using System;
using System.Collections.Generic;
using System.Text;

namespace ZenithFit.Model
{
    public class Comments
    {
        public int CommentId { get; set; }
        public int ArticleId { get; set; }
        public int ClientId { get; set; }
        public string Text { get; set; }
        public string ClientClientUsername { get; set; }
        public string ArticleArticleName { get; set; }
        public DateTime CommentDate { get; set; }
    }
}
