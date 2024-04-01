using Lesson16.Models;

namespace Lesson16.Services
{
    public class MeetingRoomSettingsService : IMeetingRoomSettingsService
    {
        private readonly MeetingRoomSettings _settings;

        public MeetingRoomSettingsService()
        {
            _settings = new MeetingRoomSettings
            {
                MaxCapacity = 15,
                MaxMeetingDuration = TimeSpan.FromHours(6) + TimeSpan.FromMinutes(30),
            };
        }

        public MeetingRoomSettings GetMeetingRoomSettings()
        {
            return _settings;
        }
    }
}
