using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Car : IMove, IStartEngine /*ITurn*/
    {
        public void Move()
        {
            // write some logic that moves my car...
        }

        public void StartEngine(string key)
        {
            // logic to turn key into ignition and start car...
        }
    }

    public class Truck : IMove, IStartEngine
    {
        public void Move()
        {
            //
        }

        public void StartEngine(string key)
        {
            //
        }
    }

    // interfaces are public contracts
    interface IMove
    {
        void Move();
    }

    interface IStartEngine
    {
        void StartEngine(string key);
    }
}
