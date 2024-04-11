namespace Homework_16.Servicees.DTO
{
    public class MeetingRoomDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int MaxPeople { get; set; }
        public TimeSpan Duration { get; set; }
    }
}
