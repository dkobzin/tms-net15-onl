using DZLesson17.Models;
using DZLesson17.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DZLesson17.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly IMeetingService _meetingService;
        public HomeController(ILogger<HomeController> logger, IMeetingService service)
        {
            _logger = logger;
            _meetingService = service;
        }
        [HttpGet("/GetMeetings")]
        public Meeting[] GetMeetings()
        {
            return _meetingService.GetMeetings();
        }

        [HttpPost("/UpdateMeetings")]
        public void UpdateMeetings([FromBody] Meeting[] request)
        {
            _meetingService.UpdateMeetings(request);
        }

        public IActionResult Index()
        {
            return View();
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
