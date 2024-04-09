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

        public MeetingSettings GetSettings()
        {
            var meetingRoomSettings = _configuration.GetSection("MeetingRoomSettings")
                .Get<MeetingSettings>() ?? throw new ArgumentNullException();
            return meetingRoomSettings;
        }

        void IMeetingSettingsServise.SaveSettings(MeetingSettings meetingSettings)
        {
            var settingsPath = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.Development.json");
            var appSettingsJson = File.ReadAllText(settingsPath) ?? throw new NullReferenceException("File does not exists");

            var appSettings = JObject.Parse(appSettingsJson);

            appSettings["MeetingRoomSettings"]["MaxPeople"] = meetingSettings.MaxPeople; 
            appSettings["MeetingRoomSettings"]["MaxTime"] = meetingSettings.MaxTime; 

            File.WriteAllText(settingsPath, appSettings.ToString());

            ((IConfigurationRoot)_configuration).Reload();
        }

    }
}