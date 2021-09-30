namespace Vantage.Measurements.Prefixes
{
    /// <summary>
    /// Denotes a factor of one billion (1 000 000 000) [1e9]
    /// </summary>
    public class Giga : IPrefix
    {
        public static Giga Data { get; } = new Giga();

        public string Name { get; } = "Giga";
        public string Symbol { get; } = "G";
        public double Scale { get; } = 1e9;
    }
}