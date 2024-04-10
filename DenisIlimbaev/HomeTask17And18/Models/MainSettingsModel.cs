using System.Collections;
using System.Reflection;

namespace HomeTask15Web.Models
{
    public class Container
    {
        public General GeneralSettings { get; set; }
        public Users UserSettings { get; set; }
    }
    public class MainSettingsModel
    {
        public Container Container { get; init; }
        public MainSettingsModel(General general, Users settings)
        {
            Container = new Container()
            {
                UserSettings = settings,
                GeneralSettings = general
            };
        }


    }
}
