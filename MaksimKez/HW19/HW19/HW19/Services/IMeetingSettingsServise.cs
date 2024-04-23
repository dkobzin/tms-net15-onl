using HW19.Models;

namespace HW19.Services
{
    public interface IMeetingSettingsServise
    {
        void SaveSettings(MeetingSettings meetingSettings);
        MeetingSettings GetSettings();
    }
}
