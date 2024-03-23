using System.Text.Json;
namespace HomeTask14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Dialog<User> dialog = new Dialog<User>(new JsonFormater<User>(), new XmlFormater<User>());
            dialog.Start();
            
        }
    }
}
