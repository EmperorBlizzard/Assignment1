﻿using Assignment1.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Services
{
    internal interface IMenuService
    {
        public void MainMenu();
    }
    internal class MenuService : IMenuService
    {
        private IFileService _fileService = new FileService();
        private List<Contact> _contacts = new();
        private string _filePath = @"C:\Users\emil1\Skrivbord\Address_book.json";

        public void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("########## Menu ##########");
            Console.WriteLine("1. Show contacts");
            Console.WriteLine("2. Create new contact");
            Console.WriteLine("3. Settings");
            Console.WriteLine("4. Quit program");
            Console.WriteLine("");

            Console.Write("Choose one option: ");
            var option = Console.ReadLine() ?? "";




            switch (option)
            {
                case "1":

                    ViewListMenu();

                    break;
                case "2":
                    ShowCreateContact();
                    break;
                case "3":
                    ShowSettings();
                    break;
                case "4":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine();
                    break;

            }
        }

        public void ViewListMenu()
        {
            try { _contacts = JsonConvert.DeserializeObject<List<Contact>>(_fileService.Read(_filePath)); }
            catch { }

            Console.Clear();
            Console.WriteLine("########## ADDRESS BOOK ##########");

            foreach (var contact in _contacts)
            {
                Console.WriteLine($"{contact.Id} - {contact.FullName}");
            }
            if(_contacts.Count > 0)
            {
                Console.WriteLine();
                Console.Write("View contact detail? (y/n): ");
                var option = Console.ReadLine();
                if (option == "y")
                {
                    Console.Write("Enter contact Id: ");
                    var id =Console.ReadLine();
                    if (!string.IsNullOrEmpty(id))
                    {
                        ShowContactDetails(id);
                    }
                }
            }
        }

        public void ShowContactDetails(string id)
        {
            var contact = _contacts.FirstOrDefault(x => x.Id == new Guid(id));

            Console.Clear();
            Console.WriteLine("########## Contact detail ##########");
            Console.WriteLine($"Id \t\t                 {contact?.Id}");
            Console.WriteLine($"Name \t\t               {contact?.FullName}");
            Console.WriteLine($"Street address \t\t     {contact?.StreetAddress}");
            Console.WriteLine($"Postal code \t\t        {contact?.PostalCode}");
            Console.WriteLine($"City \t\t               {contact?.City}");
            Console.WriteLine();
            Console.WriteLine("1. Edit");
            Console.WriteLine("2. Delete");
            Console.Write("Enter Option: ");
            var option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    ShowContactUppdate(contact);
                    break;
                case "2":
                    RemoveContact(contact.Id);
                    break;
                default:
                    break;
            }
        }

        public void ShowCreateContact()
        {
            var contact = new Contact();

            
            Console.Clear();
            Console.WriteLine("########## CREATE CONTACT ##########");

            Console.Write("First name: ");
            contact.FirstName = Console.ReadLine() ?? "";

            Console.Write("Last name: ");
            contact.LastName = Console.ReadLine() ?? "";

            Console.Write("Street Address: ");
            contact.StreetAddress = Console.ReadLine() ?? "";

            Console.Write("Postal code: ");
            contact.PostalCode = Console.ReadLine() ?? "";

            Console.Write("City: ");
            contact.City = Console.ReadLine() ?? "";

            _contacts.Add(contact);
            _fileService.Save(_filePath, JsonConvert.SerializeObject(_contacts));
                
        }

        public void ShowContactUppdate(Contact contact)
        {
            var index = 1;
            _contacts[index] = contact;
            _fileService.Save(_filePath, JsonConvert.SerializeObject(_contacts));
        }
        private void RemoveContact(Guid id)
        {
            _contacts = _contacts.Where(x => x.Id != id).ToList();
            _fileService.Save(_filePath, JsonConvert.SerializeObject(_contacts));
        }



        public void ShowSettings()
        {
            try { _contacts = JsonConvert.DeserializeObject<List<Contact>>(_fileService.Read(_filePath)); }
            catch { }
            Console.Clear();
            Console.WriteLine("########## SETTINGS ##########");
            Console.Write("Enter the new file path: ");

            _filePath = @$"{Console.ReadLine()}\Address_Book.Json";

            _fileService.Save(_filePath, JsonConvert.SerializeObject(_contacts));
        }

    }
}
