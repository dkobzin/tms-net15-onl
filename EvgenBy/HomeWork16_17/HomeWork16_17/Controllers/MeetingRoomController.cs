using HomeWork16_17.Models;
using HomeWork16_17.Services;
using Microsoft.AspNetCore.Mvc;

namespace HomeWork16_17.Controllers
{
    public class MeetingRoomController : Controller
    {
        private readonly IMeetingRoomSettingsService _settingsService;

        public MeetingRoomController(IMeetingRoomSettingsService settingsService)
        {
            _settingsService = settingsService;
        }

        public IActionResult Index(string meetingRoomName)
        {
            var settings = _settingsService.GetSettings(meetingRoomName);
            return View(settings);
        }

        [HttpPost]
        public IActionResult ModifySettings(string meetingRoomName, MeetingRoomSettings newSettings)
        {
            if (ModelState.IsValid)
            {
                _settingsService.SaveSettings(meetingRoomName, newSettings);
                return RedirectToAction("Index", new { meetingRoomName });
            }
            return View("Index", newSettings);
        }
    }
}
