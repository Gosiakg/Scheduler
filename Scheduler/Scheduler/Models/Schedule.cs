using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Scheduler.Models
{
    public class Schedule: DbContext
    {
        public Schedule(): base()
        {
            
        }
        //public IList<ScheduleItem> ScheduleItems { get; set; }
        public DbSet<DateTime> DateFrom { get; set; }
        public DbSet<DateTime> DateTo { get; set; }
    }

    
}