using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ProductXMLParser : IProductParser
    {
        public List<Product> ReadFromFile(string path, Encoding enconding)
        {
            // this guy wil look for an XML file and parse into a list of products
            return new List<Product>();
        }
    }
}
