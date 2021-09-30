namespace Vantage.Measurements.Prefixes
{
    /// <summary>
    /// Denotes a factor of one quadrillionth (0.000 000 000 000 001) [1e-15]
    /// </summary>
    public class Femto : IPrefix
    {
        public static Femto Data { get; } = new Femto();

        public string Name { get; } = "Femto";
        public string Symbol { get; } = "f";
        public double Scale { get; } = 1e-15;
    }
}