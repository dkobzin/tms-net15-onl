using Lesson16.Services;
using Lesson16.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lesson16.Controllers
{
    public class MeetingRoomController(IMeetingRoomSettingsService settingsService) : Controller
    {
        private readonly IMeetingRoomSettingsService _settingsService = settingsService;

        public IActionResult Index()
        {
            var settings = _settingsService.GetMeetingRoomSettings();
            return View(settings);
        }
    }
}