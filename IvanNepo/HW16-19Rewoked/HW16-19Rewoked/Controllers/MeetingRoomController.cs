using MeetingRoomSettingsApp.Models;
using MeetingRoomSettingsApp.Services;
using Microsoft.AspNetCore.Mvc;
using MeetingRoomSettingsApp.Filters;

namespace MeetingRoomSettingsApp.Controllers
{
    public class MeetingRoomController : Controller
    {
        private readonly MeetingRoomSettingsService _settingsService;
        public MeetingRoomController(MeetingRoomSettingsService settingsService)
        {
            _settingsService = settingsService;
        }
        public IActionResult Index()
        {
            var settings = _settingsService.GetSettings();
            return View(settings);
        }
        [HttpPost]
        public IActionResult ModifySettings(ModifyMeetingRoomSettingsViewModel model)
        {
            var newSettings = new MeetingRoomSettings
            {
                MaxPeople = model.MaxPeople,
                MaxMeetingDuration = model.MaxMeetingDuration
            };
            return RedirectToAction("Index");
        }
    }
}
