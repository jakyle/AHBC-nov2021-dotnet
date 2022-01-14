using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refridgerator
{
    internal interface ITryCheckDate
    {
        bool TryCheckDate(string name, out DateTime expirationDate);
    }
}
