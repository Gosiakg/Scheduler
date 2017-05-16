using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Scheduler.Models
{
    public class Schedule
    {
        public Schedule()
        { }
        public long Id { get; set; }
        public IList<ScheduleItem> ScheduleItems { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
    }

    
}