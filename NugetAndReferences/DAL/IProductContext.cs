using DAL.Models;
using System.Collections.Generic;

namespace DAL
{
    public interface IProductContext
    {
        IEnumerable<Product> GetProducts();
    }
}