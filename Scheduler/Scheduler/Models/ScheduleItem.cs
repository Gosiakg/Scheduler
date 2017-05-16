

using System;

namespace Scheduler.Models
{
    public class ScheduleItem
    {
        public ScheduleItem()
        {

        }

        public long Id { get; set; }
        public string ClassroomName { get; set; }
        public string Teacher { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }

        public Schedule Schedule { get; set; }
    }
}