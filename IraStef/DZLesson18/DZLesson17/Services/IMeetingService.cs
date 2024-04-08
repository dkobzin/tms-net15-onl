using DZLesson18.Models;

namespace DZLesson18.Services
{
    public interface IMeetingService
    {
        public MeetingView GetMeetings();
        public void UpdateMeetings(MeetingUpdate meetings);

    }
}
