using hw16.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace hw16.Services
{
    public class MeetingSettingsService : IGetRoomSettings
    {
        private readonly IConfiguration _configuration;

        public MeetingSettingsService(IConfiguration configuration)
        {
           _configuration = configuration;
        }

        public MeetingSettings GetSettings()
        {
            var meetingRoomSettings = _configuration.GetSection("MeetingRoomSettings")
                .Get<MeetingSettings>() ?? throw new ArgumentNullException();
            // подойдет ли такое исключение для этой ситуации?
            return meetingRoomSettings;
        }
    }
}
