using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork14_IvanNepo;
using HomeWork14_IvanNepo;
using System;
using System.IO;
using System.Text.Json;

public class JsonParser
{
    public static User ParseJson(string jsonFilePath)
    {
        string jsonContent = File.ReadAllText(jsonFilePath);
        return JsonSerializer.Deserialize<User>(jsonContent);
    }

    public static void SaveAsXml(User user, string xmlFileName)
    {
        using (FileStream fs = new FileStream(xmlFileName, FileMode.Create))
        {
            System.Xml.Serialization.XmlSerializer serializer =
                new System.Xml.Serialization.XmlSerializer(typeof(User));
            serializer.Serialize(fs, user);
        }
    }

    public static void SaveAsJson(User user, string jsonFileName, bool compactFormat = false)
    {
        JsonSerializerOptions options = new JsonSerializerOptions();
        if (compactFormat)
        {
            options.WriteIndented = false;
        }
        else
        {
            options.WriteIndented = true;
        }

        string jsonString = JsonSerializer.Serialize(user, options);
        File.WriteAllText(jsonFileName, jsonString);
    }
}
