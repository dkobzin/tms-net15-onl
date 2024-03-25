using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork14_IvanNepo;
    using System;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("Не указан путь к папке с JSON файлом.");
            return;
        }

        string folderPath = args[0];

        string[] jsonFiles = Directory.GetFiles(folderPath, "*.json");

        if (jsonFiles.Length == 0)
        {
            Console.WriteLine("В указанной папке нет JSON файлов.");
            return;
        }

        if (jsonFiles.Length > 1)
        {
            Console.WriteLine("В указанной папке более одного JSON файла.");
            return;
        }

        string jsonFilePath = jsonFiles[0];

        try
        {
            User user = JsonParser.ParseJson(jsonFilePath);

            string xmlFileName = $"user_{user.FirstName}_{user.LastName}.xml";
            JsonParser.SaveAsXml(user, xmlFileName);
            Console.WriteLine($"Объект User сохранен в файл: {xmlFileName}");

            string jsonFileName = $"user_{user.FirstName}_{user.LastName}.json";
            JsonParser.SaveAsJson(user, jsonFileName, compactFormat: false);
            Console.WriteLine($"Объект User сохранен в файл: {jsonFileName}");

            string compactJsonFileName = $"user_{user.FirstName}_{user.LastName}_compact.json";
            JsonParser.SaveAsJson(user, compactJsonFileName, compactFormat: true);
            Console.WriteLine($"Объект User сохранен в файл: {compactJsonFileName}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }
}