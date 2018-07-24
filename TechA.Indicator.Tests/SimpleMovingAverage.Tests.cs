using NUnit.Framework;

namespace TechA.Indicator.Tests
{
    [TestFixture]
    public class SimpleMovingAverageTests
    {
        [Test]
        public void should_return_empty_array_if_no_prices_passed_to_calculate()
        {
            var sma = new SimpleMovingAverage(5);
            var result = sma.Calculate(new double[] {});
            Assert.AreEqual(0, result.Length);
        }
    }
}
