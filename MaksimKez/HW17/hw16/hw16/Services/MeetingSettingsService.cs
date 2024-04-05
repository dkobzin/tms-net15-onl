using hw16.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System.Text.Json.Serialization;
using System.Data;
using System.Linq.Expressions;
using System.Text.Json;
using Newtonsoft.Json.Linq;


namespace hw16.Services
{
    public class MeetingSettingsService : IMeetingSettingsServise
    {
        private readonly IConfiguration _configuration;

        public MeetingSettingsService(IConfiguration configuration)
        {
           _configuration = configuration;
        }

        void IMeetingSettingsServise.SaveSettings(MeetingSettings meetingSettings)
        {
            _configuration["MeetingRoomSettings"] = JsonSerializer.Serialize(meetingSettings);
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