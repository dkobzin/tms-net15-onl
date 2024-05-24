using Lesson16_19_MeetingRoomApp.Models;
using Lesson16_19_MeetingRoomApp.Services;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace Lesson16_19_MeetingRoomApp.Controllers;
public class MeetingRoomController : Controller
{
    private readonly IMeetingRoomService _meetingRoomService;

    public MeetingRoomController(IMeetingRoomService meetingRoomService)
    {
        _meetingRoomService = meetingRoomService;
    }

    [HttpGet]
    public IActionResult Index()
    {
        var rooms = _meetingRoomService.GetAllSettings();
        if (rooms == null)
        {
            return NotFound();
        }
        return View(rooms);
    }

    [HttpGet("MeetingRoom/Details/{name?}")]
    public IActionResult Details(string name)
    {
        if (string.IsNullOrEmpty(name))
        {
            return BadRequest("Room name is required");
        }

        var settings = _meetingRoomService.GetSettings(name);
        if (settings == null)
        {
            return NotFound();
        }
        return View(settings);
    }

    [HttpPost]
    public IActionResult Update(MeetingRoomSettings updatedSettings)
    {
        if (!ModelState.IsValid)
        {
            return View(updatedSettings);
        }

        var appSettingsPath = "appsettings.json";
        var json = System.IO.File.ReadAllText(appSettingsPath);
        var jsonObj = JObject.Parse(json);
        var meetingRooms = jsonObj["MeetingRooms"];
        foreach (var room in meetingRooms)
        {
            if (room["Name"].ToString() == updatedSettings.Name)
            {
                room["MaxPeople"] = updatedSettings.MaxPeople;
                room["MaxMeetingDuration"] = updatedSettings.MaxMeetingDuration;
                break;
            }
        }
        System.IO.File.WriteAllText(appSettingsPath, jsonObj.ToString());

        _meetingRoomService.UpdateSettings(updatedSettings);

        _meetingRoomService.Reload();

        return RedirectToAction("Index", new { name = updatedSettings.Name, maxPeople = updatedSettings.MaxPeople, maxMeetingDiuration = updatedSettings.MaxMeetingDuration });
    }
}