namespace Vantage.Measurements.Prefixes
{
    /// <summary>
    /// Denotes a factor of one millionth (0.000 001) [1e-6]
    /// </summary>
    public class Micro : IPrefix
    {
        public static Micro Data { get; } = new Micro();

        public string Name { get; } = "Micro";
        public string Symbol { get; } = "μ";
        public double Scale { get; } = 1e-6;
    }
}