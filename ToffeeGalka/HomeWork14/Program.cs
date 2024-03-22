using System;
using System.Reflection;
using System.Text.Json;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace HomeWork14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input path file json:");
            string path = Path.Combine(Directory.GetCurrentDirectory(), Console.ReadLine());
            try
            {
                if (!Directory.Exists(path))
                {
                    throw new FileExceptions("Path not found!");
                }
                var files = Directory.GetFiles(path, "*.json");

                if (files.Length == 0)
                {
                    throw new FileExceptions("File json not found!");
                }
                else if (files.Length > 1)
                {
                    throw new FileExceptions("Found more than one file json!");
                }

                var pathJson = Path.Combine(Environment.CurrentDirectory, "User.json");
                var json = File.ReadAllText(pathJson);
                var userJson = JsonSerializer.Deserialize<User>(json);
                Console.WriteLine($"User person json: {userJson.FirstName} {userJson.LastName} {userJson.Age} {userJson.IDCard}");

                string namexml = "user" + "_" + userJson.LastName + "_" + userJson.FirstName + ".xml";
                var xmlOut = new XmlSerializer(typeof(User));
                Stream pathOutXml = new FileStream(namexml,FileMode.Create);
                xmlOut.Serialize(pathOutXml, userJson);
                pathOutXml.Close();

                
                var pathXml = Path.Combine(Environment.CurrentDirectory, namexml);
                var xml = File.ReadAllText(pathXml);

                Stream pathUserXml = new FileStream(namexml, FileMode.Open);
                User userXml = xmlOut.Deserialize(pathUserXml) as User;
                Console.WriteLine($"User person xml: {userXml.FirstName} {userXml.LastName} {userXml.Age} {userXml.IDCard}");

                string namejson = "user" + "_" + userXml.LastName + "_" + userXml.FirstName;
                var jsonOut = JsonSerializer.Serialize(userXml);
                var pathOutJson = Path.Combine(Environment.CurrentDirectory, $"{namejson}.json");
                File.WriteAllText(pathOutJson, jsonOut);
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
        }   
    }
}
