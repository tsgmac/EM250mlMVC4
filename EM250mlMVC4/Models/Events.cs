using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EM250mlMVC4.Models
{
    public class Events
    {
        public int ID { get; set; }
        public String name { get; set; }
        public String description { get; set; }
        public DateTime startdate { get; set; }
        public DateTime enddate { get; set; }
        public int ratingsSum { get; set; }
        public int ratingsCount { get; set; }
        public List<Ratings> ratings { get; set; }
    }
}