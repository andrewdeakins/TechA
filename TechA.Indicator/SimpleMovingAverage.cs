
namespace TechA.Indicator
{
    public class SimpleMovingAverage
    {
        public SimpleMovingAverage(int period)
        {
            Period = period;
        }

        public int Period { get; protected set; }

        public double?[] Calculate(double[] prices)
        {
            if (prices.Length < Period) return new double?[prices.Length];

            throw new System.NotImplementedException();
        }
    }
}
