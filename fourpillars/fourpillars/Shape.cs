using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fourpillars
{
    // polymorpism
    public abstract class Shape
    {

        public abstract double GetArea();

        public abstract double GetVolume();

        public override string ToString()
        {
            return $"Area: {GetArea()}, Volume: {GetVolume()}";
        }
    }

    public class Cube : Shape
    {
        public Cube(double length)
        {
            Length = length;
        }

        public double Length { get; set; }

        public override double GetVolume()
        {
            return Math.Pow(Length, 3);
        }

        public override double GetArea()
        {
            return 6 * Math.Pow(Length, 2);
        }
    }

    public class Sphere : Shape
    {
        public Sphere(double radius)
        {
            Radius = radius;
        }

        public double Radius { get; set; }

        public override double GetVolume()
        {
            return ((4 / 3) * Math.PI) * Math.Pow(Radius, 3);
        }

        public override double GetArea()
        {
            return 4 * Math.PI * Math.Pow(Radius, 2);
        }
    }
}
