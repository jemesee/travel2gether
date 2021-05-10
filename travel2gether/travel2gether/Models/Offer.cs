using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace travel2gether.Models
{
    public class Offer
    {
        [Key]
        public int id { get; set; }
        public string continent { get; set; }
        public string destination { get; set; }
        public string startTime { get; set; }
        public string endTime { get; set; }
        public int cost { get; set; }
        public string picSrc { get; set; }
        public string detailsSrc { get; set; }
        public string shortDescription { get; set; }
    }
}
