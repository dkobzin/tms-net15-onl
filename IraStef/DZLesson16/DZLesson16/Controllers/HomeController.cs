using DZLesson16.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DZLesson16.Controllers
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
        [HttpGet("/GetMeeting")]
        public Meeting GetMeeting() 
        { 
            return _meetingService.GetMeeting();
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
