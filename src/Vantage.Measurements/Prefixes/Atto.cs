namespace Vantage.Measurements.Prefixes
{
    /// <summary>
    /// Denotes a factor of one quintillionth (0.000 000 000 000 000 001) [1e-18] 
    /// </summary>
    public class Atto : IPrefix
    {
        public static Atto Data { get; } = new Atto();

        public string Name { get; } = "Atto";
        public string Symbol { get; } = "a";
        public double Scale { get; } = 1e-18;
    }
}