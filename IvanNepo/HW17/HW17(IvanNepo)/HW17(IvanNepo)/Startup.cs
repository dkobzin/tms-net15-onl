using HW17_IvanNepo_;

public void ConfigureServices(IServiceCollection services)
{
    services.AddSingleton<IMeetingRoomSettingsService, MeetingRoomSettingsService>();
    services.AddControllersWithViews();
}
{ endpoints.MapControllerRoute(
    name: "default",
    pattern: "{controller=MeetingRoom}/{action=Index}/{id?}");
}