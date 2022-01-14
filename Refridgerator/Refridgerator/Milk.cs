using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refridgerator
{
    internal class Milk : Food
    {
        public Milk(DateTime expirationDate, double gallons, string name) : 
            base(expirationDate, name)
        {
            Gallons = gallons;
        }

        public double Gallons { get; set; }
    }
}
