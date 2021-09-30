namespace Vantage.Measurements.Units.Length
{
    public class Mile : ILengthUnit
    {
        public string Symbol { get; set; } = "mi";

        public string Name { get; set; } = nameof(Mile);

        public string PluralName { get; set; } = $"{nameof(Mile)}s";

        public UnitSystem System => UnitSystem.UsCustomary | UnitSystem.Imperial;

        public double FromMeters(double value)
            => value / 1609.344;

        public double ToMeters(double value)
            => value * 1609.344;
    }
}
