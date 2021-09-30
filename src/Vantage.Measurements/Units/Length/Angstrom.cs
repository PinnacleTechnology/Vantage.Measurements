namespace Vantage.Measurements.Units.Length
{
    public class Angstrom : ILengthUnit
    {
        public string Symbol { get; set; } = "\u212b";

        public string Name { get; set; } = nameof(Angstrom);

        public string PluralName { get; set; } = $"{nameof(Angstrom)}s";

        public UnitSystem System => UnitSystem.Universal;

        public double FromMeters(double value)
            => value / (100 * Prefixes.Pico.Data.Scale);

        public double ToMeters(double value)
            => value * (100 * Prefixes.Pico.Data.Scale);
    }
}
