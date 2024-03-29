namespace HomeTask15Web
{
    class SettingsService
    {
        public void GetMeSettings(Person settings)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
             Console.WriteLine($"Name:{settings.Name},Lastname:{settings.LastName},This user is sharring now: {settings.UserIsSharing}");
        }
    }
}
