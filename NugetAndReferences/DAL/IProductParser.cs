using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IProductParser
    {
        List<Product> ReadFromFile(string path, System.Text.Encoding enconding);
    }
}
