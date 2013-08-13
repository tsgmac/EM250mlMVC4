using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace EM250mlMVC4.Models
{
    public class EventsAndRatings : DbContext
    {
        public DbSet<Events> EventsDbSet { get; set; }
        public DbSet<Ratings> RatingsDbSet { get; set; }
    }
}