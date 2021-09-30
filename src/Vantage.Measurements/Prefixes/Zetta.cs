namespace Vantage.Measurements.Prefixes
{
    /// <summary>
    /// Denotes a factor of one sextillion (1 000 000 000 000 000 000 000) [1e21]
    /// </summary>
    public class Zetta : IPrefix
    {
        public static Zetta Data { get; } = new Zetta();

        public string Name { get; } = "Zetta";
        public string Symbol { get; } = "Z";
        public double Scale { get; } = 1e21;
    }
}