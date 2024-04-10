using Homework_16.Servicees.DTO;

namespace Homework_16.Servicees
{
    public interface IMeetingRoomService
    {
        public MeetingRoomDTO GetMeetingRoom(Guid id);
        public void SaveMeetingRoomService(MeetingRoomDTO model);
    }
}
