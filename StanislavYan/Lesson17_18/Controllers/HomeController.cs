using Lesson17_18.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Lesson17_18.Services;

namespace Lesson17_18.Controllers
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
        
        public IActionResult Index()
        { 
            return View("Index", _meetingService.GetRoom());
        }
     
        [HttpPost("/MeetingEdit")]
        public IActionResult EditRoom([FromForm] Meeting request)
        {
            int peopleCount = Int32.Parse(Request.Form.FirstOrDefault(p => p.Key == "PeopleCount").Value!);
            int time = Int32.Parse(Request.Form.FirstOrDefault(p => p.Key == "Time").Value!);
            var res = _meetingService.UpdateRoom(new Meeting() { PeopleCount = peopleCount, Time = time });
            return View("Index", _meetingService.GetRoom ());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
