using HW19.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using HW19.Services;
using Microsoft.AspNetCore.Mvc.DataAnnotations;
using HW19.Filters;

namespace hw16.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMeetingSettingsServise _settingsService;

        public HomeController(ILogger<HomeController> logger, IMeetingSettingsServise settings)
        {
            _settingsService = settings ?? throw new ArgumentNullException(nameof(settings));
            _logger = logger;
        }

        [HttpGet("/getMeetingRoomSettingsInfo")]
        public MeetingSettings GetSettings()
        {
            return _settingsService.GetSettings();
        }

        [HttpPost]
        [TimeInHeaderFilter]
        public IActionResult ChangeMeetingSettings(MeetingSettings meetingSettings)
        {
            _settingsService.SaveSettings(meetingSettings);
            ViewBag.MeetingSettings = meetingSettings;

            return RedirectToAction("MyTest");
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult MyTest()
        {

            var settings = _settingsService.GetSettings();
            return View(settings);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
