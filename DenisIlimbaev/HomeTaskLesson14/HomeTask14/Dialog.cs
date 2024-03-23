using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeTask14.MyException;
namespace HomeTask14
{
    internal class Dialog<T> where T : class
    {
        private MyFormater<T> formater;
        private MyFormater<T> formater2;
        internal Dialog(JsonFormater<T> formater, XmlFormater<T> formater2)
        {
            this.formater = formater;
            this.formater2 = formater2;
        }
        internal void Start()
        {

            string path = Console.ReadLine() ?? throw new NullReferenceException();
            path += (path[path.Length - 1] != '/') ? '/' : string.Empty;
            DirectoryInfo info = new DirectoryInfo(path);
            try
            {
                FileInfo file = info.GetFiles().Where(f => f.Name.Contains(".json")).LastOrDefault() ?? throw new DialogNotFoundFileFromSeralizetionException();
                T obj = formater.Deserialize(path + file.Name);

                formater2.Creator(path, formater2.TakeMeName(obj), string.Empty);
                string strXml = formater2.Serialize(path + formater2.TakeMeName(obj), obj);
                formater2.Creator(path, formater2.TakeMeName(obj), strXml);

                file = info.GetFiles().Where(f => f.Name.Contains(".xml")).LastOrDefault() ?? throw new DialogNotFoundFileFromSeralizetionException();
                obj = formater2.Deserialize(path + file.Name);
                string strJson = formater.Serialize(path + formater.TakeMeName(obj), obj);
                formater.Creator(path, formater.TakeMeName(obj), strJson);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error: " + Environment.NewLine);
                Console.WriteLine(ex.Message);
            }
            finally
            {
                GC.Collect();
            }
        }
    }
}
