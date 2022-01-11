using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_classroom_example
{
    public class RoomCalculator
    {
        public int Length { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }

        // this is a getter with no setter, ie, a Calculated Property
        public int Area => Length * Height;
        public int Volume => Area * Height;

        public RoomCalculator(int length, int height, int width)
        {
            this.Length = length;
            this.Height = height;
            this.Width = width;
        }


        // if you are creating a "GET METHOD" that takes NO parameters, and you are 
        // doing calculations WITH your internal fields / data... just make
        // READ ONLY property
        public int GetArea()
        {
            return Length * Width;
        }

        public int GetVolume()
        {
            return Height * GetArea();
        }
    }
}
