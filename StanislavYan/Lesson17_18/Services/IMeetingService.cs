using Lesson17_18.Models;

namespace Lesson17_18.Services;

public interface IMeetingService
{
    public Meeting GetRoom();
    public bool UpdateRoom(Meeting meeting);
}