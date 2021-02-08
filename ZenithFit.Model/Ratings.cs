using System;
using System.Collections.Generic;
using System.Text;

namespace ZenithFit.Model
{
    public class Ratings
    {
        public int RatingID { get; set; }
        public int ArticleID { get; set; }
        public int ClientID { get; set; }
        public int Rating { get; set; }
        public DateTime RatingDate { get; set; }

    }
}
