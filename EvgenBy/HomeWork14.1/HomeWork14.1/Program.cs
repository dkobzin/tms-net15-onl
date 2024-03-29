using System;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Xml.Serialization;


namespace HomeWork14
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Console.WriteLine("Введите путь к указанной папке, содержащей Json файл.");
            string folderPath = Console.ReadLine();

            try
            {
                if (!Directory.Exists(folderPath))
                {
                    Console.WriteLine("Указанно папки не существует.");
                }

                string[] files = Directory.GetFiles(folderPath, "*.json");

                if (files.Length == 0)
                {
                    Console.WriteLine("В указанно папке осутствуют JSON файлы.");
                    return;
                }
                else if (files.Length > 1)
                {
                    Console.WriteLine("В указанной папке больше одно JSON файла.");
                }

                string jsonContent = File.ReadAllText(files[0]);

                User user = JsonSerializer.Deserialize<User>(jsonContent);

                string xmlFileName = $"user_{user.FirstName}_{user.LastName}.xml";

                using (StreamWriter writer = new StreamWriter(xmlFileName))
                {
                    var serializer = new XmlSerializer(typeof(User));

                    serializer.Serialize(writer, user);
                }

                string jsonFileName = $"user_{user.FirstName}_{user.LastName}.json";

                File.WriteAllText(jsonFileName, jsonContent);

                Console.WriteLine("Программа успешно завершена.");
            }

            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка {ex.Message}");
            }

        }
    }
}
