public class Standard
{
    public Standard()
    {

    }
    public int StandardId { get; set; }
    public string StandardName { get; set; }

    public ICollection<ScheduleItem> ScheduleItems { get; set; }

}