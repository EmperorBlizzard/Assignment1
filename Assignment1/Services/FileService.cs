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
        private string _filepath;

        public FileService(string filepath)
        {
            _filepath = filepath;
        }

        public void Save(List<Contact> list)
        {
            using var sw = new StreamWriter(_filepath);
            sw.WriteLine(JsonConvert.SerializeObject(list));
        }

        public List<Contact> Read()
        {
            var list =new List<Contact>();

            try
            {
                using var sr = new StreamReader(_filepath);
                list = JsonConvert.DeserializeObject<List<Contact>>(sr.ReadToEnd());
            }
            catch { }

            return list;
        }
    }
}
