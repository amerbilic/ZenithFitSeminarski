using System;
using System.Collections.Generic;

namespace ZenithFit.WebAPI.Database
{
    public partial class Ratings
    {
        public int RatingId { get; set; }
        public int ClientId { get; set; }
        public DateTime RatingDate { get; set; }
        public int RatingGrade { get; set; }
        public int ArticleId { get; set; }

        public virtual Articles Article { get; set; }
        public virtual Clients Client { get; set; }
    }
}
