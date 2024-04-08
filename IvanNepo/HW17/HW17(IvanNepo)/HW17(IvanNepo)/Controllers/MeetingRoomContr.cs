using Microsoft.AspNetCore.Mvc;

namespace HW17_IvanNepo_.Controllers
{
    public class MeetingRoomController : Controller
    {
        private readonly IMeetingRoomSettingsService _settingsService;

        public MeetingRoomController(IMeetingRoomSettingsService settingsService)
        {
            _settingsService = settingsService;
        }

        [HttpGet]
        public IActionResult Index(string roomName)
        {
            var settings = _settingsService.GetSettings(roomName);
            if (settings == null)
            {
                settings = new MeetingRoomSettings();
                _settingsService.UpdateSettings(roomName, settings);
            }

            return View(settings);
        }
        [HttpPost("{roomName}")]
        public IActionResult UpdateSettings(string roomName, MeetingRoomSettings newSettings)
        {
            _settingsService.UpdateSettings(roomName, newSettings);
            return RedirectToAction(nameof(Index), new { roomName });
        }

    }
}
