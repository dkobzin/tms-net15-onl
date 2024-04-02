using hw16.Models;

namespace hw16.Services
{
    public interface IGetRoomSettings
    {
        void SaveSettings(MeetingSettings meetingSettings);
        MeetingSettings GetSettings();
    }
}
