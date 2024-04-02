using hw16.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace hw16.Services
{
    public class MeetingSettingsService : IGetRoomSettings
    {
        private readonly IConfiguration _configuration;

        public MeetingSettingsService(IConfiguration configuration)
        {
           _configuration = configuration;
        }

        void IGetRoomSettings.SaveSettings(MeetingSettings meetingSettings)
        {
            
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

/*1.Взять предыдущее ДЗ. 
2.Добавить в контроллер HttpPost для модифицирования настроек митинг-комнаты
3.Модифицировать класс сервиса для сохранения экземпляра настроек митинг-комнаты в appSetting.json.
4.* Добавить возможность получать настройки и сохранять настройки в виде коллекций митинг-комнат
различающиеся по именам.
*/
