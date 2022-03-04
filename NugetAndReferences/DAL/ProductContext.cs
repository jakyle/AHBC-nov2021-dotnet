using DAL.Models;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using TinyCsvParser;

namespace DAL
{
    public class ProductContext : IProductContext
    {
        private readonly string _csvPath;
        private readonly IProductParser _parser;

        public ProductContext(string csvPath, IProductParser parser)
        {
            if (csvPath == null || csvPath.Length < 1)
            {
                throw new ArgumentException("Invalid path");
            }

            var path = Path.GetFullPath($@"{SpecialDirectories.MyDocuments}\\{csvPath}");

            _csvPath = path;
            _parser = parser;
        }

        
        public IEnumerable<Product> GetProducts()
        {
            var products = _parser.ReadFromFile(_csvPath, System.Text.Encoding.ASCII);
            return products;
        }
    }
}
