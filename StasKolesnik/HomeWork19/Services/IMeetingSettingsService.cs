using HomeWork_16.Models;

    public interface IMeetingSettingsService
    {
        MeetingSettingsModel GetMeetingSettings();
        public void UpdateMeetingSettings(MeetingSettingsModel model);
    }
