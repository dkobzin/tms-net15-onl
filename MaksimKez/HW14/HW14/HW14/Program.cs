using System.Data;
using System.Linq.Expressions;
using System.Text.Json;
using System.Xml.Serialization;

namespace HW14
{
    internal class Program
    {
        static void CreateTestJsonUser()
        {
            var user = new User("bob", "bobovich", 26, "someIdCard");

            using Stream stream = new FileStream("JsonBob.json", FileMode.Create);
            JsonSerializer.Serialize(stream, user);
        }

        static void Main(string[] args)
        {
            CreateTestJsonUser();

            Console.WriteLine("Enter the path to JSON file");
            var path = Console.ReadLine();
            if(string.IsNullOrEmpty(path)) throw new InvalidPathEnteredException("Entered path is invalid! It is null or empty");

            //IOException: "Параметр задан неверно
            string[] files = Directory.GetFiles(path, "*.json");
            if (files.Length == 0) throw new InvalidPathEnteredException("Entered path is invalid! There is not any JSON files");
            else if (files.Length > 1) throw new InvalidPathEnteredException("Entered path is invalid! There is more than one JSON file");
            var user = JsonSerializer.Deserialize<User>(files[0]);

            string xmlFileName = user is null ?
                throw new InvalidJsonDataException("JSON file is invalid! It is file is empty") :
                $"<{user.Name}_{user.Surname}_{user.Age}.xml>";

            var serializaer = new XmlSerializer(typeof(User));
            using Stream output = new FileStream(xmlFileName, FileMode.Create);
            serializaer.Serialize(output, user);
        }
    }
}
