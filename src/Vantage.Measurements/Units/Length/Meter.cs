using Vantage.Measurements.Prefixes;

namespace Vantage.Measurements.Units.Length
{
    public class Meter : ILengthUnit
    {
        public string Symbol { get; set; } = "m";

        public string Name { get; set; } = nameof(Meter);

        public string PluralName { get; set; } = $"{nameof(Meter)}s";

        public UnitSystem System => UnitSystem.International;

        public double FromMeters(double value)
            => value;

        public double ToMeters(double value)
            => value;
    }
}