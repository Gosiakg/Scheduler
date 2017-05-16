using Scheduler.Models;
using System;
using System.Data.Entity;

namespace SchedulerDatabase
{
        
    public class ScheduleContext : DbContext
{
    public ScheduleContext() : base("name = ScheduleContext")
    {

    }

    public virtual DbSet<ScheduleItem> ScheduleItems { get; set; }
    public virtual DbSet<Schedule> Schedules { get; set; }

}
}