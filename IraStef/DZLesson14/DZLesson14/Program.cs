using System.Text.Json;
using System.Xml.Serialization;

namespace DZLesson14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the path to the JSON file");

            var path = Console.ReadLine();
            var files = Directory.GetFiles(path, "*.json");
            if (files.Length == 0)
            {
                throw new PathException("No JSON files");
            }
            else if (files.Length > 1)
            {
                throw new PathException("More than one JSON file");
            }

            var json = File.ReadAllText(files[0]);
            var user = JsonSerializer.Deserialize<User>(json);

            if (user == null)
            {
                throw new JsonException("User is null!");
            }
            string fileName = $"user_{user.FirstName}_{user.LastName}.xml";

            var serializaer = new XmlSerializer(typeof(User));
            Stream output = new FileStream(path + fileName, FileMode.Create);
            serializaer.Serialize(output, user);
            output.Dispose();

            var xml = new FileStream(fileName, FileMode.Open);
            var userXml = serializaer.Deserialize(xml);

            if (userXml is User pasedXml)
            {
                var userJson = JsonSerializer.Serialize(pasedXml);
                var jsonFilename = $"user_{user.FirstName}_{user.LastName}.json";
                StreamWriter writer = new StreamWriter(Path.Combine(path, jsonFilename));
                writer.Write(userJson);
                writer.Flush();
            }
            else
            {
                throw new XmlException("Unnable to parse xml");
            }
        }
    }
}
