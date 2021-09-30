namespace Vantage.Measurements.Prefixes
{
    public interface IPrefix
    {
        string Name { get; }
        string Symbol { get; }
        double Scale { get; }
    }
}