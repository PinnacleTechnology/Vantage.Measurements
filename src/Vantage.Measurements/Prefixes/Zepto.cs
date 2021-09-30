namespace Vantage.Measurements.Prefixes
{
    /// <summary>
    /// Denotes a factor of one sextillionth (0.000 000 000 000 000 000 001) [1e-21] 
    /// </summary>
    public class Zepto : IPrefix
    {
        public static Zepto Data { get; } = new Zepto();

        public string Name { get; } = "Zepto";
        public string Symbol { get; } = "z";
        public double Scale { get; } = 1e-21;
    }
}