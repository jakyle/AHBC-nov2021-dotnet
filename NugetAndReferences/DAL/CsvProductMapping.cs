using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyCsvParser.Mapping;

namespace DAL
{
    public class CsvProductMapping : CsvMapping<Product>
    {
        public CsvProductMapping()
            : base()
        {
            MapProperty(0, x => x.Id);
            MapProperty(1, x => x.Name);
            MapProperty(2, x => x.Description);
            MapProperty(3, x => x.Category);
            MapProperty(4, x => x.Price);
        }
    }
    
}
