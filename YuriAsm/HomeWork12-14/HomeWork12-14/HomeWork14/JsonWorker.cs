using System.Text.Json;

namespace HomeWork12_14.HomeWork14
{
    public class JsonWorker
    {
        public static User JsonPars(string filePath)
        {
            string jsonFile = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<User>(jsonFile);
        }

        public void JsonCreate (User user,string jsonName)
        {
            string jsonContent = JsonSerializer.Serialize(user);
            File.WriteAllText(jsonName, jsonContent);
        }

    }
}
