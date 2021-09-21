using System.Reflection;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Utilities
{
    public class Util
    {
        public string ReadFile(string filename)
        {
            return File.ReadAllText(filename);
        }

        public T ReadData<T>(string filepath)where T:class {
            var cadJSON = ReadFile(filepath);
            var bookList = JsonConvert.DeserializeObject<T>(cadJSON);
            return bookList;
        }

        public static List<T> ReadData<T>(string filepath, string extra) where T:class
        {
            Util obj = new Util();
            List<T> books = new List<T>();
            var cadJSON = obj.ReadFile(filepath);
            books.AddRange(JsonConvert.DeserializeObject<List<T>>(cadJSON));
            return books;
        }


    }
}
