namespace Vantage.Measurements.Units.Volume
{
    public class ImperialGallon : IVolumeUnit
    {
        public string Symbol { get; set; } = "gal (imp)";

        public string Name { get; set; } = "Imperial Gallon";

        public string PluralName { get; set; } = "Imperial Gallons";

        public UnitSystem System => UnitSystem.Imperial;

        public double ToCubicMeters(double value)
            => value * 4.54609e-3;

        public double FromCubicMeters(double value)
            => value / 4.54609e-3;
    }
}