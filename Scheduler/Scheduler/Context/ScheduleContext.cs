using Scheduler.Models;
using System;
using System.Data.Entity;

namespace Scheduler.Context
{
        
    public class ScheduleContext : DbContext
{
    public ScheduleContext() : base()
    {

    }

    public DbSet<ScheduleItem> ScheduleItems { get; set; }
    public DbSet<Schedule> Schedules { get; set; }

}
}