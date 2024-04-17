using Microsoft.Extensions.Options;
using System.Runtime;

namespace AleksandrHw16.Models
{
    public class MeetingRoomSettingsService
    {
        public MeetingRoom GetMeetingRoom()
        {
            return new MeetingRoom(new DateTime(2024, 4, 12, 13, 0, 0), 7, new TimeSpan(4, 0, 0));
        }
    }
}
