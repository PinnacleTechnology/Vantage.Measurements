namespace Vantage.Measurements.Prefixes
{
    /// <summary>
    /// Denotes a factor of one septillionth (0.000 000 000 000 000 000 000 001) [1e-24] 
    /// </summary>
    public class Yocto : IPrefix
    {
        public static Yocto Data { get; } = new Yocto();

        public string Name { get; } = "Yocto";
        public string Symbol { get; } = "y";
        public double Scale { get; } = 1e-24;
    }
}