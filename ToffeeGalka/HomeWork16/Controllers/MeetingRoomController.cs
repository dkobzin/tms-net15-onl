using HomeWork16.Models;
using HomeWork16.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HomeWork16.Controllers
{
    public class MeetingRoomController : Controller
    {
        private readonly ILogger<MeetingRoomController> _logger;

        private readonly IMeetingRoomService _meetingRoomService;
        public MeetingRoomController(ILogger<MeetingRoomController> logger, IMeetingRoomService service)
        {
            _logger = logger;
            _meetingRoomService = service;
        }
        [HttpGet("/GetMeeting")]
        public MeetingRoom GetMeeting()
        {
            return _meetingRoomService.GetMeeting();
        }
        [HttpGet("/Index")]
        public IActionResult Index()
        {
            ViewBag.Meeting = _meetingRoomService.GetMeeting();
            return View("Index");
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
