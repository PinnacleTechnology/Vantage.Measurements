namespace Vantage.Measurements.Units.Length
{
    public class Yard : ILengthUnit
    {
        public string Symbol { get; set; } = "yd";

        public string Name { get; set; } = nameof(Yard);

        public string PluralName { get; set; } = $"{nameof(Yard)}s";

        public UnitSystem System => UnitSystem.UsCustomary | UnitSystem.Imperial;

        public double FromMeters(double value)
            => value / 0.9144;

        public double ToMeters(double value)
            => value * 0.9144;
    }
}
