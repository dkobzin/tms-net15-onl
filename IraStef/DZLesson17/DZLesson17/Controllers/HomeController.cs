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

        [HttpPost]
        public IActionResult UpdateMeetings([FromForm] Meeting[] request)
        {
            _meetingService.UpdateMeetings(request);
            return View("Index", _meetingService.GetMeetings());
        }

        public IActionResult Index()
        {
            return View("Index", _meetingService.GetMeetings());
        }

    }
}
