namespace Vantage.Measurements.Prefixes
{
    /// <summary>
    /// Denotes a factor of one hundred (100) [1e2]
    /// </summary>
    public class Hecto : IPrefix
    {
        public static Hecto Data { get; } = new Hecto();

        public string Name { get; } = "Hecto";
        public string Symbol { get; } = "h";
        public double Scale { get; } = 1e2;
    }
}