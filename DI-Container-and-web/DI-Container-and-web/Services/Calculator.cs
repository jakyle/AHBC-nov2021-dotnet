using DI_Container_and_web.Controllers;

namespace DI_Container_and_web.Services
{
    public class Calculator : ICalculator
    {
        private readonly NoGoodService _noGoodService;

        public Calculator(NoGoodService noGoodService)
        {
            _noGoodService = noGoodService;
        }

        public double Add(double x, double y)
        {
            return x + y;
        }

        public double Divide(double x, double y)
        {
            return x / y;
        }

        public double Multiply(double x, double y)
        {
            return x * y;
        }

        public double Subtract(double x, double y)
        {
            return x - y;
        }
    }
}
