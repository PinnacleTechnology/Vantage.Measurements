namespace Vantage.Measurements.Prefixes
{
    /// <summary>
    /// Denotes a factor of one septillion (1 000 000 000 000 000 000 000 000) [1e24]
    /// </summary>
    public class Yotta : IPrefix
    {
        public static Yotta Data { get; } = new Yotta();

        public string Name { get; } = "Yotta";
        public string Symbol { get; } = "Y";
        public double Scale { get; } = 1e24;
    }
}
