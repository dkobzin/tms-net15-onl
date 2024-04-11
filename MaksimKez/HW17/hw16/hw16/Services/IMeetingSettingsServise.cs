using hw16.Models;

namespace hw16.Services
{
    public interface IMeetingSettingsServise
    {
        void SaveSettings(MeetingSettings meetingSettings);
        MeetingSettings GetSettings();
    }
}
