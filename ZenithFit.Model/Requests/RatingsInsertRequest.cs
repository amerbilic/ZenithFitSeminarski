using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ZenithFit.Model.Requests
{
    public class RatingsInsertRequest
    {
        [Required]
        public int ArticleID { get; set; }
        [Required]
        public int ClientID { get; set; }
        [Required]
        public DateTime RatingDate { get; set; }
        [Required]
        public int RatingGrade { get; set; }
    }
}
