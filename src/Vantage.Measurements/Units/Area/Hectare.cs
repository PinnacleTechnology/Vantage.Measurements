namespace Vantage.Measurements.Units.Area
{
    public class Hectare : IAreaUnit
    {
        public string Symbol { get; set; } = "ha";

        public string Name { get; set; } = nameof(Hectare);

        public string PluralName { get; set; } = $"{nameof(Hectare)}s";

        public UnitSystem System => UnitSystem.International;

        public double ToSquareMeters(double value)
            => value * 1e4;

        public double FromSquareMeters(double value)
            => value / 1e4;
    }
}
