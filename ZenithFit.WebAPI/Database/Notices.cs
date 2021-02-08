using System;
using System.Collections.Generic;

namespace ZenithFit.WebAPI.Database
{
    public partial class Notices
    {
        public int NoticeId { get; set; }
        public string NoticeTitle { get; set; }
        public string NoticeText { get; set; }
        public byte[] NoticeImage { get; set; }
        public int UserId { get; set; }

        public virtual Users User { get; set; }
    }
}
