using Lesson16_19_MeetingRoomApp.Models;

namespace Lesson16_19_MeetingRoomApp.Services;
public class MeetingRoomService : IMeetingRoomService
{
    private readonly Dictionary<string, MeetingRoomSettings> _settings;
    private readonly IConfiguration _configuration;

    public MeetingRoomService(IConfiguration configuration)
    {
        _configuration = configuration;
        _settings = LoadSettingsFromConfiguration();
    }

    public MeetingRoomSettings GetSettings(string name)
    {
        if (string.IsNullOrEmpty(name))
        {
            throw new ArgumentNullException(nameof(name), "Room name cannot be null or empty");
        }

        return _settings.ContainsKey(name) ? _settings[name] : null;
    }

    public IEnumerable<MeetingRoomSettings> GetAllSettings()
    {
        return _settings.Values;
    }

    public void UpdateSettings(MeetingRoomSettings settings)
    {
        _settings[settings.Name] = settings;
    }

    public void Reload()
    {
        _settings.Clear();
        var newSettings = LoadSettingsFromConfiguration();
        foreach (var setting in newSettings)
        {
            _settings[setting.Key] = setting.Value;
        }
    }

    private Dictionary<string, MeetingRoomSettings> LoadSettingsFromConfiguration()
    {
        var meetingRoomSettings = new Dictionary<string, MeetingRoomSettings>();
        var meetingRoomsSection = _configuration.GetSection("MeetingRooms");

        foreach (var roomSection in meetingRoomsSection.GetChildren())
        {
            var roomSettings = roomSection.Get<MeetingRoomSettings>();
            meetingRoomSettings.Add(roomSettings.Name, roomSettings);
        }

        return meetingRoomSettings;
    }
}