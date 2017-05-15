

using System;

namespace Scheduler.Models
{
    public class ScheduleItem
    {
        public ScheduleItem()
        {

        }
        public string ClassroomName { get; set; }
        public string Teacher { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
    }
}