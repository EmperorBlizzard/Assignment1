using Assignment1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Services
{
    internal class ContactService
    {
        private List<Contact> _contactCatalog;
        private FileService _fileService;

        public ContactService(string filepath)
        {
            _fileService = new FileService(filepath);
            _contactCatalog = new List<Contact>();
        }

    }
}
