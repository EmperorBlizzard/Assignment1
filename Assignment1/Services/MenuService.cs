using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Services
{
    internal interface IMenu
    {
        public void Create();
        public void List();
        public void Details();
        public void Remove();
        public void Init();
    }
    internal class MenuService : IMenu
    {
        private ProductService _productService;

        public MenuService(string filepath)
        {
            _productService = new ProductService(filepath);
        }
        public void Create()
        {
            throw new NotImplementedException();
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
    }
}
