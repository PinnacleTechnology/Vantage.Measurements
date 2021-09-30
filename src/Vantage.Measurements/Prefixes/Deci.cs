namespace Vantage.Measurements.Prefixes
{
    /// <summary>
    /// Denotes a factor of one tenth (0.1) [1e-1]
    /// </summary>
    public class Deci : IPrefix
    {
        public static Deci Data { get; } = new Deci();

        public string Name { get; } = "Deci";
        public string Symbol { get; } = "d";
        public double Scale { get; } = 1e-1;
    }
}