using CSharpFinally.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFinally.Classes
{
    class Product : IProduct
    {
        public enum Catecory { }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Number { get; set; }
        public readonly int Id;
        private static int _id = 0;
        public Product()
        {
            _id++;
            Id = _id;
        }

        public Product(string name, double price, int number)
        {
            Name = name;
            Price = price;
            Number = number;
        }

        public string ProductSales()
        {
            throw new NotImplementedException();
        }

        public void AddProducts()
        {

        }

        public void ChangeProductsInfo()
        {
            throw new NotImplementedException();
        }

        public string ProductForCatecory()
        {
            throw new NotImplementedException();
        }

        public string ProductForPrice()
        {
            throw new NotImplementedException();
        }

        public string ShowProductForName()
        {
            throw new NotImplementedException();
        }

        public void Products()
        {
            throw new NotImplementedException();
        }
    }
}
