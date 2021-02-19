using System;
using System.Collections.Generic;
using System.Text;

namespace ZenithFit.Model.Requests
{
    public class CommentsInsertRequest
    {
        public int ArticleId { get; set; }
        public int ClientId { get; set; }
        public string Text { get; set; }
        public DateTime CommentDate { get; set; }
    }
}
