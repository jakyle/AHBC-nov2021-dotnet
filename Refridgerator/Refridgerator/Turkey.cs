using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refridgerator
{
    internal class Turkey : Food
    {
        public Turkey(DateTime expirationDate, double gramsOfProtien, string name) 
            : base(expirationDate, name)
        {
            GramsOfProtien = gramsOfProtien;
        }

        public double GramsOfProtien { get; set; }
    }
}
