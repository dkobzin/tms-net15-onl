public interface IMeetingRoomSettingsService
{
    MeetingRoomSettings GetSettings();
}

public class MeetingRoomSettingsService : IMeetingRoomSettingsService
{
    public MeetingRoomSettings GetSettings()
    {
        // Здесь может быть логика получения настроек, например из файла или базы данных
        return new MeetingRoomSettings
        {
            MaxCapacity = 10,
            MaxMeetingDuration = TimeSpan.FromHours(1)
        };
    }
}
