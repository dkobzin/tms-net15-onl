using System.Text.Json;
using HomeTask15Web.Models;
namespace HomeTask15Web.Service
{

    public class SettingsService : ISettingsService
    {
        private readonly IConfiguration _configuration;
        public SettingsService(IConfiguration config)
        {
            _configuration = config;
        }
        public MainSettingsModel GetMeSettings()
        {
            var settings = _configuration.GetSection("GeneralSettings").Get<General>();
            var userSettings = _configuration.GetSection("UserSettings").Get<Users>();
            return settings != null & userSettings != null ? new MainSettingsModel(settings!, userSettings!) : throw new NullReferenceException();
        }
        public void PostMeSettings(Container set)
        {
            string json = JsonSerializer.Serialize(set, new JsonSerializerOptions
            {
                WriteIndented = true
            });
            string path = "appsettings.json";
            using (StreamWriter sw = new StreamWriter(path, false))
            {
                sw.Write(json);
            }

        }
    }
}
