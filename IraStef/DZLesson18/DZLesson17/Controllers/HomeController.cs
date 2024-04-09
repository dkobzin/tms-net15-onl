using DZLesson18.Models;
using DZLesson18.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DZLesson18.Controllers
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
        public IActionResult UpdateMeetings([FromForm] MeetingUpdate request)
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
