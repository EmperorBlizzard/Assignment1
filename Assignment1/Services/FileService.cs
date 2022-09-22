using Assignment1.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Assignment1.Services
{
    internal class FileService
    {
        private string _FilePath;

        public FileService(string FilePath)
        {
            _FilePath = FilePath;
        }

        public void Save(List<Product> list)
        {
            using var sw = new StreamWriter(_FilePath);
            sw.WriteLine(JsonConvert.SerializeObject(list));
        }

        public List<Product> Read()
        {
            var list =new List<Product>();

            try
            {
                using var sr = new StreamReader(_FilePath);
                list = JsonConvert.DeserializeObject<List<Product>>(sr.ReadToEnd());
            }
            catch { }

            return list;
        }
    }
}
