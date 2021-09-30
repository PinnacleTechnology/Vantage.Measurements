namespace Vantage.Measurements.Prefixes
{
    /// <summary>
    /// Denotes a factor of one trillion (1 000 000 000 000) [1e12]
    /// </summary>
    public class Tera : IPrefix
    {
        public static Tera Data { get; } = new Tera();

        public string Name { get; } = "Tera";
        public string Symbol { get; } = "T";
        public double Scale { get; } = 1e12;
    }
}