namespace Vantage.Measurements.Prefixes
{
    /// <summary>
    /// Denotes a factor of one quintillion (1 000 000 000 000 000 000) [1e18]
    /// </summary>
    public class Exa : IPrefix
    {
        public static Exa Data { get; } = new Exa();

        public string Name { get; } = "Exa";
        public string Symbol { get; } = "E";
        public double Scale { get; } = 1e18;
    }
}