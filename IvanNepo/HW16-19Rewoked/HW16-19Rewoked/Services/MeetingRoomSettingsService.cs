using MeetingRoomSettingsApp.Models;
using Microsoft.Extensions.Options;

namespace MeetingRoomSettingsApp.Services
{
    public class MeetingRoomSettingsService
    {
        private readonly MeetingRoomSettings _settings;
        public MeetingRoomSettingsService(IOptions<MeetingRoomSettings> options)
        {
            _settings = options.Value;
        }
        public MeetingRoomSettings GetSettings()
        {
            return _settings;
        }
    }
}
