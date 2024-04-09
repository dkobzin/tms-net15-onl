using HomeWork17.Models;
using HomeWork17.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HomeWork17.Controllers
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

        [HttpPost("/MeetingEdit")]
        public IActionResult EditRoom()
        {
            int maxPeople = Int32.Parse(Request.Form.FirstOrDefault(p => p.Key == "MaxPeople").Value!);
            int maxTime = Int32.Parse(Request.Form.FirstOrDefault(p => p.Key == "MaxTime").Value!);
            var res = _meetingRoomService.EditRoom(new MeetingRoomEdit() { MaxPeople = maxPeople, MaxTime = maxTime });
            ViewBag.Meeting = _meetingRoomService.GetMeeting();
            return RedirectToAction("Index", "MeetingRoom");
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
