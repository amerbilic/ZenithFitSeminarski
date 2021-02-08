using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ZenithFit.Model.Requests
{
    public class ArticlesUpsertRequest
    {
        [Required]
        public string ArticleName { get; set; }
        [Required]
        public string ArticleCode { get; set; }
        [Required]
        public decimal ArticlePrice { get; set; }
        [Required]
        public byte[] ArticlePicture { get; set; }
        public byte[] ArticlePictureThumb { get; set; }
        public bool? ArticleStatus { get; set; }
        [Required]
        public int CategoryId { get; set; }
        [Required]
        public int ManufacturerId { get; set; }
    }
}
