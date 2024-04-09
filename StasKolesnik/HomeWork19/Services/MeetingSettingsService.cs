using HomeWork_16.Models;
using Newtonsoft.Json.Linq;

namespace HomeWork_16.Services;
public class MeetingSettingsService : IMeetingSettingsService
{
    private readonly IConfiguration _configuration;
    private string _appSettingsPath;

    public MeetingSettingsService(IConfiguration configuration)
    {
        _configuration = configuration;
        _appSettingsPath = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");
    }

    public MeetingSettingsModel GetMeetingSettings()
    {
        var meetingRoomSettings = _configuration.GetSection("MeetingSettings")
            .Get<MeetingSettingsModel>();

        return meetingRoomSettings ?? new MeetingSettingsModel();
    }

    public void UpdateMeetingSettings(MeetingSettingsModel model)
    {
        var appSettingsJson = JObject.Parse(File.ReadAllText(_appSettingsPath));
        var meetingSettingsJson = JObject.FromObject(model);
        appSettingsJson["MeetingSettings"] = meetingSettingsJson;
        File.WriteAllText(_appSettingsPath, appSettingsJson.ToString());
        ((IConfigurationRoot)_configuration).Reload();
    }
}