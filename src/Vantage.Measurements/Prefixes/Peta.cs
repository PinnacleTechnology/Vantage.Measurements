namespace Vantage.Measurements.Prefixes
{
    /// <summary>
    /// Denotes a factor of one quadrillion (1 000 000 000 000 000) [1e15]
    /// </summary>
    public class Peta : IPrefix
    {
        public static Peta Data { get; } = new Peta();

        public string Name { get; } = "Peta";
        public string Symbol { get; } = "P";
        public double Scale { get; } = 1e15;
    }
}