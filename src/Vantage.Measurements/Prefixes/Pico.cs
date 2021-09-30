namespace Vantage.Measurements.Prefixes
{
    /// <summary>
    /// Denotes a factor of one trillionth (0.000 000 000 001) [1e-12]
    /// </summary>
    public class Pico : IPrefix
    {
        public static Pico Data { get; } = new Pico();

        public string Name { get; } = "Pico";
        public string Symbol { get; } = "p";
        public double Scale { get; } = 1e-12;
    }
}