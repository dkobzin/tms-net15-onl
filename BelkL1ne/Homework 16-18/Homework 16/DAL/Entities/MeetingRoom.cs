namespace Homework_16.DAL.Entities
{
    public class MeetingRoom
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int MaxPeople { get; set; }
        public TimeSpan Duration { get; set; }
    }
}
