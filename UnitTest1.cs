using Xunit;
using MyAverageLib;

namespace MyAverageLibTest
{
    public class UnitTest1
    {
        [Fact]
        public void TestAverageOfTwoNumbers()
        {
            double a = 10;
            double b = 20;
            double expected = 15;

            double actual = AverageCalculator.Avg(a, b);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestAverageOfThreeNumbers()
        {
            double a = 10;
            double b = 20;
            double c = 30;
            double expected = 20;

            double actual = AverageCalculator.Avg(a, b, c);

            Assert.Equal(expected, actual);
        }
    }
}