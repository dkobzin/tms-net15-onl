using Lesson17_18.Models;

namespace Lesson17_18.Services;

public class MeetingServices(IConfiguration configuration) : IMeetingService
{
    public Meeting GetRoom() 
    {
        var peoples = configuration.GetValue<int>("PeopleCount");
        var durationMinutes = configuration.GetValue<int>("Time");
        return new Meeting() { PeopleCount = peoples, Time = durationMinutes };
    }

    public bool UpdateRoom(Meeting meeting)
    {
        configuration["PeopleCount"] = meeting.PeopleCount.ToString();
        configuration["Time"] = meeting.Time.ToString();
        return true;
    }
}