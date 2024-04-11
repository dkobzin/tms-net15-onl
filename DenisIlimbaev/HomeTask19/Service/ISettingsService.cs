using HomeTask15Web.Models;

namespace HomeTask15Web.Service
{
    public interface ISettingsService
    {
        public MainSettingsModel GetMeSettings();
        public void PostMeSettings(Container container);
    }
}
