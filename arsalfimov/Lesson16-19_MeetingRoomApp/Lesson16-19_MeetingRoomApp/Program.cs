using Lesson16_19_MeetingRoomApp.Filters;
using Lesson16_19_MeetingRoomApp.Middleware;
using Lesson16_19_MeetingRoomApp.Models;
using Lesson16_19_MeetingRoomApp.Services;

namespace Lesson16_19_MeetingRoomApp;

public static class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddControllersWithViews(options =>
        {
            options.Filters.Add<RequestTimeFilter>();
        });

        builder.Services.Configure<List<MeetingRoomSettings>>(builder.Configuration.GetSection("MeetingRooms"));

        builder.Services.AddTransient<IMeetingRoomService, MeetingRoomService>();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Home/Error");
            app.UseHsts();
        }

        app.UseMiddleware<ExceptionMiddleware>();

        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseRouting();

        app.UseAuthorization();

        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=MeetingRoom}/{action=Index}/{id?}");

        app.Run();
    }
}
