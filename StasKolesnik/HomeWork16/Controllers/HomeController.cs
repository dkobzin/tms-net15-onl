using HomeWork_16.Models;
using HomeWork_16.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HomeWork_16.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly MeetingSettingsService _meetingSettings;

        public HomeController(MeetingSettingsService meetingSettings, ILogger<HomeController> logger)
        {
            _logger = logger;
            _meetingSettings = meetingSettings;
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
