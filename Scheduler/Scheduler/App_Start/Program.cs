using SchedulerDatabase;
using Scheduler.Models;
using System;
using System.Diagnostics;

public static class ScheduleDatabase
{
    public static void Initialize()
    {

        using (var context = new ScheduleContext())
        {
            ScheduleItem item = new ScheduleItem() { ClassroomName = "A 101", DateFrom = DateTime.Now, DateTo = DateTime.Now };
            var created = context.Database.CreateIfNotExists();
            if (created) Debug.WriteLine("Created"); else Debug.WriteLine("Not created");
            context.ScheduleItems.Add(item);
            var hasChanges = context.ChangeTracker.HasChanges();
            if (hasChanges) Debug.WriteLine("Model has changes"); else Debug.WriteLine("Model doesn't have changes");
            var result = context.SaveChanges();
            Debug.WriteLine(string.Format("Result: {0}", result));
        }
    }
}