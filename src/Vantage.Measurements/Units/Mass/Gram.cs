namespace Vantage.Measurements.Units.Mass
{
    public class Gram : IMassUnit
    {
        public string Symbol { get; set; } = "g";

        public string Name { get; set; } = nameof(Gram);

        public string PluralName { get; set; } = $"{nameof(Gram)}s";

        public UnitSystem System => UnitSystem.International;

        public double ToKilograms(double value)
            => value / Prefixes.Kilo.Data.Scale;

        public double FromKilograms(double value)
            => value * Prefixes.Kilo.Data.Scale;
    }
}