namespace MeetingRoomWebApi.Models;

public class Meeting
{
    public int Id { get; set; }

    public string Title { get; set; }

    public DateTime StartTime { get; set; }

    public DateTime EndTime { get; set; }

    public int MeetingRoomId { get; set; }
}