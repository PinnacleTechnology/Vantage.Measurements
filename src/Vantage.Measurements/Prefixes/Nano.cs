namespace Vantage.Measurements.Prefixes
{
    /// <summary>
    /// Denotes a factor of one billionth (0.000 000 001) [1e-9]
    /// </summary>
    public class Nano : IPrefix
    {
        public static Nano Data { get; } = new Nano();

        public string Name { get; } = "Nano";
        public string Symbol { get; } = "n";
        public double Scale { get; } = 1e-9;
    }
}