using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;


namespace BlogNet.Models
{
    public class Blog
    {
        public int ID { get; set; }
        public string Title { get; set; }
        [DisplayName(" Year/s of Experience")]
        public string Time { get; set; }
        [StringLength(500, MinimumLength = 60)]
        public string Description { get; set; }
        [DisplayName("URL of the company’s logo")]
        public string UrlPic { get; set; }
    }
}
