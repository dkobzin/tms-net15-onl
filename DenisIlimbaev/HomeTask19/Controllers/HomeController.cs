using HomeTask15Web.Models;
using HomeTask15Web.Service;
using HomeTask15Web.Fillters;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Text;
using System.Text.Json;
namespace HomeTask15Web.Controllers
{
    public class HomeController : Controller
    {
        
        private readonly ILogger<HomeController> _logger;
        private readonly ISettingsService _settings;
        public HomeController(ISettingsService settings,ILogger<HomeController> logger)
        {
            _logger = logger;
            _settings = settings;
        }

        public IActionResult Index()
        {
            return View();
        }
     
        public IActionResult Privacy()
        {
            return View();
        }
        [HttpGet]
        [ActionName("MeetingRoom")]
        [TimeFillter]
        public IActionResult MeetingRoom()
        {
            var mainSettings = _settings.GetMeSettings();
            return View(mainSettings);
        }

        [HttpPost]
        [ActionName("NewUser")]
        public IActionResult MeetingRoomPost([FromForm] Users userData)
        {
            _settings.PostMeSettings(new Container() { UserSettings = userData, GeneralSettings = new General() { NowTime = DateTime.Now.ToString("H:m"), ScheduledMeetingTime = "19:00" } }); 
            return RedirectToAction("MeetingRoom");
        }
        [HttpGet]
        [ActionName("NewUser")]
        public IActionResult MeetingRoomGet()
        {
            return View("MeetingRoomPost");
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
