using HomeTask14.MyException;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask14
{
    internal abstract class MyFormater<T> where T : class
    {
        internal abstract string Serialize(string path, T o, int pos = 0);
        internal abstract T Deserialize(string path);

        protected string? format;
       
        internal string TakeMeName(T obj)
        {
            string fileName = "user";
            foreach (var property in obj.GetType().GetProperties())
            {
                fileName += '_' + (property.GetValue(obj) ?? throw new FormaterFileInCorrectedException()).ToString();
            }
            fileName += format;
            return fileName;
        }
        internal void Creator(string pathFromSave, string fileName, string formatfileText)
        {
           
            string path = (pathFromSave[pathFromSave.Length - 1] != '/') ? pathFromSave + '/' + fileName : pathFromSave + fileName;
            using (FileStream file = new FileStream(path, FileMode.OpenOrCreate))
            {
                byte[] buffer = Encoding.Default.GetBytes(formatfileText);
                file.Write(buffer, 0, buffer.Length);
            }
        }
        protected void Check(string pathFormJson, string format)
        {
            if (!(pathFormJson.Substring(pathFormJson.Length - 5, pathFormJson.Length - 1).Equals(format)))
            {
                throw new FormaterFileInCorrectedException();
            }
            if (string.IsNullOrEmpty(pathFormJson))
            {
                throw new FormaterFilePathIsNullOrEmptyException();
            }
        }

    }
}
