namespace Vantage.Measurements.Prefixes
{
    /// <summary>
    /// Denotes a factor of one hundredth (0.01) [1e-2]
    /// </summary>
    public class Centi : IPrefix
    {
        public static Centi Data { get; } = new Centi();

        public string Name { get; } = "Centi";
        public string Symbol { get; } = "c";
        public double Scale { get; } = 1e-2;
    }
}