public void ConfigureServices(IServiceCollection services)
{
    services.AddSingleton<IMeetingRoomSettingsService, MeetingRoomSettingsService>();
    services.AddControllersWithViews();
}