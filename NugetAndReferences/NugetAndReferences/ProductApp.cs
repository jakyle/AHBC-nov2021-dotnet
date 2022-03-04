using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NugetAndReferences
{
    public static class ProductApp
    {
        public static void Run()
        {
            var productContext = new ProductContext("products.txt", new ProductXMLParser());
            var products = productContext.GetProducts();

            foreach (var product in products)
            {
                Console.WriteLine($"Name: {product.Name}, Price: {product.Price}.00");
            }
        }
    }
}
