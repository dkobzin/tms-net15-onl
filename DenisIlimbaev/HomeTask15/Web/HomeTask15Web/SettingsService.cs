namespace HomeTask15Web
{
    
    public class SettingsService : ISettings
    {
        private readonly IConfiguration _configuration;
        public SettingsService(IConfiguration config)
        {
            _configuration = config;
        }
        public void GetMeSettings()
        {
            var settings = _configuration.GetSection("MeetingSettings")
            .Get<Person>();
            if (settings != null)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($"Name:{settings.Name},Lastname:{settings.LastName},This user is sharring now: {settings.UserIsSharing}");
            }
             
        }
    }
}
