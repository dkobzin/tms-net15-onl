using HomeWork16_17.Models;

namespace HomeWork16_17.Services
{
    public interface IMeetingRoomSettingsService
    {
        MeetingRoomSettings GetSettings(string meetingRoomName);
        void SaveSettings(string meetingRoomName, MeetingRoomSettings newSettings);
    }
}

