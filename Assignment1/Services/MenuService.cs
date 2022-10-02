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
        public void MainMenu();
        public void ViewListMenu();
        public Contact CreateMenu();
        public void RemoveMenu();
        public void SettingsMenu();      
    }
    internal class MenuService : IMenu
    {
        private ContactService _contactService;

        public MenuService(string filepath)
        {
            _contactService = new ContactService(filepath);
        }
        
        public void ViewListMenu()
        {
            throw new NotImplementedException();
        }

        public Contact CreateMenu()
        {
            var contact = new Contact();
            
            try
            {
                Console.Clear();
                Console.WriteLine("########## Create new contact ##########");
                
                Console.Write("");
                
                Console.Write("");
                
                Console.Write("");
                
                Console.Write("");
                
                Console.Write("");


                return contact;
            }
            catch
            {
                Console.WriteLine("Invalid values added.");
                Console.ReadKey();
            }
            return null!;
        }

        public void RemoveMenu()
        {
            throw new NotImplementedException();
        }



        public void SettingsMenu()
        {
            
        }


        public void MainMenu()
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
