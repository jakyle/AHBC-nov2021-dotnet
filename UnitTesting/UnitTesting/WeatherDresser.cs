using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting
{
    public class WeatherDresser
    {
        public string GetClothingRecommendation(TemperatureType tempType)
        {
            return tempType switch
            {
                TemperatureType.Warm => "t-shirt",
                TemperatureType.Cold => "jacket",
            };
        }
    }
}
