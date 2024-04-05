using HomeWork18.Models;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.Extensions.Configuration;

namespace HomeWork18.Services
{
    public class MeetingRoomService : IMeetingRoomService
    {
        private readonly IConfiguration _configuration;
        public MeetingRoomService(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public bool EditRoom(MeetingRoomEdit roomData)
        {
            try
            {
                _configuration["MaxPeople"] = roomData.MaxPeople.ToString();
                _configuration["MaxTime"] = roomData.MaxTime.ToString();
                 return  true;
            }
            catch 
            {
                return false;
            }
        }
        public MeetingRoom GetMeeting() 
        {
            var peoples = _configuration.GetValue<int>("MaxPeople");
            var durationMinutes = _configuration.GetValue<int>("MaxTime");
            return new MeetingRoom() { MaxPeople = peoples, MaxTime = TimeSpan.FromMinutes(durationMinutes) };
        }

    }
}
