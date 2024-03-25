using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Lesson15;

public static class Program
{
    private static void Main()
    {
        try
        {
            Console.WriteLine("Enter the path to the folder (or press Enter to use the default path):");
            var folderPath = Console.ReadLine()?.Trim();

            if (string.IsNullOrWhiteSpace(folderPath))
            {
                folderPath = GetProjectFolderPath();
            }

            if (!Directory.Exists(folderPath))
            {
                throw new DirectoryNotFoundException("The specified folder does not exist");
            }

            var jsonFiles = Directory.GetFiles(folderPath, "*.json");
            switch (jsonFiles.Length)
            {
                case 0:
                    Console.WriteLine("There are no JSON files in the specified folder.");
                    return;
                case > 1:
                    Console.WriteLine("There is more than one JSON file in the specified folder. Choose one for parsing.");
                    return;
            }

            var jsonFilePath = jsonFiles[0];

            var jsonContent = File.ReadAllText(jsonFilePath);

            var users = JsonConvert.DeserializeObject<List<User>>(jsonContent);

            var outputFolderPath = Path.Combine(GetProjectFolderPath(), "Output");

            if (!Directory.Exists(outputFolderPath))
            {
                Directory.CreateDirectory(outputFolderPath);
            }

            foreach (var user in users)
            {
                var xmlFileName = Path.Combine(outputFolderPath, $"user_{user.FirstName}_{user.LastName}.xml");
                var serializer = new XmlSerializer(typeof(User));
                using (var xmlStream = new FileStream(xmlFileName, FileMode.Create))
                {
                    serializer.Serialize(xmlStream, user);
                }
                Console.WriteLine($"\nThe User object is saved in a file: {xmlFileName}");


                var compactJsonFileName = Path.Combine(outputFolderPath, $"user_{user.FirstName}_{user.LastName}.json");
                File.WriteAllText(compactJsonFileName, JsonConvert.SerializeObject(user));

                var formattedJsonFileName = Path.Combine(outputFolderPath, $"user_{user.FirstName}_{user.LastName}_formatted.json");
                File.WriteAllText(formattedJsonFileName, JsonConvert.SerializeObject(user, Newtonsoft.Json.Formatting.Indented));

                Console.WriteLine($"JSON is saved in a compact format in a file: {compactJsonFileName}");
                Console.WriteLine($"JSON is saved with line separations in the file: {formattedJsonFileName}");
            }
        }
        catch (DirectoryNotFoundException ex)
        {
            Console.WriteLine($"Directory not found: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error has occurred: {ex.Message}");
        }
    }

    private static string GetProjectFolderPath()
    {
        var currentDirectory = Directory.GetCurrentDirectory();
        var directory = new DirectoryInfo(currentDirectory);
        while (directory != null && directory.GetFiles("*.csproj").Length == 0)
        {
            directory = directory.Parent;
        }
        return directory?.FullName ?? throw new InvalidOperationException("Project folder not found");
    }
}