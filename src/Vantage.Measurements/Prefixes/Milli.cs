namespace Vantage.Measurements.Prefixes
{
    /// <summary>
    /// Denotes a factor of one thousandth (0.001) [1e-3]
    /// </summary>
    public class Milli : IPrefix
    {
        public static Milli Data { get; } = new Milli();

        public string Name { get; } = "Milli";
        public string Symbol { get; } = "m";
        public double Scale { get; } = 1e-3;
    }
}