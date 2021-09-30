namespace Vantage.Measurements.Prefixes
{
    /// <summary>
    /// Denotes a factor of one thousand (1 000) [1e3]
    /// </summary>
    public class Kilo : IPrefix
    {
        public static Kilo Data { get; } = new Kilo();

        public string Name { get; } = "Kilo";
        public string Symbol { get; } = "k";
        public double Scale { get; } = 1e3;
    }
}