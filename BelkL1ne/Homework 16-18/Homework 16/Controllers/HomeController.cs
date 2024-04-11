using Homework_16.Models;
using Homework_16.Servicees;
using Homework_16.Servicees.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Diagnostics;

namespace Homework_16.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMeetingRoomService _meetingRoomService;

        public HomeController(ILogger<HomeController> logger, IMeetingRoomService meetingRoomService)
        {
            _logger = logger;
            _meetingRoomService = meetingRoomService;
            
        }
        
        public IActionResult Index()
        {
            return View();
        }

        public MeetingRoomViewModel GetMeetingRoomViewModel(Guid id)
        {
            var meetingRoom = _meetingRoomService.GetMeetingRoom(Guid.NewGuid());
            var meetingRoomViewModel = new MeetingRoomViewModel
            {
                Id = meetingRoom.Id,
                Name = meetingRoom.Name,
                MaxPeople = meetingRoom.MaxPeople,
                Duration = meetingRoom.Duration
            };
            return meetingRoomViewModel;
        }

        [HttpGet]
        public IActionResult MeetingRoom([FromQuery] Guid id)
        {
            var model = GetMeetingRoomViewModel(id);
            return View("MeetingRoom", model);
        }
        
        [HttpPost]
        public IActionResult MeetingRoom([FromForm] MeetingRoomViewModel model)
        {
            var meetingRoomDTO = new MeetingRoomDTO
            {
                Id = model.Id,
                Name = model.Name,
                MaxPeople = model.MaxPeople,
                Duration = model.Duration
            };
            _meetingRoomService.SaveMeetingRoomService(meetingRoomDTO);
            return View("Success");
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
