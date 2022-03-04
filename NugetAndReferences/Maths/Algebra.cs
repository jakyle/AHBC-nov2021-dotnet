using System;

namespace Maths
{
    public static class Algebra
    {

        public static double YIntercept(double m, double x, double b)
        {
            return m * x + b;
        }


        public static double SquareRoot(double x)
        {
            return Math.Sqrt(Math.Abs(x));
        }
    }
}
