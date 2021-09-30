namespace Vantage.Measurements.Prefixes
{
    /// <summary>
    /// Denotes a factor of ten (10) [1e1]
    /// </summary>
    public class Deca : IPrefix
    {
        public static Deca Data { get; } = new Deca();

        public string Name { get; } = "Deca";
        public string Symbol { get; } = "da";
        public double Scale { get; } = 1e1;
    }
}