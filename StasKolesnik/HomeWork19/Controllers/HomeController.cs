using HomeWork_16.Models;
using HomeWork_16.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json.Linq;
using System.Diagnostics;

namespace HomeWork_16.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly MeetingSettingsService _meetingSettings;

        public HomeController(MeetingSettingsService meetingRoomSettings, ILogger<HomeController> logger)
        {
            _logger = logger;
            _meetingSettings = meetingRoomSettings;
            
        }

        [HttpGet("/getMeetingRoom")]
        public MeetingSettingsModel GetMeetingSettings()
        {
            return _meetingSettings.GetMeetingSettings();
        }

        [HttpPost]
        public IActionResult NewSettings(MeetingSettingsModel model)
        {
            _meetingSettings.UpdateMeetingSettings(model);
            return RedirectToAction("Index");
        }

        public IActionResult Settings()
        {
            return View();
        }

        public IActionResult Index()
        {
            MeetingSettingsModel settings = _meetingSettings.GetMeetingSettings();
            return View(settings);
        }

        public IActionResult Privacy()
        {
            return View();
        }

    }
}
