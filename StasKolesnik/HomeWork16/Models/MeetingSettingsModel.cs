namespace HomeWork_16.Models
{
    public class MeetingSettingsModel
    {
        public string? MeetingName { get; set; } // Название комнаты
        public int PeopleCount { get; set; } // Количество участиков
        public DateTime MeetingDate { get; set; } // Дата проведения
        public string? MeetingOwner { get; set; } // Организатор встречи
        public string? Description { get; set; } // Описание
    }
}
