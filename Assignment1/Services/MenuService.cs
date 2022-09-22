using Assignment1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Services
{
    internal interface IMenu
    {
        public static void MainMenu();
        public void Create();
        public void List();
        public void Details();
        public void Remove();
        public void Init();
    }
    internal class MenuService : IMenu
    {
        private ContactService _productService;

        public MenuService(string filepath)
        {
            _productService = new ContactService(filepath);
        }
        public void Create()
        {
            var contact = new Contact();
            Console.Clear();
            Console.WriteLine("Create new contact");
            Console.Write("");
        }

        public void Details()
        {
            throw new NotImplementedException();
        }

        public void Init()
        {
            throw new NotImplementedException();
        }

        public void List()
        {
            throw new NotImplementedException();
        }

        public void Remove()
        {
            throw new NotImplementedException();
        }


        public static void MainMenu()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("1. View contacts");
            Console.WriteLine("2. Add contact");
            Console.WriteLine("3. Remove contact");
            Console.WriteLine("4. Settings");
            Console.WriteLine("5. Quit program");

            Console.Write("Choose one option: ");

            var option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    
                case "2":

                case "3":

                case "4":

                case "5":

                default:
                    Console.WriteLine();
                    break;
            }

        }
    }
}
