using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTesting;
using Xunit;

namespace MathTest
{
    public class WeatherDresserTests
    {
        [Fact]
        public void Warm_Weather_T_Shirt()
        {
            // Arrange  -  arrange or create your data for testing
            var a = TemperatureType.Warm;
            var weatherDresser = new WeatherDresser();

            // Act - Calling the method you want to test, and store the restults in a variable
            var actual = weatherDresser.GetClothingRecommendation(a);

            // Assert - basically assrting the values you expect from your acted test.
            Assert.Equal("t-shirt", actual);
        }

        [Fact]
        public void Cold_Weather_Jacket()
        {
            // Arrange  -  arrange or create your data for testing
            var a = TemperatureType.Cold;
            var weatherDresser = new WeatherDresser();

            // Act - Calling the method you want to test, and store the restults in a variable
            var actual = weatherDresser.GetClothingRecommendation(a);

            // Assert - basically assrting the values you expect from your acted test.
            Assert.Equal("jacket", actual);
        }
    }
}
