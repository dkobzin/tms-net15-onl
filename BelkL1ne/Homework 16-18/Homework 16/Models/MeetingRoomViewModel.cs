using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Homework_16.Models
{
    public class MeetingRoomViewModel
    {
        [BindRequired]
        public Guid Id { get; set; }
        [BindRequired]
        public string Name { get; set; }
        [BindRequired]
        public int MaxPeople { get; set; }
        [BindRequired]
        public TimeSpan Duration { get; set; }
    }
}
