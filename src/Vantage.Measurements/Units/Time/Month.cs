namespace Vantage.Measurements.Units.Time
{
    public class Month : ITimeUnit
    {
        public string Symbol { get; set; } = "month";

        public string Name { get; set; } = nameof(Month);

        public string PluralName { get; set; } = $"{nameof(Month)}s";

        public UnitSystem System => UnitSystem.Universal;

        public double ToSeconds(double value)
            => value * 2629746;

        public double FromSeconds(double value)
            => value / 2629746;
    }
}