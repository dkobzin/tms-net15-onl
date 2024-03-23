using System.Net.Http.Headers;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Text.Json;
using HomeTask14.MyException;
namespace HomeTask14
{
    internal class JsonFormater<T> : MyFormater<T> where T : class
    {
        internal JsonFormater()
        {
            format = ".json";
        }
        internal override T Deserialize(string pathFromJson)
        {
            string json = string.Empty;
            using (FileStream file = File.OpenRead(pathFromJson))
            {
                byte[] buffer = new byte[file.Length];
                file.Read(buffer, 0, buffer.Length);
                json = Encoding.UTF8.GetString(buffer);
            }
            return JsonSerializer.Deserialize<T>(json ?? throw new NullReferenceException())!;
        }
        
        internal override string Serialize(string pathFromJson,T o, int writePos = 0)
        {
            foreach (var property in o.GetType().GetProperties())
            {
               if(property.GetValue(o) == null)
               {
                    throw new FormaterFileNullPropertyExecption(property.Name);
               }
            }
            MemoryStream memory = new MemoryStream();
            var ser = new DataContractJsonSerializer(typeof(T));
            string json = string.Empty;

            ser.WriteObject(memory, o);
            memory.Position = writePos;
            using (StreamReader reader = new StreamReader(memory))
            {
                json = reader.ReadToEnd();
            }
            return json;
        }

        
    }
}
