using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refridgerator
{
    internal interface ITryGiveFood
    {
        bool TryGetFood(string name, out Food food);
    }
}
