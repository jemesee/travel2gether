using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace travel2gether.Models
{
    public class News
    {
        [Key]
        public int Id { get; set; }
        public string Header { get; set; }
        public string Body { get; set; }
        public string Hashtag { get; set; }
        public string PicSrc { get; set; }
        public string Date { get; set; }
    }
}
