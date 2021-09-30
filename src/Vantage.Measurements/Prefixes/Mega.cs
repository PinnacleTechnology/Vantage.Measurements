namespace Vantage.Measurements.Prefixes
{
    /// <summary>
    /// Denotes a factor of one million (1 000 000) [1e6]
    /// </summary>
    public class Mega : IPrefix
    {
        public static Mega Data { get; } = new Mega();

        public string Name { get; } = "Mega";
        public string Symbol { get; } = "M";
        public double Scale { get; } = 1e6;
    }
}