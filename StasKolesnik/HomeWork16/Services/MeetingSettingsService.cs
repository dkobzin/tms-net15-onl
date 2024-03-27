using HomeWork_16.Models;

namespace HomeWork_16.Services
{
    public class MeetingSettingsService
    {
        public MeetingSettingsModel GetMeetingSettings()
        {
            return new MeetingSettingsModel
            {
                MeetingName = "Название конференции",
                PeopleCount = Random.Shared.Next(1, 100),
                MeetingDate = DateTime.Now,
                MeetingOwner = "Stanislav Kalesnik",
                Description = "Домашнее задание #16"

            };
        }
    }
}
