using System.Text.Json;
using System;
using System.Reflection.Metadata;
using System.Xml;
using System.Xml.Serialization;

namespace Homework_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter path, where json file.");
                string? path = @"C:\SomeFolder\"; //Convert.ToString(Console.ReadLine());

                if (path == null || !Directory.Exists(path))
                { throw new FolderException("This folder doesn't exist."); }

                string[] files = Directory.GetFiles(path, "*.json");
                foreach (string file in files) { Console.WriteLine(file); }

                if (files.Length == 0) 
                { throw new FolderException("This folder doesn't contains any of json files."); }
                else if (files.Length > 1)
                { throw new FolderException("This folder contains too many of json files."); }

                FileStream fsJson = new FileStream(files[0], FileMode.OpenOrCreate);
                
                User? billy = JsonSerializer.Deserialize<User>(fsJson);
                Console.WriteLine($"FirstName: {billy?.FirstName}  LastName: {billy?.LastName}" +
                $" Age: {billy?.Age} Idcard: {billy?.IDCard}");
                Console.WriteLine("Object has been deserialized from json");

                FileStream fsXml = new FileStream(path + $"user_{billy?.FirstName}_{billy?.LastName}.xml", FileMode.OpenOrCreate);

                XmlSerializer xmlSer = new XmlSerializer(typeof(User));
                xmlSer.Serialize(fsXml, billy);
                Console.WriteLine("Object has been serialized into xml");
            }
            catch (FolderException ex) { Console.WriteLine(ex.Message); }
            finally { }
        }
    }
}
