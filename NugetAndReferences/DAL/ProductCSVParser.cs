using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyCsvParser;

namespace DAL
{
    public class ProductCSVParser : IProductParser
    {
        private readonly CsvParser<Product> _parser;

        public ProductCSVParser()
        {
            CsvParserOptions csvParserOptions = new CsvParserOptions(true, ',');
            var csvMapper = new CsvProductMapping();
            CsvParser<Product> csvParser = new CsvParser<Product>(csvParserOptions, csvMapper);

            _parser = csvParser;
        }

        public List<Product> ReadFromFile(string path, Encoding enconding)
        {
            var products = _parser.ReadFromFile(path, enconding)
                .Select(productResult => productResult.Result)
                .ToList();

            return products;
        }
    }
}
