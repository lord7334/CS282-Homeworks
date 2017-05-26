using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example06
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Product[] products = new Product[4];
            products[0] = new Product()
            {
                Name = "iPhone 7",
                Price = 28900
            };
            products[1] = new Product()
            {
                Name = "iPhone 6+",
                Price = 28900
            };
            products[2] = new Product()
            {
                Name = "iPhone 7+",
                Price = 32900
            };
            products[4] = new Product()
            {
                Name = "iPhone 6",
                Price = 25900
            };
            Random random = new Random();
            List<Product> shoppingCart = new List<Product>();
        }
    }
}