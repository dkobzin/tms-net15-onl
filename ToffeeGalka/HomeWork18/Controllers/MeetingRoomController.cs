using HomeWork18.Models;
using HomeWork18.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HomeWork18.Controllers
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
            return View("MeetingRoom", _meetingRoomService.GetMeeting());
        }
     
        [HttpPost("/MeetingEdit")]
        public IActionResult EditRoom([FromForm] MeetingRoom request)
        {
            int maxPeople = Int32.Parse(Request.Form.FirstOrDefault(p => p.Key == "MaxPeople").Value!);
            int maxTime = Int32.Parse(Request.Form.FirstOrDefault(p => p.Key == "MaxTime").Value!);
            var res = _meetingRoomService.EditRoom(new MeetingRoomEdit() { MaxPeople = maxPeople, MaxTime = maxTime });
            return View("MeetingRoom", _meetingRoomService.GetMeeting ());
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
