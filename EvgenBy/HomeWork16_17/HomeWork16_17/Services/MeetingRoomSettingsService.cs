using HomeWork16_17.Models;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace HomeWork16.Services
{
    public class MeetingRoomSettingsService : IMeetingRoomSettingsService
    {
        private readonly IConfiguration _configuration;

        public MeetingRoomSettingsService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public MeetingRoomSettings GetSettings()
        {

            return GetSettings(string.Empty);
        }

        public MeetingRoomSettings GetSettings(string meetingRoomName)
        {
            var meetingRoomSettings = _configuration.GetSection($"MeetingRoomSettings:{meetingRoomName}").Get<MeetingRoomSettings>();
            return meetingRoomSettings;
        }

        public void SaveSettings(string meetingRoomName, MeetingRoomSettings newSettings)
        {
            var json = JsonConvert.SerializeObject(newSettings);
            var configuration = _configuration as IConfigurationRoot;
            var configPath = configuration?.FilePath;

            var existingSettings = configuration?.GetSection("MeetingRoomSettings").GetChildren();
            var newSettingsDict = new Dictionary<string, MeetingRoomSettings>();

            foreach (var section in existingSettings)
            {
                var existingSetting = section.Get<MeetingRoomSettings>();
                newSettingsDict.Add(section.Key, existingSetting);
            }

            newSettingsDict[meetingRoomName] = newSettings;

            var newJson = JsonConvert.SerializeObject(newSettingsDict, Formatting.Indented);
            File.WriteAllText(configPath, newJson);
        }
    }
}
