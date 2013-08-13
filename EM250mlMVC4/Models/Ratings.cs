using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EM250mlMVC4.Models
{
    public class Ratings
    {
        public int ID { get; set; }
        public int rating { get; set; }
        public String comment { get; set; }
        public String username { get; set; }
        public Events ratedEvent { get; set; }
    }
}