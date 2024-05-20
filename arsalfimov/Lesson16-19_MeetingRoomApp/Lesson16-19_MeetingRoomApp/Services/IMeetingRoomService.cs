using Lesson16_19_MeetingRoomApp.Models;

namespace Lesson16_19_MeetingRoomApp.Services;

public interface IMeetingRoomService
{
    MeetingRoomSettings GetSettings(string name);
    IEnumerable<MeetingRoomSettings> GetAllSettings();
    void UpdateSettings(MeetingRoomSettings settings);
    void Reload();
}
