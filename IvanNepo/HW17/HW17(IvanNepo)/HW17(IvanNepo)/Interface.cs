namespace HW17_IvanNepo_
{
    public interface IMeetingRoomSettingsService
    {
        MeetingRoomSettings GetSettings(string name);
        void SaveSettings(string name, MeetingRoomSettings settings);
        IEnumerable<string> GetRoomNames();
    }

    public class MeetingRoomSettingsService : IMeetingRoomSettingsService
    {
        private readonly IConfiguration _configuration;

        public MeetingRoomSettingsService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public MeetingRoomSettings GetSettings(string name)
        {
            var settings = new MeetingRoomSettings();
            _configuration.GetSection($"MeetingRoomSettings:{name}").Bind(settings);
            return settings;
        }

        public void SaveSettings(string name, MeetingRoomSettings settings)
        {
            _configuration.GetSection($"MeetingRoomSettings:{name}").Bind(settings);
            _configuration.Save();
        }

        public IEnumerable<string> GetRoomNames()
        {
            var section = _configuration.GetSection("MeetingRoomSettings");
            return section.GetChildren().Select(x => x.Key);
        }
    }

}