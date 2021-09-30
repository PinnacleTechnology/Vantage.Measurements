namespace Vantage.Measurements.Units.Time
{
    public class Tick : ITimeUnit
    {
        public string Symbol { get; set; } = "tick";
       
        public string Name { get; set; } = nameof(Tick);
       
        public string PluralName { get; set; } = $"{nameof(Tick)}s";
       
        public UnitSystem System => UnitSystem.Universal;

        public double ToSeconds(double value)
            => value * 100 * Prefixes.Nano.Data.Scale;

        public double FromSeconds(double value)
            => value / (100 * Prefixes.Nano.Data.Scale);
    }
}
