namespace Vantage.Measurements.Units.Time
{
    public class Second : ITimeUnit
    {
        public string Symbol { get; set; } = "s";

        public string Name { get; set; } = nameof(Second);

        public string PluralName { get; set; } = $"{nameof(Second)}s";

        public UnitSystem System => UnitSystem.Universal;

        public double ToSeconds(double value)
            => value;

        public double FromSeconds(double value)
            => value;
    }
}