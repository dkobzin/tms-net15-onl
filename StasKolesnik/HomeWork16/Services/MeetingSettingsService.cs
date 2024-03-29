using HomeWork_16.Models;

namespace HomeWork_16.Services;
public class MeetingSettingsService : IMeetingSettingsService
{
    private readonly IConfiguration _configuration;

    public MeetingSettingsService(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public MeetingSettingsModel GetMeetingSettings()
    {
        var meetingRoomSettings = _configuration.GetSection("MeetingSettings")
            .Get<MeetingSettingsModel>();

        return meetingRoomSettings ?? new MeetingSettingsModel();
    }
}