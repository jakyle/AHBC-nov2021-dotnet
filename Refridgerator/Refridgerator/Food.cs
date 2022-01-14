using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refridgerator
{
    internal abstract class Food
    {
        public DateTime ExpirationDate { get; set; }
        public string Name { get; set; }

        public Food(DateTime expirationDate, string name)
        {
            ExpirationDate = expirationDate;
            Name = name;
        }
    }
}
