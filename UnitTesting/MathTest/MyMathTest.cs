using UnitTesting;
using Xunit;

namespace MathTest
{
    public class MyMathTest
    {
        // This is an attributes, attributes are used to "decorate" or "TAG" a specific "thing", and that 
        // tag will tell your compiler or at run time to do "extra things"
        // in this case, the "Fact" tag tells the dotnet testing suite that this is a unit test
        [Fact]
        public void Add_One_And_One_And_Get_Two()
        {
            // Arrage  -  arrange or create your data for testing
            var a = 1;
            var b = 1;
            var myMath = new MyMath();

            // Act - Calling the method you want to test, and store the restults in a variable
            var actual = myMath.Add(a, b);

            // Assert - basically assrting the values you expect from your acted test.
            Assert.Equal(2, actual);
        }
    }
}
