using Scheduler.Context;
using Scheduler.Models;

class Program
{
    static void Main(string[] args)
    {

        using (var context = new ScheduleContext())
        {
            ScheduleItem item = new ScheduleItem() { ClassroomName = "A 101" };

            context.ScheduleItems.Add(item);
            context.SaveChanges();
        }
    }
}