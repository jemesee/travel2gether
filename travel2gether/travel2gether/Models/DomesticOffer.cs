using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace travel2gether.Models
{
    public class DomesticOffer
    {
        [Key]
        public int Id { get; set; }
        public string Destination { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public int Cost { get; set; }
        public string PicSrc { get; set; }
        public string DetailsSrc { get; set; }
        public string ShortDescription { get; set; }
    }
}
