using Assignment1.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Assignment1.Services
{
    interface IFileService
    {
        public void Save(string filePath, string text);
        public string Read(string filepath);
    }
    internal class FileService : IFileService
    {
        

        public FileService()
        {
            
        }
        //Sparar till .json fil
        public void Save(string filePath, string text)
        {
            try
            {
                using var sw = new StreamWriter(filePath);
                sw.WriteLine(text);
            }
            catch 
            {
                Console.Clear();
                Console.WriteLine("Unable to save the address book");
                Console.ReadKey();
            }
        }
        //Läser innehållet av .json fil
        public string Read(string filePath)
        {
            try
            {
                using var sr = new StreamReader(filePath);
                return sr.ReadToEnd();
            }
            catch { }

            return "[]";
        }
    }
}
