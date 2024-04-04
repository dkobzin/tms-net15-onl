using DZLesson17.Models;

namespace DZLesson17.Services
{
    public interface IMeetingService
    {
        public Meeting[] GetMeetings();
        public void UpdateMeetings(Meeting[] meetings);

    }
}
