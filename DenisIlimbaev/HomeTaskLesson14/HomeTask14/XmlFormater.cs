using HomeTask14.MyException;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace HomeTask14
{
    internal class XmlFormater<T> : MyFormater<T> where T : class
    {
        internal XmlFormater()
        {
            format = ".xml";
        }
        internal override T Deserialize(string path)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            T? obj = null;
            using (FileStream file = new FileStream(path, FileMode.Open))
            {
                obj = (T)serializer.Deserialize(file)! ?? throw new NullReferenceException();
            }
            return obj;
        }
        internal override string Serialize(string path, T o, int pos = 0)
        {
            
            foreach (var property in o.GetType().GetProperties())
            {
                if (property.GetValue(o) == null & property.CanWrite == true)
                {
                    throw new FormaterFileNullPropertyExecption(property.Name);
                }
            }
            string writer = Directory.GetCurrentDirectory() + "/" + "Writer.xml";
            string result = string.Empty;
            XmlSerializer ser = new XmlSerializer(typeof(T));
            if (File.Exists(writer)) File.Delete(writer);
            using(FileStream file = new FileStream(writer, FileMode.Create))
            {
                ser.Serialize(file, o);
                byte[] buffer = new byte[file.Length];
                file.Read(buffer, 0, buffer.Length);
               
            }
            using(FileStream file = File.OpenRead(writer))
            {
                byte[] buffer = new byte[file.Length];
                file.Read(buffer, 0, buffer.Length);
                result = Encoding.UTF8.GetString(buffer);
            }
            File.Delete(writer);
            return result;
        }
    }
}
