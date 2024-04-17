using Microsoft.AspNetCore.Mvc;
using AleksandrHw16.Models;
using System.ComponentModel;

namespace AleksandrHw16.Controllers
{
    public class MeetingRoomController : Controller
    {
        private readonly MeetingRoomSettingsService _meetingRoomSettingsService;
        public MeetingRoomController(MeetingRoomSettingsService meetingRoomSettingsService)
        {
            _meetingRoomSettingsService = meetingRoomSettingsService;
        }
        public IActionResult OutputSettings()
        {
            var settings = _meetingRoomSettingsService.GetMeetingRoom();
            return Ok(settings);
        }

    }
}
